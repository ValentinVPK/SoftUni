using CarDealer.Data;
using CarDealer.DataTransferObjects.Input;
using CarDealer.DataTransferObjects.Output;
using CarDealer.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new CarDealerContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var supplierXml = File.ReadAllText("./Datasets/parts.xml");

            var result = GetSalesWithAppliedDiscount(context);

            System.Console.WriteLine(result);
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("sales");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SalesOutputModel[]), xmlRoot);
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            StringBuilder sb = new StringBuilder();
            using StringWriter stringWriter = new StringWriter(sb);

            SalesOutputModel[] salesDto = context
                .Sales
                .Select(s => new SalesOutputModel()
                {
                    Car = new CarSaleOutputModel()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TravelledDistance.ToString()
                    },
                    Discount = s.Discount.ToString(),
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartCars.Sum(pc => pc.Part.Price).ToString(),
                    PriceWithDiscount = (s.Car.PartCars.Sum(pc => pc.Part.Price) -
                            s.Car.PartCars.Sum(pc => pc.Part.Price) * s.Discount / 100).ToString()
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, salesDto, namespaces);

            return sb.ToString().Trim();
        }
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("cars");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CarOutputModel[]), xmlRoot);
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            StringBuilder sb = new StringBuilder();
            using StringWriter stringWriter = new StringWriter(sb);

            CarOutputModel[] carsDttos = context.Cars
                .Where(c => c.TravelledDistance >= 2_000_000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .Select(c => new CarOutputModel()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TravelledDistance.ToString()
                })
                .ToArray();


            xmlSerializer.Serialize(stringWriter, carsDttos, namespaces);


            return sb.ToString().TrimEnd();
        }
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Cars");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CarInputModel[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            

            CarInputModel[] dtos = (CarInputModel[])xmlSerializer.Deserialize(stringReader);

            ICollection<Car> cars = new HashSet<Car>();

            foreach (var carDto in dtos)
            {
                Car c = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledDistance = carDto.TraveledDistance
                };

                ICollection<PartCar> currCarParts = new HashSet<PartCar>();
                foreach (var partId in carDto.Parts.Select(p => p.Id).Distinct())
                {
                    Part part = context.Parts.Find(partId);
                    
                    if(part == null)
                    {
                        continue;
                    }

                    PartCar partCar = new PartCar()
                    {
                        Car = c,
                        Part = part
                    };

                    currCarParts.Add(partCar);
                }

                c.PartCars = currCarParts;
                cars.Add(c);
            }

            context.AddRange(cars);
            context.SaveChanges();


            return $"Successfully imported {cars.Count}";

        }
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Parts");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PartInputModel[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            PartInputModel[] dttos = (PartInputModel[])xmlSerializer.Deserialize(stringReader);

            ICollection<Part> parts = new HashSet<Part>();

            foreach (var partDtto in dttos)
            {
                Supplier supplier = context.Suppliers.Find(partDtto.SupplierId);

                if(supplier == null)
                {
                    continue;
                }

                Part p = new Part()
                {
                    Name = partDtto.Name,
                    Price = decimal.Parse(partDtto.Price),
                    Quantity = partDtto.Quantity,
                    SupplierId = partDtto.SupplierId,
                    Supplier = supplier
                };

                parts.Add(p);
            }

            context.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Suppliers");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SupplierInputModel[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);



            SupplierInputModel[] dttos = (SupplierInputModel[])xmlSerializer.Deserialize(stringReader);

            ICollection<Supplier> suppliers = new HashSet<Supplier>();

            foreach (var supplierDtto in dttos)
            {
                Supplier s = new Supplier()
                {
                    Name = supplierDtto.Name,
                    IsImporter = bool.Parse(supplierDtto.IsImporter)
                };

                suppliers.Add(s);
            }

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";
        }           
    }
}
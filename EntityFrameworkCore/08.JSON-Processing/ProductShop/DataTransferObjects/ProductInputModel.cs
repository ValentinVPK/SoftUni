using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.DataTransferObjects
{
    public class ProductInputModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int SellerId { get; set; }
        public int? BuyerId { get; set; }
    }
}

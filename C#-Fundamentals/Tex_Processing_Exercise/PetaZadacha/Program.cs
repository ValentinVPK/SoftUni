using System;
using System.Text;

namespace PetaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            bigNumber = bigNumber.TrimStart('0');
            int multiplyingNumber = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            if(multiplyingNumber == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int multiply = 0;
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                multiply = (int.Parse(Convert.ToString(bigNumber[i])) * multiplyingNumber) + multiply;
                result.Insert(0, (multiply % 10).ToString());
                multiply /= 10;
            }

            if (multiply > 0) result.Insert(0, multiply);
            Console.WriteLine(result);
        }
    }
}

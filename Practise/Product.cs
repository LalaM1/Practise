using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Product
    {
        private static int static_id = 1000;
        public int ID { get; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpireDate { get; set; }  //son saxlanilma tarixi

        public Product()
        {
            static_id++;
            ID = static_id;
            Name = "None";
            Price = 5;
            ExpireDate = DateTime.Now.AddDays(15); //cari tarixe 15 gun elave edecek
        }
                                    
        public Product(string? name, double price, DateTime expireDate):this() //default constructorun delegate
        {    
            Name = name;
            Price = price;
            ExpireDate = expireDate;
        }

        public void Show()
        {
            if (ExpireDate < DateTime.Now)
            {
                Console.ForegroundColor = ConsoleColor.Red;  //mehsulun vaxti kecende qirmizi rengde gorunecek
            }
          
            RegionInfo aze = new RegionInfo("az-AZ");
            Console.WriteLine($"Product id: {ID}");
            Console.WriteLine($"Product name: {Name}");
            Console.WriteLine($"Price: {Price} {aze.CurrencySymbol}");
            Console.WriteLine($"Expire date: {ExpireDate.ToLongDateString()}");

            Console.ResetColor();
        }
    }
}

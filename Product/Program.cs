using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IProduct> ProductList = new List<IProduct>(10);
            string pathOut = @"D:\Final Project\Old Products.txt";
            string pathIn = @"D:\Final Project\New Products.txt";
            string[] type = new string[6];
            string item = "";
            try
            {
                using (StreamReader reader = new StreamReader(pathOut))
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if ((item = reader.ReadLine()) != null)
                        {
                            type = item.Split(new char[] { ',' });
                            Console.WriteLine(item);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            for (int i = 0; i < 9; i++)
            {
                using (StreamWriter writer = new StreamWriter(pathIn, false))
                {
                    writer.WriteLine(item);
                }
            }
            
            Console.ReadLine();
            //MeatProduct meatProduct1 = new Meat(0,"Krakivske", 98, "tastes good", 12);
            //MeatProduct meatProduct3 = new Sausage(2, "Lvivska", 104, "tastes well", 45);
            //DairyProduct dairyProduct2 = new Milk(1, "Vashington", 15, "soft", 23);
            //DairyProduct dairyProduct4 = new Kefir(3, "Munich", 17, "alco", 36);
            //MeatProduct meatProduct5 = new Meat(4, "Kyivske", 112, "awesome", 18);
            //DairyProduct dairyProduct6 = new Milk(5, "Poznan", 22, "cool", 85);
            //MeatProduct meatProduct8 = new Sausage(7, "Varshavska", 98, "tastes very good", 58);
            //DairyProduct dairyProduct7 = new Kefir(6, "Mariupol", 29, "sweet", 54);
            //MeatProduct meatProduct9 = new Meat(8, "Londonske", 98, "tastes awesome", 21);
            //DairyProduct dairyProduct10 = new Milk(9, "Kharkiv",23,"sauwer", 32);
            //ProductList.Add(meatProduct1);
            //ProductList.Add(dairyProduct10);
            //ProductList.Add(dairyProduct7);
            //ProductList.Add(meatProduct9);
            //ProductList.Add(dairyProduct6);
            //ProductList.Add(meatProduct5);
            //ProductList.Add(dairyProduct4);
            //ProductList.Add(dairyProduct2);
            //ProductList.Add(meatProduct3);
            //ProductList.Add(meatProduct8);
            //foreach (IProduct product in ProductList)
            //{
            //    product.Print();
            //}
            //Console.ReadLine();

            //var sortProduct = ProductList.OrderByDescending(x => x.Id);
            //foreach (IProduct product in sortProduct)
            //    product.Print();
            //Console.ReadLine();

            //foreach (IProduct product in ProductList)
            //{
            //    if (product.GetType() == typeof(Milk) && product.Price <= 20)
            //    {
            //        product.Print();
            //    }
            //}
            //Console.ReadLine();

            //foreach (IProduct product in ProductList)
            //{
            //    if (product.GetType() == typeof(Meat) && product.Quantity > 20)
            //    {
            //        product.Print();
            //    }
            //}
            //Console.ReadLine();
        }
    }
}

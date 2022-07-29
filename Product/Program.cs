using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> productList = new List<IProduct>();
            //string pathOut = @"D:\Final Project\Old Products.txt";
            //string pathIn = @"D:\Final Project\New Products.txt";
            //string[] productItem = new string[6];
            //string item = "";
            //try
            //{
            //    using (StreamReader reader = new StreamReader(pathOut))
            //    {
            //        for (int i = 0; i < 9; i++)
            //        {
            //            if ((item = reader.ReadLine()) != null)
            //            {
            //                productItem = item.Split(new char[] { ',' });
            //                    Console.WriteLine(item);
            //            }
            //        }
            //    }
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File not found");
            //}
            //for (int i = 0; i < 9; i++)
            //{
            //    using (StreamWriter writer = new StreamWriter(pathIn, false))
            //    {
            //        writer.WriteLine(item);
            //    }
            //}
            //Console.ReadLine();

            MeatProduct meatProduct1 = new Meat(0, "Krakivske", 98, "tastes good", 13);
            MeatProduct meatProduct3 = new Sausage(2, "Lvivska", 104, "tastes well", 34);
            DairyProduct dairyProduct2 = new Milk(1, "Vashington", 15, "soft", 42);
            DairyProduct dairyProduct4 = new Kefir(3, "Munich", 17, "alco", 24);
            MeatProduct meatProduct5 = new Meat(4, "Kyivske", 112, "awesome", 76);
            DairyProduct dairyProduct6 = new Milk(5, "Poznan", 22, "cool",33);
            MeatProduct meatProduct8 = new Sausage(7, "Varshavska", 98, "tastes very good",19);
            DairyProduct dairyProduct7 = new Kefir(6, "Mariupol", 29, "sweet", 41);
            MeatProduct meatProduct9 = new Meat(8, "Londonske", 98, "tastes awesome", 84);
            DairyProduct dairyProduct10 = new Milk(9, "Kharkiv", 23, "sauwer", 58);

            productList.Add(meatProduct1);
            productList.Add(dairyProduct10);
            productList.Add(dairyProduct7);
            productList.Add(meatProduct9);
            productList.Add(dairyProduct6);
            productList.Add(meatProduct5);
            productList.Add(dairyProduct4);
            productList.Add(dairyProduct2);
            productList.Add(meatProduct3);
            productList.Add(meatProduct8);

            foreach (IProduct product in productList)
            {
                product.Print();
            }

            Console.ReadLine();
            //Stream stream = new FileStream("product.json", FileMode.Create);
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(IProduct));
            //ser.WriteObject(stream, productList);
            //stream.Position = 0;
            //List<IProduct> productList2 = new List<IProduct>();
            //productList2 = (List<IProduct>)ser.ReadObject(stream);

            var sortProduct = productList.OrderByDescending(x => x.Id);
            foreach (IProduct product in sortProduct)
            {
                product.Print();
            }

            Console.ReadLine();

            foreach (IProduct product in productList)
            {
                if (product.GetType() == typeof(Milk) && product.Price <= 20)
                {
                    product.Print();
                }
            }

            Console.ReadLine();

            foreach (IProduct product in productList)
            {
                if (product.GetType() == typeof(Meat) && product.Quantity > 20)
                {
                    product.Print();
                }
            }

            Console.ReadLine();
        }
    }
}

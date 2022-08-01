using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Create List of products
                List<IProduct> productList = new List<IProduct>();
                MeatProduct meatProduct1 = new Meat(0, "Krakivske", 98, "tastes good", 13, "pork");
                MeatProduct meatProduct3 = new Sausage(2, "Lvivska", 104, "tastes well", 34,"beaf");
                DairyProduct dairyProduct2 = new Milk(1, "Vashington", 15, "soft", 42, 2);
                DairyProduct dairyProduct4 = new Kefir(3, "Munich", 17, "alco", 24, 3);
                MeatProduct meatProduct5 = new Meat(4, "Kyivske", 112, "awesome", 76, "veal");
                DairyProduct dairyProduct6 = new Milk(5, "Poznan", 22, "cool", 33, 4);
                MeatProduct meatProduct8 = new Sausage(7, "Varshavska", 98, "tastes very good", 19, "pork");
                DairyProduct dairyProduct7 = new Kefir(6, "Mariupol", 29, "sweet", 41, 5);
                MeatProduct meatProduct9 = new Meat(8, "Londonske", 98, "tastes awesome", 84, "beaf");
                DairyProduct dairyProduct10 = new Milk(9, "Kharkiv", 23, "sauwer", 58, 6);
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
                //// Serialize from stream - work
                //FileStream fs = new FileStream("product67.json", FileMode.Create);
                //JsonSerializer.Serialize(fs, productList);
                //Console.WriteLine("Data has been saved to file");
                //fs.Close();
                // Deserialize from stream - don't work
                //List<IProduct> productList2 = new List<IProduct>();
                //FileStream fs2 = new FileStream("product.json", FileMode.OpenOrCreate);
                //productList2 = JsonSerializer.Deserialize<List<IProduct>>(fs2);

                //foreach (IProduct product in productList2)
                //{
                //    product.Print();
                //}

                //using (FileStream fs = new FileStream("product.json", FileMode.OpenOrCreate))
                //{
                //    // List<IProduct> productList2 = new List<IProduct>();
                //    IProduct productList2 = JsonSerializer.Deserialize<IProduct>(fs);
                //    Console.WriteLine(productList2);
                //}

                // Serialize from DataContract - don't work
                //Stream stream = new FileStream("person.json", FileMode.Create);
                //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(IProduct));
                //ser.WriteObject(stream, (IProduct)productList);
                //Console.WriteLine("Data has been saved to file");
                //Console.ReadLine();

                //// Deserialize from DataContract - don't work
                //stream.Position = 0;
                //IProduct productList2 = (IProduct) ser.ReadObject(stream);
                //Console.WriteLine("YES");
                Console.ReadLine();

                    // Start program
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("\t\tIt's my finally project");
                Console.WriteLine();
                Console.WriteLine();
     start:     Console.WriteLine("\t\tSTART MENU" +
                                  "\r\n\tYou have 10 products" +
                                  "\r\nEnter '1' if you want to see all products." +
                                  "\r\nEnter '2' if you want choose action" +
                                  "\r\nEnter '3' if you want come back to begin");
                Console.WriteLine();
                // First menu
                switch (Console.ReadLine())
                {
                    // Prewiew all products
                    case "1":
                        foreach (IProduct product in productList)
                        {
                            product.Print();
                        }

                        goto start;

                    // Choose filters
                    case "2":
     select:                Console.WriteLine("\t\tFILTER MENU" +
                                            "\r\n\tYou can choose from next filters:" +
                                            "\r\nEnter 1 if you want sorted all producrt by ID" +
                                            "\r\nEnter 2 if you want sorted by limit price" +
                                            "\r\nEnter 3 if you want sorted by limit quantity" +
                                            "\r\nEnter 4 if you want come back to begin");
                    switch (Console.ReadLine())
                    {
                        // Order by Descending
                        case "1":
                        var sortProduct = productList.OrderByDescending(x => x.Id);
                        foreach (IProduct product in sortProduct)
                        {
                            product.Print();
                        }

                        goto select;

                        // Limit price
                        case "2":
                        Console.WriteLine("Enter limit product's price:");
                        bool succeessPrice = int.TryParse(Console.ReadLine(), out int limitPrice);
                        foreach (IProduct product in productList)
                        {
                            if (product.GetType() == typeof(Milk) && product.Price <= limitPrice)
                            {
                                product.Print();
                            }
                        }

                        Console.WriteLine();

                        goto select;

                        // Product quantity
                        case "3":
                        Console.WriteLine("Enter limit product's quantity:");
                        bool succeessQuantity = int.TryParse(Console.ReadLine(), out int limitQuantity);
                        if (succeessQuantity == true)
                        {
     name:              Console.WriteLine("Enter type of product:");
                            string succeessType = Console.ReadLine();
                            switch (succeessType)
                            {
                                case "Meat":
                                foreach (IProduct product in productList)
                                {
                                    if (product.GetType() == typeof(Meat) && product.Quantity > limitQuantity)
                                    {
                                        product.Print();
                                    }
                                }

                                break;
                                case "Sausage":
                                foreach (IProduct product in productList)
                                {
                                    if (product.GetType() == typeof(Sausage) && product.Quantity > limitQuantity)
                                    {
                                        product.Print();
                                    }
                                }

                                break;
                                case "Milk":
                                foreach (IProduct product in productList)
                                {
                                    if (product.GetType() == typeof(Milk) && product.Quantity > limitQuantity)
                                    {
                                        product.Print();
                                    }
                                }

                                break;
                                case "Kefir":
                                foreach (IProduct product in productList)
                                {
                                    if (product.GetType() == typeof(Kefir) && product.Quantity > limitQuantity)
                                    {
                                        product.Print();
                                    }
                                }

                                goto select;
                                default:
                                Console.WriteLine("Product don't have in LIST");
                                goto name;
                            }

                            Console.WriteLine();
                            goto select;
                        }

                        break;
                        case "4":
                        goto start;
                        default:
                        break;
                    }

                        break;
                    case "3":
                        goto start;
                    default:
                        goto start;
                }

                Console.ReadLine();
            }
        }
    }
}

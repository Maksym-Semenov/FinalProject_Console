using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Create List of products
                List<IProduct> productListSer = new List<IProduct>();
                MeatProduct meatProduct1 = new Meat(0, "Krakivske", 98, "tastes good", 13, "pork");
                MeatProduct meatProduct3 = new Sausage(2, "Lvivska", 104, "spicy", 34,"beaf");
                DairyProduct dairyProduct2 = new Milk(1, "Washington", 15, "soft", 42, 2);
                DairyProduct dairyProduct4 = new Kefir(3, "Munich", 17, "alco", 24, 3);
                MeatProduct meatProduct5 = new Meat(4, "Kyivske", 112, "fresh", 76, "veal");
                DairyProduct dairyProduct6 = new Milk(5, "Poznan", 22, "cool", 33, 4);
                MeatProduct meatProduct8 = new Sausage(7, "Varshavska", 98, "smoked", 19, "pork");
                DairyProduct dairyProduct7 = new Kefir(6, "Mariupol", 29, "sweet", 41, 5);
                MeatProduct meatProduct9 = new Meat(8, "Londonske", 98, "savory", 84, "beaf");
                DairyProduct dairyProduct10 = new Milk(9, "Kharkiv", 23, "lactoze free", 58, 6);
                productListSer.Add(meatProduct1);
                productListSer.Add(dairyProduct10);
                productListSer.Add(dairyProduct7);
                productListSer.Add(meatProduct9);
                productListSer.Add(dairyProduct6);
                productListSer.Add(meatProduct5);
                productListSer.Add(dairyProduct4);
                productListSer.Add(dairyProduct2);
                productListSer.Add(meatProduct3);
                productListSer.Add(meatProduct8);
                foreach (IProduct product in productListSer)
                {
                    product.Print();
                }

                // Serialize&
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
                serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
                serializer.Formatting = Newtonsoft.Json.Formatting.Indented;

                using (StreamWriter sw = new StreamWriter("product.json"))
                using (Newtonsoft.Json.JsonWriter writer = new Newtonsoft.Json.JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, productListSer, typeof(List<IProduct>));
                }

                // Deserialize
                List<IProduct> productList2 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<IProduct>>(File.ReadAllText("products22.json"), new Newtonsoft.Json.JsonSerializerSettings
                {
                    TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto,
                    NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                });
                Console.WriteLine();
                var sortProductDeser = productListSer.OrderBy(x => x.Id);
                foreach (IProduct product in sortProductDeser)
                {
                    product.Print();
                }

                // Start program
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("\t\tIt's my finally project\r\n");
            start: Console.WriteLine("\t\tSTART MENU" +
                                  "\r\n\tYou have " + productListSer.Count + " products" +
                                  "\r\nEnter '1' if you want to see all products." +
                                  "\r\nEnter '2' if you want to sort products" +
                                  "\r\nEnter '3' if you want to come back to Start Menu");
                Console.WriteLine();

                // First menu
                switch (Console.ReadLine())
                {
                    // Prewiew all products
                    case "1":
                        foreach (IProduct product in productListSer)
                        {
                            product.Print();
                        }

                        goto start;

                    // Choose filters
                    case "2":
                    select: Console.WriteLine("\t\tFILTER MENU" +
                                        "\r\n\tYou can choose filter from PRODUCT LIST:" +
                                        "\r\nEnter 1 if you want to sort all products by ID" +
                                        "\r\nEnter 2 if you want to sort all products by limit price" +
                                        "\r\nEnter 3 if you want to sort all products by limit quantity" +
                                        "\r\nEnter 4 if you want to come back to Start Menu");

                        // Order by Descending
                        switch (Console.ReadLine())
                        {
                        case "1":
                        var sortProduct = productListSer.OrderByDescending(x => x.Id);
                        foreach (IProduct product in sortProduct)
                        {
                            product.Print();
                        }

                        goto select;

                        // Limit price
                        case "2":
                        Console.WriteLine("Enter limit product price:");
                        bool succeessPrice = int.TryParse(Console.ReadLine(), out int limitPrice);
                        foreach (IProduct product in productListSer)
                        {
                            if (product.Price <= limitPrice)
                            {
                                product.Print();
                            }
                        }

                        Console.WriteLine();

                        goto select;

                        // Product quantity
                        case "3":
                        Console.WriteLine("Enter limit product quantity:");
                        bool succeessQuantity = int.TryParse(Console.ReadLine(), out int limitQuantity);
                        if (succeessQuantity == true)
                        {
                                name: Console.WriteLine("Enter type of product:");
                            string succeessType = Console.ReadLine();
                            switch (succeessType)
                            {
                                case "Meat":
                                foreach (IProduct product in productListSer)
                                {
                                    if (product.GetType() == typeof(Meat) && product.Quantity > limitQuantity)
                                    {
                                        product.Print();
                                    }
                                }

                                break;
                                case "Sausage":
                                foreach (IProduct product in productListSer)
                                {
                                    if (product.GetType() == typeof(Sausage) && product.Quantity > limitQuantity)
                                    {
                                        product.Print();
                                    }
                                }

                                break;
                                case "Milk":
                                foreach (IProduct product in productListSer)
                                {
                                    if (product.GetType() == typeof(Milk) && product.Quantity > limitQuantity)
                                    {
                                        product.Print();
                                    }
                                }

                                break;
                                case "Kefir":
                                foreach (IProduct product in productListSer)
                                {
                                    if (product.GetType() == typeof(Kefir) && product.Quantity > limitQuantity)
                                    {
                                        product.Print();
                                    }
                                }

                                goto select;
                                default:
                                Console.WriteLine("Product is not in LIST");
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

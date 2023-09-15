﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketConsoleApp.Helpers
{
    public class SubMenuHelper
    {
        public static void DisplayOperationsOnProducts()
        {
            int selectedOption;

            do
            {
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Update product");
                Console.WriteLine("3. Delete product");
                Console.WriteLine("4. Show all product");
                Console.WriteLine("5. Display of products according to the given category");
                Console.WriteLine("6. Display of products according to the given price range");
                Console.WriteLine("7. Search products according to the given name");

                Console.WriteLine("0. Exit");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Please, select an option:");

                while (!int.TryParse(Console.ReadLine(), out selectedOption))
                {
                    Console.WriteLine("Please enter valid option:");
                }

                switch (selectedOption)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }
            } while (selectedOption != 0);
        }

        public static void DisplayOperationsOnSale()
        {
            int selectedOption;

            do
            {
                Console.WriteLine("1. Add new sale");
                Console.WriteLine("2. Returning product on sale ");
                Console.WriteLine("3. Delete sale");
                Console.WriteLine("4. Show all sales");
                Console.WriteLine("5. Display of sales according to the given date range");
                Console.WriteLine("6. Display of sales according to the given price range");
                Console.WriteLine("7. Showing sales on a given date");
                Console.WriteLine("8. Showing deatils of sales by given id");

                Console.WriteLine("0. Exit");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Please, select an option:");

                while (!int.TryParse(Console.ReadLine(), out selectedOption))
                {
                    Console.WriteLine("Please enter valid option:");
                }

                switch (selectedOption)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }
            } while (selectedOption != 0);
        }
    }
}

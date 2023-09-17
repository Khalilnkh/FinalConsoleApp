﻿using MarketConsoleApp.Data.Enums;
using MarketConsoleApp.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketConsoleApp.Services.Concrete
{
    public class MenuService
    {
        private static IMarketService marketService = new MarketService();

        public static void AddProduct()
        {
            try
            {
                Console.WriteLine("Enter product's name:");
                string name = Console.ReadLine()!;
                ValidateMyString(name);

                static void ValidateMyString(string s)
                {
                    if (s.All(char.IsDigit))
                    {
                        throw new FormatException();
                    }
                }

                Console.WriteLine("Enter product's price:");
                decimal price = decimal.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter products's department:");
                Department department = (Department)Enum.Parse(typeof(Department), Console.ReadLine()!);

                Console.WriteLine("Enter products's quantity :");
                int quantity = int.Parse(Console.ReadLine()!);

                int id = marketService.AddProduct(name, price, department, quantity);

                Console.WriteLine($"Doctor with ID:{id} was created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void AddSales()
        {

            try
            {
                Console.WriteLine("Enter products's ID:");
                int productId = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter SaleItem's ID:");
                int saleItemId = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter Sale's date (dd/MM/yyyy - HH:mm):");
                var date = DateTime.ParseExact(Console.ReadLine()!, "(dd/MM/yyyy - HH:mm)", null);

                Console.WriteLine("Enter amount of sale:");
                int amount = int.Parse(Console.ReadLine()!);

                var id = marketService.AddSales(amount,date,saleItemId,productId);

                Console.WriteLine($"Sale with ID:{id} was created!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }


        }

    }
}

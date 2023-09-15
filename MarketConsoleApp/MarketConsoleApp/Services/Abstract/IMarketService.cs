using MarketConsoleApp.Data.Enums;
using MarketConsoleApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketConsoleApp.Services.Abstract
{
    public interface IMarketService
    {
        public List<Product> GetProducts();
        public int AddProduct(string name,decimal price,Department department,int quantity);
        public int UpdateProduct(int id, string name, decimal price, Department department, int quantity);
        public List<Product> GetProductsByCategory(int id, string name, decimal price, Department department, int quantity);
        public List<Product> GetProductsByPricerange(int id, string name, decimal price, Department department, int quantity);
        public List<Product> GetProductsByGivenName(int id, string name, decimal price, Department department, int quantity);
        public int DeleteProduct(int id);


        

    }
}

using Buoi10.Models;
using Buoi10.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buoi10.Services.Implements
{
    public class BasicProductServices : IProductServices
    {
        public static List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int ID)
        {
            //linq
            var product = products.SingleOrDefault(p => p.ProductId == ID);
            if (product != null)
            {
                products.Remove(product);
            }    
        }

        public Product FindByID(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
        }
    }
}

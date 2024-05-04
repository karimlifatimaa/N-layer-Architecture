using ProductApp.DAL;
using ProductApp.Models;
using ProductApp.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Repositories.Concrates
{
    public class Productrepository : IProductRepository
    {
        public void AddProduct(Product product)
        {
            AppDb.Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            AppDb.Products.Remove(product);
        }

        public List<Product> GetAllProducts(Predicate<Product>? predicate)
        {
            return predicate == null ?
                   AppDb.Products.FindAll(x => true) :
                   AppDb.Products.FindAll(predicate);
        }

        public Product GetProduct(Predicate<Product>? predicate)
        {
            return predicate == null ?
                   AppDb.Products.Find(x => true) :
                   AppDb.Products.Find(predicate);
        }
    }
}

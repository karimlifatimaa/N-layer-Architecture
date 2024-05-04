using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services.Abstracts
{
    public interface IProductServices
    {
        void AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(int id, Product product);
        Product GetProduct(Predicate<Product>? predicate);
        List<Product> GetAllProducts(Predicate<Product>? predicate);
    }
}

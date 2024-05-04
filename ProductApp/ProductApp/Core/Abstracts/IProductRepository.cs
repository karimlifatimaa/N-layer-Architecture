using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Repositories.Abstracts
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void DeleteProduct(Product product);     
        Product GetProduct(Predicate<Product>? predicate);
        List<Product> GetAllProducts(Predicate<Product>? predicate);

    }
}

using ProductApp.DAL;
using ProductApp.Models;
using ProductApp.Repositories.Abstracts;
using ProductApp.Repositories.Concrates;
using ProductApp.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services.Concrates
{
    public class ProductServices : IProductServices
    {
        IProductRepository _repository = new Productrepository();
        public void AddProduct(Product product)
        {
            _repository.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            Product product = AppDb.Products.Find(x => x.Id == id);
            if (product == null) throw new NullReferenceException("Product not found!!!");
            _repository.DeleteProduct(product);
        }

        public List<Product> GetAllProducts(Predicate<Product>? predicate)
        {
            //return predicate == null ?
            //       _repository.GetAllProducts(null):
            //       _repository.GetAllProducts(predicate);
            return _repository.GetAllProducts(predicate);
        }

        public Product GetProduct(Predicate<Product>? predicate)
        {
           return _repository.GetProduct(predicate);
        }

        public void UpdateProduct(int id, Product product)
        {
            Product existproduct = _repository.GetProduct(x => x.Id == id);
            if (existproduct == null) throw new NullReferenceException("Product not found!!!");
            existproduct.Name= product.Name;
            existproduct.Description= product.Description;
            existproduct.Price= product.Price;
            existproduct.DiscoutPercet= product.DiscoutPercet;
   
        }
    }
}

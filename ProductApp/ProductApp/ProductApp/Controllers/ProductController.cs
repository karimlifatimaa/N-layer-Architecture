using ProductApp.Models;
using ProductApp.Services.Abstracts;
using ProductApp.Services.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Controllers
{
    public class ProductController
    {
        IProductServices _services=new ProductServices();
        public void AddProduct()
        {
            Console.WriteLine("Productun adini daxil edin");
            string name=Console.ReadLine();
            Console.WriteLine("Productun descriptionunu daxil edin");
            string description = Console.ReadLine();
            string priceStr="";
            double price;
            do
            {
                Console.WriteLine("Price daxil edin");
                priceStr = Console.ReadLine();

            } while (!double.TryParse(priceStr,out price));
            string percetStr = "";
            int percet;
            do
            {
                Console.WriteLine("Endirim faizini daxil edin");
                percetStr = Console.ReadLine();

            } while (!int.TryParse(percetStr, out percet));
            Product product = new Product(name,description,price, percet);
            _services.AddProduct(product);
        }
        public void RemoveProduct()
        {
            string idStr = "";
            int id;
            do
            {
                Console.WriteLine("sileceyiniz id daxil edin");
                idStr = Console.ReadLine();

            } while (!int.TryParse(idStr, out id));
            _services.DeleteProduct(id);
        }
        public void UpdateProduct()
        {
            string idStr = "";
            int id;
            do
            {
                Console.WriteLine("id daxil edin");
                idStr = Console.ReadLine();

            } while (!int.TryParse(idStr, out id));

            Console.WriteLine("Productun adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Productun descriptionunu daxil edin");
            string description = Console.ReadLine();
            string priceStr = "";
            double price;
            do
            {
                Console.WriteLine("Price daxil edin");
                priceStr = Console.ReadLine();

            } while (!double.TryParse(priceStr, out price));
            string percetStr = "";
            int percet;
            do
            {
                Console.WriteLine("Endirim faizini daxil edin");
                percetStr = Console.ReadLine();

            } while (!int.TryParse(percetStr, out percet));
            Product product = new Product(name, description, price, percet);
            _services.UpdateProduct(id, product);
        }
        public void GetAllProduct() 
        { 
            _services.GetAllProducts(null).ForEach(x=>Console.WriteLine(x));
        }
        public void GetProduct()
        {
            Console.WriteLine(_services.GetProduct(null));
        }
    }
}

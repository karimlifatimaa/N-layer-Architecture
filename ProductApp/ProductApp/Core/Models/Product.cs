using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public class Product
    {
        public static int _id;
        public int Id;
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int DiscoutPercet { get; set; }
        public Product(string name,string description,double price,int discountpercet)
        {
            _id++;
            Id = _id;
            Name = name;
            Description = description;
            Price = price;
            DiscoutPercet = discountpercet;
        }
        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Description:{Description}, Price:{Price},DiscountPercet:{DiscoutPercet}";
        }
    }
}

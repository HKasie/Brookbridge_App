using System;
using System.Collections.Generic;
using System.Text;

namespace Brookbridge.Data.Domain
{
    public class Product
    {
        public Product(string name, string description, string code, decimal price, int qty, bool veg)
        {
            Name = name;
            Description = description;
            Code = code;
            Price = price;
            Qty = qty;
            Veg = veg;            
        }

        public Product(int id, string name, string description, string code, decimal price, int qty, bool veg, DateTime dateAdded)
        {
            Id = id;
            Name = name;
            Description = description;
            Code = code;
            Price = price;
            Qty = qty;
            Veg = veg;
            DateAdded = dateAdded;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public bool Veg { get; set; }
        public DateTime DateAdded { get; set; }
    }

}

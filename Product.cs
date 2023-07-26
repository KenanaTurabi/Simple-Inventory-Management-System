﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    public class Product
    {
        public string Name { get;  set; }
        public int Quantity { get;  set; }

        public double Price { get;  set; }

        public Product() { }
        public  Product(string name, int quantity,double price) { 
            Name = name;
            Quantity = quantity;
            Price = price;
        }
        public string writeProduct()
        {
            return $"product name: {Name} & quantity: {Quantity} $ price: {Price}";
        }


       
    }
}

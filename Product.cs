using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    public class Product
    {/*
        private string name;
        private int quantity;
        private double price;
        */
        public string name;
        public int quantity;
        public double price;


        public Product() { }
        public  Product(string name, int quantity,double price) { 
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            //Console.WriteLine("inside constructer");

        }
        public void writeProduct()
        {
            Console.WriteLine($"product name: {name} & quantity: {quantity} $ price: {price}");
        }


       
    }
}

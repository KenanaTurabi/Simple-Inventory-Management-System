﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    public class Inventory
    {
          public static ArrayList prodList=new ArrayList();

        public static void menu()
        {
            Console.Write("\n Menue \n ------\n1-add product\n2-view all products\n3-edit a product \n4-delete a product\n5-search for a product\n6-exit\nPLZ ENTER YOUR CHOICE: "); 
        }
        
        public void addProduct()
        {
            Console.Write("enter product neme:");
           string name=Console.ReadLine();
            Console.Write("enter product quantity:");
            int quantity = Int32.Parse(Console.ReadLine());
            Console.Write("enter product price:");
            double price = Int32.Parse(Console.ReadLine());

            Product prdc = new Product(name, quantity, price);
            prodList.Add(prdc);
            Console.WriteLine("you product has been added successfully to the list");
        }
        public static void Main() {
            bool flag = false;
            while (true)
            {
                int choice;
                menu();
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Inventory inventory = new Inventory();
                    inventory.addProduct();
                    
                }
                else if (choice == 2)
                {
                    foreach (Product item in prodList)
                    {
                        Console.WriteLine("this is your item");
                        item.writeProduct();
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("enter product name: ");
                    string productName=Console.ReadLine();
                    foreach (Product item in prodList)
                    {

                        if (productName == item.name) flag = true;
                        if (flag==true){
                            
                            Console.WriteLine("this product exist update its value");
                            Console.Write("new name:  ");
                            item.name = Console.ReadLine();
                            Console.Write("new quantity:  ");
                            item.quantity = Int32.Parse(Console.ReadLine());
                            Console.Write("new price:  ");
                            item.price=double.Parse(Console.ReadLine());


                        }

                    }
                    if (flag == false) { Console.WriteLine("this product does not exist"); }
                }

                else break;
            }
            
           


            //Console.WriteLine(prodList);
        }

        
    }
}

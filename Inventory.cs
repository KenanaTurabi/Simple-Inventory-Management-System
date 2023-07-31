using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    public class Inventory
    {
        public List<Product> ProductList = new List<Product>();
        public static void ViewMenu()
        {
            Console.Write("\n Menue \n ------\n1-add product\n2-view all products\n3-edit a product \n4-delete a product\n5-search for a product\n6-exit\nPLZ ENTER YOUR CHOICE: "); 
        }       
        public Product VaildateProductByName(string productName)
        {
            foreach (Product item in ProductList)
            {
                if (productName == item.Name)
                {
                    return item;
                }
            }
            return null;
        }//validate()
        public void PickFromMenu()
        {
            while (true)
            {
                int choice;
                ViewMenu();
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("enter product neme:");
                    string name = Console.ReadLine();
                    Console.Write("enter product quantity:");
                    int quantity = Int32.Parse(Console.ReadLine());
                    Console.Write("enter product price:");
                    double price = Int32.Parse(Console.ReadLine());
                    Product product = new Product(name, quantity, price);
                    ProductList.Add(product);
                    Console.WriteLine("you product has been added successfully to the list");
                }
                else if (choice == 2)
                {
                    if (ProductList.Count== 0) Console.WriteLine("No products");
                    else Console.WriteLine("these are your items: ");                  
                    for (int i= 0; i < ProductList.Count; i++)
                    {
                        Console.WriteLine(ProductList[i].writeProduct());
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("enter product name: ");
                    string productName = Console.ReadLine();
                    Product product = VaildateProductByName(productName);

                        if (product!=null)
                        {
                            Console.WriteLine("this product exist update its value");
                            Console.Write("new name:  ");
                            product.Name = Console.ReadLine();
                            Console.Write("new quantity:  ");
                            product.Quantity = Int32.Parse(Console.ReadLine());
                            Console.Write("new price:  ");
                            product.Price = double.Parse(Console.ReadLine());
                        }                  
                    else{ Console.WriteLine("this product does not exist"); }
                }
                else if (choice == 4)
                {
                    Console.Write("enter product name: ");
                    string productName = Console.ReadLine();
                    Product product = VaildateProductByName(productName);
                    if (product != null)
                        {
                            ProductList.Remove(product);
                            Console.WriteLine("the product has been deleted successfully");
                        }                   
                    else
                    {
                        Console.WriteLine("the product does not exist");
                    }
                }//choice==4(delete)
                else if (choice == 5)
                {
                    Console.Write("enter product name: ");
                    string productName = Console.ReadLine();
                    Product product = VaildateProductByName(productName);
                    if (product != null)
                        {                           
                            Console.WriteLine(product.writeProduct());
                        }
                    else 
                    {
                        Console.WriteLine("the product does not exist");
                    }
                }//choice=5(search)
                else
                {
                    Console.WriteLine("EXIT");
                    break;
                }
            }//while
        }
        public static void Main() {
            Inventory inventory = new Inventory();
            inventory.PickFromMenu();
        }//Main        
    }//class 
}//namespace

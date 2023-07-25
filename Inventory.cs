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
        public List<Product> prodList = new List<Product>();
          //public static ArrayList prodList=new ArrayList();

        public static void menu()
        {
            Console.Write("\n Menue \n ------\n1-add product\n2-view all products\n3-edit a product \n4-delete a product\n5-search for a product\n6-exit\nPLZ ENTER YOUR CHOICE: "); 
        }
        
       
        public void Menue()
        {
            
            while (true)
            {
                bool flag = false;
                bool flag2 = false;
                bool flag3 = false;
                int choice;
                menu();
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("enter product neme:");
                    string name = Console.ReadLine();
                    Console.Write("enter product quantity:");
                    int quantity = Int32.Parse(Console.ReadLine());
                    Console.Write("enter product price:");
                    double price = Int32.Parse(Console.ReadLine());
                    Product prdc = new Product(name, quantity, price);
                    prodList.Add(prdc);
                    Console.WriteLine("you product has been added successfully to the list");

                }
                else if (choice == 2)
                {
                    Console.WriteLine(prodList.Count);
                    if (prodList.Count== 0) Console.WriteLine("No products");
                    else Console.WriteLine("this is your items: ");                  
                    Console.WriteLine("count = "+prodList.Count);
                    for (int i= 0; i < prodList.Count; i++)
                    {
                        Console.WriteLine(prodList[i].writeProduct());

                    }
                }
                else if (choice == 3)
                {
                    Console.Write("enter product name: ");
                    string productName = Console.ReadLine();
                    foreach (Product item in prodList)
                    {

                        if (productName == item.Name)
                        {
                            flag = true;
                            Console.WriteLine("this product exist update its value");
                            Console.Write("new name:  ");
                            item.Name = Console.ReadLine();
                            Console.Write("new quantity:  ");
                            item.Quantity = Int32.Parse(Console.ReadLine());
                            Console.Write("new price:  ");
                            item.Price = double.Parse(Console.ReadLine());
                        }

                    }
                    if (flag == false) { Console.WriteLine("this product does not exist"); }
                }
                else if (choice == 4)
                {
                    Console.Write("enter product name  to delete: ");

                    string productName = Console.ReadLine();
                    foreach (Product item in prodList)
                    {
                        if (item.Name == productName)
                        {
                            flag2 = true;
                            prodList.Remove(item);
                            Console.WriteLine("the product has been deleted successfully");
                            break;

                        }

                    }
                    if (flag2 == false)
                    {
                        Console.WriteLine("the product does not exist");
                    }
                }//choice==4(delete)
                else if (choice == 5)
                {

                    Console.Write("enter product name for searchig: ");
                    string productName = Console.ReadLine();

                    foreach (Product item in prodList)
                    {
                        if (item.Name == productName)
                        {
                            flag3 = true;
                            Console.WriteLine(item.writeProduct());
                            break;

                        }


                    }
                    if (flag3 == false)
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
            inventory.Menue();

        }//Main

        
    }//class 
}//namespace

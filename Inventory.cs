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
                    Inventory inventory = new Inventory();
                    inventory.addProduct();

                }
                else if (choice == 2)
                {
                    if (prodList.Count == 0) Console.WriteLine("No products");
                    else Console.WriteLine("this is your items: ");
                    foreach (Product item in prodList)
                    {

                        item.writeProduct();
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("enter product name: ");
                    string productName = Console.ReadLine();
                    foreach (Product item in prodList)
                    {

                        if (productName == item.name)
                        {
                            flag = true;
                            Console.WriteLine("this product exist update its value");
                            Console.Write("new name:  ");
                            item.name = Console.ReadLine();
                            Console.Write("new quantity:  ");
                            item.quantity = Int32.Parse(Console.ReadLine());
                            Console.Write("new price:  ");
                            item.price = double.Parse(Console.ReadLine());
                            flag = false;


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
                        if (item.name == productName)
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
                        if (item.name == productName)
                        {
                            flag3 = true;
                            item.writeProduct();
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
            
           


        }//Main

        
    }//class 
}//namespace

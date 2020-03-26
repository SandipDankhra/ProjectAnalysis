using System;
using System.Data.Entity;
using ToyZoneApp.Context;
using ToyZoneApp.Domain;
using ToyZoneApp.Models;

namespace ToyZoneApp
{
    class Program 
    {
        public static int i;
         
        static void Main(string[] args)
        {
            Console.WriteLine("========== WelCome TO ToyZone ==========");
            int choice;
            

            CategoryDomain categoryDomain = new CategoryDomain();
            ProductDomain productDomain = new ProductDomain();
            Categorys categorys = new Categorys();
            Products products = new Products();
            do
            {
                Console.WriteLine("\n======= Menu =======");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Remove Product");
                Console.WriteLine("3.View Product");
                Console.WriteLine("4.Add Category");
                Console.WriteLine("5.Remove Category");
                Console.WriteLine("6.View Category");
              
                Console.WriteLine("0.Exit");

                Console.Write("\nEnter Your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n====== Add Product =====");

                        Console.Write("Enter Product Name: ");
                        products.ProductName = Convert.ToString(Console.ReadLine());

                        Console.Write("Enter CategoryID: ");
                        products.CategoryId = Convert.ToInt32(Console.ReadLine());

                        productDomain.AddProduct(products);

                        Console.WriteLine("\n====== Product Added Successfully=====");

                        break;
                    case 2:
                        Console.WriteLine("\n====== Remove Product =====");

                        Console.Write("Enter Product ID: ");
                        products.ProductId= Convert.ToInt32(Console.ReadLine());

                        productDomain.RemoveProduct(products);

                        Console.WriteLine("\n====== Product Remove Successfully=====");

                        break;

                    case 3:
                        Console.WriteLine("\n====== View All Products =======");
                        Console.WriteLine("ProductId\tProductName\tCategoryId");
                        foreach (Products product in productDomain.GetProduct())
                        {

                            Console.WriteLine($"{product.ProductId}\t{product.ProductName}\t{product.CategoryId} ");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n====== Add Category =====");

                        Console.Write("Enter Category Name: ");
                        string CategoryName = Convert.ToString(Console.ReadLine());

                        Console.Write("Enter Description: ");
                        string Description = Convert.ToString(Console.ReadLine());

                        categorys.CategoryName = CategoryName;
                        categorys.Description = Description;

                        categoryDomain.AddCategory(categorys);

                        Console.WriteLine("\n====== Category added Successfully=====");

                        break;
                    case 5:
                        Console.WriteLine("\n====== Remove Category =====");

                        Console.Write("Enter Category ID: ");
                        categorys.CategoryId = Convert.ToInt32(Console.ReadLine());

                        categoryDomain.RemoveCategory(categorys);

                        Console.WriteLine("\n====== Category Remove Successfully=====");

                        break;

                    case 6:
                        Console.WriteLine("\n====== List Of Category =====");
                        categoryDomain.ViewCategory();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine(" Invalid Choice !!!");
                        break;
                }
            } while (i > -1);
        }
    }
}

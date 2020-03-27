using BusinessInfoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInfoApp
{
    class Program
    {
        public static int i;
        static void Main(string[] args)
        {
            Console.WriteLine("========== WelCome TO Business Information ==========");
            int choice;
            EmployeeDomain employeeDomain = new EmployeeDomain();
            ProjectDomain projectDomain = new ProjectDomain();

            do
            {
                Console.WriteLine("\n======= Menu =======");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.View Employees");
                Console.WriteLine("3.Add Project");
                Console.WriteLine("4.View Projects");
                
                Console.WriteLine("0.Exit");

                Console.Write("\nEnter Your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n====== Add Employee =====");
                        employeeDomain.addEmolpyee();
                        break;
                    case 2:
                        Console.WriteLine("\n====== View Employees =====");
                        employeeDomain.ViewEmployee();
                        break;
                    case 3:
                        Console.WriteLine("\n====== Add Project Details =====");
                        projectDomain.addProject();
                        break;
                    case 4:
                        Console.WriteLine("\n====== View All Project Details =====");
                        projectDomain.viewAllProject();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (i >-1);
        }
    }
}

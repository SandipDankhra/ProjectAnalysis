using BusinessInfoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInfoApp.Domain
{
    public class EmployeeDomain
    {
        BaseContext BaseContexts = new BaseContext();
        Employee employee = new Employee();


        public void addEmolpyee()
        {
            try
            {
                Console.Write("Enter Employee Name : ");
                employee.Name = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Employee Email : ");
                employee.Email = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Employee Password : ");
                employee.Password = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Employee Type (Employee OR Manager OR Admin) : ");
                employee.EmployeeType = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Employee Status (Vaction OR Available) : ");
                employee.Status = Convert.ToString(Console.ReadLine());

                var checkEmail = BaseContexts.Employees.SingleOrDefault(t => t.Email == employee.Email);

                if (checkEmail == null)
                {
                    BaseContexts.Employees.Add(employee);
                    BaseContexts.SaveChanges();
                    Console.WriteLine("\nEmployee Added Successfully");
                }
                else
                {
                    Console.WriteLine("\nEmplyee already exists...");
                    Console.WriteLine("\nEmployee not Inserted...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }


        }
        public void ViewEmployee()
        {
            /* using (BaseContexts) {*/
            try
            {
                var EmplyeeList = BaseContexts.Employees;
                Console.WriteLine("ID\tName\tEmail\t\tPassword\tEmployeeType\tStatus");
                foreach (var emp in EmplyeeList)
                {
                    Console.WriteLine(emp.EmployeeId + "\t" + emp.Name + "\t" + emp.Email + "\t" + emp.Password + "\t" + emp.EmployeeType + "\t" + emp.Status);
                }

                //  BaseContexts.Employees.ToList();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*}*/
        }
    }
}

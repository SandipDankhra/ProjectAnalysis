using HospitalStoreApp.Domain;
using HospitalStoreApp.Models;
using System;

namespace HospitalStoreApp
{
    class Program
    {
        public static int i;
        static void Main(string[] args)
        {
            Console.WriteLine("========== WelCome TO HospitalStore ==========");
            int choice;
            DepartmentDomain departmentDomain = new DepartmentDomain();
            Departments departments = new Departments();

            DoctorDomain doctorDomain = new DoctorDomain();
            Doctors doctors = new Doctors();
            do
            {
                Console.WriteLine("\n======= Menu =======");
                Console.WriteLine("1.Add Departments");
                Console.WriteLine("2.Remove Department");
                Console.WriteLine("3.View Departments");
                Console.WriteLine("4.Add Doctors");
                Console.WriteLine("5.Remove Doctor");
                Console.WriteLine("6.View Doctors");
                Console.WriteLine("7.Add Patient");
                Console.WriteLine("8.Remove Patient");
                Console.WriteLine("9.View Patients");
                Console.WriteLine("10.Add Patient Drugs Detail");
                Console.WriteLine("11.Remove Patient Drugs Detail");
                Console.WriteLine("12.View Patient Drugs Details");
                Console.WriteLine("0.Exit");

                Console.Write("\nEnter Your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        
                        Console.WriteLine("\n====== Add Departments =====");

                        Console.Write("Enter Department Name: ");
                        departments.DepartmentName = Console.ReadLine().Trim();

                        departmentDomain.AddDepartment(departments);
                        Console.WriteLine("\nDepartment insert successfully ");

                        break;
                    case 2:
                        Console.WriteLine("\n====== Remove Departments =====");
                        Console.Write("Enter Department ID : ");
                        departments.DepartmentId = Convert.ToInt32( Console.ReadLine());
                      
                        departmentDomain.RemoveDepartment(departments);
                        Console.WriteLine("\nDepartment id "+departments.DepartmentId+" was deleted successfully ");
                        break;

                    case 3:
                        Console.WriteLine("\n====== View All Departments =====");
                        
                        Console.WriteLine("DepartmentId \t DepartmentName");
                        foreach (Departments department in departmentDomain.GetAllDepartment() )
                        {
                           
                            Console.WriteLine($"{department.DepartmentId}\t{department.DepartmentName} ");
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("\n====== Add Doctor =====");

                        Console.Write("Enter Doctor Name: ");
                        doctors.DoctorName = Console.ReadLine().Trim();
                        
                        Console.Write("Enter Doctor Speciality: ");
                        doctors.Speciality = Console.ReadLine().Trim();

                        Console.Write("=== Select Department === ");

                        Console.WriteLine("\n====== View All Departments =====");

                        Console.WriteLine("DepartmentId \t DepartmentName");
                        foreach (Departments department in departmentDomain.GetAllDepartment())
                        {

                            Console.WriteLine($"{department.DepartmentId}\t{department.DepartmentName} ");
                        }

                        Console.Write("Enter DepartmentId: ");
                        doctors.DepartmentId = Convert.ToInt32(Console.ReadLine());

                        doctorDomain.AddDoctor(doctors);
                        Console.WriteLine("\nDoctor insert successfully ");

                        break;
                    case 5:
                        Console.WriteLine("\n====== Remove Doctor =====");
                        Console.Write("Enter Doctor ID : ");
                        doctors.DoctorId = Convert.ToInt32(Console.ReadLine());

                        doctorDomain.RemoveDoctor(doctors);
                        Console.WriteLine("\nDoctor id " + doctors.DoctorId+ " was deleted successfully ");
                        break;
                    case 6:
                        Console.WriteLine("\n====== View All Doctors =====");

                        Console.WriteLine("DoctorId \t DoctorName \t Speciality \t DepartmentId");
                        foreach (Doctors doctor in doctorDomain.GetAllDoctors())
                        {

                            Console.WriteLine($"{doctor.DoctorId}\t{doctor.DoctorName}\t{doctor.Speciality}\t{doctor.DepartmentId} ");
                        }

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

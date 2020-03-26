using HospitalStoreApp.Context;
using HospitalStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalStoreApp.Domain
{
   public  class DepartmentDomain:BaseContext
    {
        public void AddDepartment(Departments departments)
        {
            try
            {
                Departments.Add(departments);
                SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RemoveProduct(Departments departments)
        {
            Departments.Remove(departments);
            SaveChanges();
        }

       public List<Departments> GetAllDepartment()
        {
            return Departments.ToList();
        }
    }
}

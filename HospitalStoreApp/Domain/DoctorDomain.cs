using HospitalStoreApp.Context;
using HospitalStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalStoreApp.Domain
{
    public class DoctorDomain : BaseContext
    {
        public void AddDoctor(Doctors doctors)
        {
            try
            {
                Doctors.Add(doctors);
                SaveChanges();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void RemoveDoctor(Doctors doctors)
        {
            try
            {
                Doctors.Remove(doctors);
                SaveChanges();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Doctors> GetAllDoctors()
        {
            return Doctors.ToList();
        }
    }
}

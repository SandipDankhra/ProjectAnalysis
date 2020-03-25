using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalStoreApp.Models
{
    public class Doctors
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int DoctorId { get; set; }

        public string DoctorName { get; set; }

        public string Speciality { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public int DepartmentId { get; set; }

        

    }
}

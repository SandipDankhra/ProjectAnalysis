using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalStoreApp.Models
{
    public class Patients
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int PatientId { get; set; }

        public string PatientName { get; set; }

        public string PatientType { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public int DoctorId { get; set; }

        
    }
}

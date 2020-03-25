using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalStoreApp.Models
{
    public class Departments
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
    }
}

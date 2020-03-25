using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalStoreApp.Models
{
    public class PatientDrugsDeatils
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int PatientDrugsDeatilId { get; set; }

        public string Morning { get; set; }
        public string AfterNoon { get; set; }
        public string Night { get; set; }

        [ForeignKey(nameof(PatientId))]
        public int PatientId { get; set; }

    }
}

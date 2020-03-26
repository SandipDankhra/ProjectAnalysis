using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyZoneApp.Models
{
    public class Categorys
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }
        
    }
}

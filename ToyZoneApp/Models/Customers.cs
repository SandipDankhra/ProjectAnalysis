using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyZoneApp.Models
{
    public class Customers
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int CustomerId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }
        
        public string Password{ get; set; }
        
        public string Address { get; set; }

       
        
    }
}

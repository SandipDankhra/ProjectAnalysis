using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyZoneApp.Models
{
    public class Products
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
    }
}

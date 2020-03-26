using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyZoneApp.Models
{
    public class ProductsDetails
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ProductDetailId { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public int Price { get; set; }

        public bool Available { get; set; }

        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }

    }
}

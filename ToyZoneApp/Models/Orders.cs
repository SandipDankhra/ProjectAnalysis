using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyZoneApp.Models
{
    public class Orders
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }


        [ForeignKey(nameof(CustomerId))]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }
    



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyZoneApp.Models
{
    public class OrdersDetails
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int OrderDetailId { get; set; }

        public DateTime ShippingDate    { get; set; }

        public string ShippingAddress { get; set; }

        public int OrderStatus { get; set; }

        public int Quantity { get; set; }

        public DateTime RequiredDate { get; set; }

        [ForeignKey(nameof(OrderId))]
        public int OrderId { get; set; }

        

    }
}

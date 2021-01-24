using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GlobalExpertise.models
{
    public class Product
    {
        public int productId { get; set; }
        [Required]
        [StringLength(50)]
        public string code { get; set; }

        public int quantity { get; set; }

        public double price { get; set; }

        public int CategoryId  { get; set; }


        public virtual Category Category { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GlobalExpertise.Utils;
namespace GlobalExpertise.models
{
    public class Product : EntityValidator
    {
        public Product()
        {
            this.Code = GlobalExpertise.Utils.Utils.RandomString(10);
        }

        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        
        public int CategoryId  { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }



    }
}

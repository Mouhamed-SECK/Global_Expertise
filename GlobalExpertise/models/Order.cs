using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GlobalExpertise.models
{
    public enum ORDER_STATUS  
    {
        NEW, WAITING, IN_PROGRESS 
    }
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderNumber { get; set; }
        public ORDER_STATUS Status { get; set; }
        public DateTime orderedDate { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer customer { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }

    }
}

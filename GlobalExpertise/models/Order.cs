using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalExpertise.models
{
    public enum ORDER_STATUS  
    {
        NEW, WAITING, IN_PROGRESS 
    }
    class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public ORDER_STATUS Status { get; set; }
        public DateTime orderedDate { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer customer { get; set; }
    }
}

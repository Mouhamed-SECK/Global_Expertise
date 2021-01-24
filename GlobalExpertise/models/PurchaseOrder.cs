using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalExpertise.models
{
    public class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }



        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }

    }
}

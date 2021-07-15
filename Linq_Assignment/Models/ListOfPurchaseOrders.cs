using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Linq_Assignment.Models
{
    public class ListOfPurchase
    {
        public Customer customer { get; set; }
        public PurchaseOrder purchaseOrder { get; set; }
        public PurchaseOrderDetail purchaseOrderDetail { get; set; }
        public Product product { get; set; }
    }
}
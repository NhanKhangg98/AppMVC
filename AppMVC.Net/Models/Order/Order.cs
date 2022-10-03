
using System;
using System.Collections.Generic;

namespace AppMVC.Net.Models.Orders
{
    public class Order
    {
        public int OrderID { set; get; }
        public DateTime OrderDate { set; get; }
        
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public bool Status { set; get; }

        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser AppUser { set; get; }
    }
}

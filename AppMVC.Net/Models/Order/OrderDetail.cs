using AppMVC.Net.Models.Product;

namespace AppMVC.Net.Models.Orders
{
    public class OrderDetail
    {
        public int OrderID { set; get; }
        public int ProductID { set; get; }
        public int Quantity { set; get; }
        public decimal Amount { set; get; }

        public Order Order { get; set; }


        public ProductModel Product { get; set; }
    }
}
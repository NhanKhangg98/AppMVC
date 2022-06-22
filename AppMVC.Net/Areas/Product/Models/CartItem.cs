using AppMVC.Net.Models.Product;

namespace AppMVC.Net.Areas.Product.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public ProductModel product { set; get; }
    }
}

using AppMVC.Net.Models.Blog;
using AppMVC.Net.Models.Product;
using System.ComponentModel.DataAnnotations;

namespace AppMVC.Net.Areas.Product.Models
{
    public class CreateProductModel: ProductModel
    {
        [Display(Name = "Chuyên mục")]
        public int[] CategoryIDs { get; set; }
    }
}

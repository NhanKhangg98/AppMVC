using AppMVC.Net.Models.Blog;
using System.ComponentModel.DataAnnotations;

namespace AppMVC.Net.Areas.Blog.Models
{
    public class CreateProductModel: Post
    {
        [Display(Name = "Chuyên mục")]
        public int[] CategoryIDs { get; set; }
    }
}

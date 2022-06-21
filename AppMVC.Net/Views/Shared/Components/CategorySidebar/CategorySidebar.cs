using AppMVC.Net.Models.Blog;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppMVC.Net.Components
{
    [ViewComponent]
    public class CategorySidebar : ViewComponent
    {
        public class CategorySidebarData
        {
            public List<Category> Categories { get; set; }

            public int level { get; set; }

            public string categoryslug { get; set; }
        }

        public IViewComponentResult Invoke(CategorySidebarData data)
        {
            return View(data);
        }

    }
}

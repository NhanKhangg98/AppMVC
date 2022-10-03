using AppMVC.Net.Data;
using AppMVC.Net.Models;
using AppMVC.Net.Models.Blog;
using AppMVC.Net.Models.Product;
using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Net.Areas.Database.Controllers
{
    [Area("Database")]
    [Route("/database-manage/[action]")]
    public class DbManageController : Controller
    {
        private readonly AppDbContext _dbContext;
        
        private readonly UserManager<AppUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public DbManageController(AppDbContext dbContext, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteDb()
        {
            return View();
        }


        [TempData]
        public string Notify { get; set; }

        [HttpPost]
        public async Task<IActionResult> DeleteDbAsync()
        {
            var success = await  _dbContext.Database.EnsureDeletedAsync();

            Notify = success ? "Xoá Database thành công" : "Khum xóa được";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Migrate()
        {
            await _dbContext.Database.MigrateAsync();

            Notify = "Cập nhật Db thành công";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> SeedDataAsync()
        {
            var rolenames = typeof(RoleName).GetFields().ToList();
            foreach (var r in rolenames)
            {
                var rolename = (string)r.GetRawConstantValue();
                var rfound = await _roleManager.FindByNameAsync(rolename);
                if(rfound == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole(rolename));
                }
            }

            // admin, password=admin123, admin@example.com
            var userAdmin = await _userManager.FindByEmailAsync("admin@example.com");
            if(userAdmin == null)
            {
                userAdmin = new AppUser()
                {
                    UserName = "admin",
                    Email = "admin@example.com",
                    EmailConfirmed = true,
                };
                await _userManager.CreateAsync(userAdmin, "admin123");
                await _userManager.AddToRoleAsync(userAdmin, RoleName.Administrator);
            }

            SeedPostCategory();
            SeedProDuctCategory();

            Notify = "Vừa seed Database";
            return RedirectToAction("Index");

        }

        private void SeedPostCategory()
        {
            _dbContext.Categories.RemoveRange(_dbContext.Categories.Where(c => c.Description.Contains("[fakeData]")));
            _dbContext.Posts.RemoveRange(_dbContext.Posts.Where(p => p.Content.Contains("[fakeData]")));

            _dbContext.SaveChanges();

            var fakerCategory = new Faker<Category>();
            int cm = 1;
            fakerCategory.RuleFor(c => c.Title, fk => $"CM{cm++} " + fk.Lorem.Sentence(1, 2).Trim('.'));
            fakerCategory.RuleFor(c => c.Description, fk => fk.Lorem.Sentence(5) + "[fakeData]");
            fakerCategory.RuleFor(c => c.Slug, fk => fk.Lorem.Slug());


            var cate1 = fakerCategory.Generate();
                var cate11 = fakerCategory.Generate();
                var cate12 = fakerCategory.Generate();
            var cate2 = fakerCategory.Generate();
                var cate21 = fakerCategory.Generate();
                    var cate211 = fakerCategory.Generate();


            cate11.ParentCategory = cate1;
            cate12.ParentCategory = cate1;
            cate21.ParentCategory = cate2;
            cate211.ParentCategory = cate21;

            var categories = new Category[] {cate1, cate2, cate11, cate12, cate21, cate211};
            _dbContext.Categories.AddRange(categories);


            // Phát sinh POST
            var rCateIndex = new Random();
            int bv = 1;

            var user = _userManager.GetUserAsync(this.User).Result;
            
            var fakePost = new Faker<Post>();
            fakePost.RuleFor(p => p.AuthorId, f => user.Id);
            fakePost.RuleFor(p => p.Content, f => f.Lorem.Paragraph(7) + "[fakeData]");
            fakePost.RuleFor(p => p.DateCreated, f => f.Date.Between(new DateTime(2022, 1, 1), new DateTime(2022, 5, 1)));
            fakePost.RuleFor(p => p.Description, f => f.Lorem.Sentence(3));
            fakePost.RuleFor(p => p.Published, f => true);
            fakePost.RuleFor(p => p.Slug, f => f.Lorem.Slug());
            fakePost.RuleFor(p => p.Title, f => $"Bài {bv++} " + f.Lorem.Sentence(3, 4).Trim('.'));

            List<Post> posts = new List<Post>();
            List<PostCategory> post_categories = new List<PostCategory>();

            for (int i = 0; i < 40; i++)
            {
                var post = fakePost.Generate();
                post.DateUpdated = post.DateCreated;

                posts.Add(post);
                post_categories.Add(new PostCategory()
                {
                    Post = post,
                    Category = categories[rCateIndex.Next(5)]
                });
            }

            _dbContext.AddRange(posts);
            _dbContext.AddRange(post_categories);

            // END POST



            _dbContext.SaveChanges();
        }


        private void SeedProDuctCategory()
        {
            _dbContext.CategoryProducts.RemoveRange(_dbContext.CategoryProducts.Where(c => c.Description.Contains("[fakeData]")));
            _dbContext.Products.RemoveRange(_dbContext.Products.Where(p => p.Content.Contains("[fakeData]")));

            _dbContext.SaveChanges();

            var fakerCategory = new Faker<CategoryProduct>();
            int cm = 1;
            fakerCategory.RuleFor(c => c.Title, fk => $"Nhóm SP{cm++} " + fk.Lorem.Sentence(1, 2).Trim('.'));
            fakerCategory.RuleFor(c => c.Description, fk => fk.Lorem.Sentence(5) + "[fakeData]");
            fakerCategory.RuleFor(c => c.Slug, fk => fk.Lorem.Slug());


            var cate1 = fakerCategory.Generate();
            var cate11 = fakerCategory.Generate();
            var cate12 = fakerCategory.Generate();
            var cate2 = fakerCategory.Generate();
            var cate21 = fakerCategory.Generate();
            var cate211 = fakerCategory.Generate();


            cate11.ParentCategory = cate1;
            cate12.ParentCategory = cate1;
            cate21.ParentCategory = cate2;
            cate211.ParentCategory = cate21;

            var categories = new CategoryProduct[] { cate1, cate2, cate11, cate12, cate21, cate211 };
            _dbContext.CategoryProducts.AddRange(categories);


            // Phát sinh POST
            var rCateIndex = new Random();
            int bv = 1;

            var user = _userManager.GetUserAsync(this.User).Result;

            var fakeProduct = new Faker<ProductModel>();
            fakeProduct.RuleFor(p => p.AuthorId, f => user.Id);
            fakeProduct.RuleFor(p => p.Content, f => f.Commerce.ProductDescription() + "[fakeData]");
            fakeProduct.RuleFor(p => p.DateCreated, f => f.Date.Between(new DateTime(2022, 1, 1), new DateTime(2022, 5, 1)));
            fakeProduct.RuleFor(p => p.Description, f => f.Lorem.Sentence(3));
            fakeProduct.RuleFor(p => p.Published, f => true);
            fakeProduct.RuleFor(p => p.Slug, f => f.Lorem.Slug());
            fakeProduct.RuleFor(p => p.Title, f => $"SP {bv++} " + f.Commerce.ProductName());
            fakeProduct.RuleFor(p => p.Price, f => int.Parse(f.Commerce.Price(500, 1000, 0)));


            List<ProductModel> products = new List<ProductModel>();
            List<ProductCategoryProduct> product_categories = new List<ProductCategoryProduct>();

            for (int i = 0; i < 40; i++)
            {
                var product = fakeProduct.Generate();
                product.DateUpdated = product.DateCreated;

                products.Add(product);
                product_categories.Add(new ProductCategoryProduct()
                {
                    Product = product,
                    Category = categories[rCateIndex.Next(5)]
                });
            }

            _dbContext.AddRange(products);
            _dbContext.AddRange(product_categories);

            // END POST



            _dbContext.SaveChanges();
        }
    }
}

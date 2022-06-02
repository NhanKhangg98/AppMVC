using AppMVC.Net.Models;
using System.Collections.Generic;

namespace AppMVC.Net.Services
{
    public class ProductService: List<ProductModel>
    {
        public ProductService()
        {
            this.AddRange(new ProductModel[]
            {
                new ProductModel() {Id = 1, Name="IphoneX", Price = 500},
                new ProductModel() {Id = 2, Name="Samsung", Price = 100},
                new ProductModel() {Id = 3, Name="MacBook", Price = 1000},
                new ProductModel() {Id = 4, Name="IMac", Price = 5000},
            });
        }
    }
}

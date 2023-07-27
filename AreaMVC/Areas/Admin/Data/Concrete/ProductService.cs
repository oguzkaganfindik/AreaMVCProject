using AreaMVC.Areas.Admin.Data.Interface;
using AreaMVC.Areas.Admin.Models;

namespace AreaMVC.Areas.Admin.Data.Concrete
{
    public class ProductService : IProductService
    {
        public string AddProduct(Product product)
        {
            return "Ürün eklenmiştir!!";
        }

        public List<Product> GetProducts()
        {
            Product product1 = new Product
            {
                Id = 1,
                Name = "Elma",
                Category = "Meyve",
                CreatedDate = new DateTime(2023, 06, 20),
                Stock = 450
            };

            Product product2 = new Product
            {
                Id = 2,
                Name = "Domates",
                Category = "Sebze",
                CreatedDate = new DateTime(2023, 06, 24),
                Stock = 200
            };

            Product product3 = new Product
            {
                Id = 3,
                Name = "Galaxy S23 Ultra",
                Category = "Teknoloji-Samsung",
                CreatedDate = new DateTime(2023, 01, 06),
                Stock = 15
            };

            Product product4 = new Product
            {
                Id = 4,
                Name = "Monitör 165 Hz",
                Category = "DELL",
                CreatedDate = new DateTime(2023, 03, 19),
                Stock = 22
            };

            Product product5 = new Product
            {
                Id = 5,
                Name = "Meyve Suyu",
                Category = "Migros",
                CreatedDate = new DateTime(2023, 06, 26),
                Stock = 600
            };

            List<Product> products = new List<Product> { product1, product2, product3, product4, product5 };

            return products;
        }
    }
}

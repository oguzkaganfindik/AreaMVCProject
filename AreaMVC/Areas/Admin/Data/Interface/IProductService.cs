using AreaMVC.Areas.Admin.Models;

namespace AreaMVC.Areas.Admin.Data.Interface
{
    public interface IProductService
    {
        List<Product> GetProducts();

        string AddProduct(Product product);
    }
}

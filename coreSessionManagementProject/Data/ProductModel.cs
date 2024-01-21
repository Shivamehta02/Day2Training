using coreSessionManagementProject.Models;

namespace coreSessionManagementProject.Data
{
    public class ProductModel
    {
        List<Product> products = new List<Product>()
        {
            new Product() { Id = 101, Name = "Product One", Price = 500 },
            new Product() { Id = 102, Name = "Product Two", Price = 500 },
            new Product() { Id = 103, Name = "Product Three", Price = 500 },
            new Product() { Id = 104, Name = "Product four", Price = 500 }
        };
        public List<Product> findAll()
        {
            return products;
        }

        public Product? find(int id)
        {
            var product = products.Find(product => product.Id == id);
            if (product != null) return product;
            return null;
        }
    }
}

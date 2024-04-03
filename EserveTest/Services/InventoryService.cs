using EserveTest.Models;

namespace EserveTest.Services
{
    public class InventoryService
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            //Auto Increment 
            _products.Add(product);
        }

        public Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }
    }
}

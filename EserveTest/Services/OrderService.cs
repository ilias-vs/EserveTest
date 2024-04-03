using EserveTest.Models;

namespace EserveTest.Services
{
    public class OrderService
    {
        private readonly List<Order> _orders = new List<Order>();

        public void PlaceOrder(List<Product> products)
        {
            var order = new Order
            {
                Id = _orders.Count + 1,
                Products = products
            };
            _orders.Add(order);
        }

        public List<Order> GetOrderHistory()
        {
            return _orders;
        }
    }
}

using Assignment.Api.DTO;
using Assignment.Api.Models;

namespace Assignment.Api.Repositories
{
    public class InMemOrdersRepository : IOrderRepository
    {
        private List<Order> _orders = new();
        public Order GetOrder(Guid id) => _orders.FirstOrDefault(x => x.OrderID == id)!;

        public IEnumerable<Order> GetOrders() => _orders;

        public void GiveOrder(Order order) => _orders.Add(order);
    }
}
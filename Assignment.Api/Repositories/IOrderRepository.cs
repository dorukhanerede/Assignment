using Assignment.Api.DTO;
using Assignment.Api.Models;

namespace Assignment.Api.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(Guid id);
        void GiveOrder(Order order);
    }
}
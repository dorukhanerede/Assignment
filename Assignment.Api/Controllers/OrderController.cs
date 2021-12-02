using Assignment.Api.DTO;
using Assignment.Api.Models;
using Assignment.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repository;

        public OrderController(IOrderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<OrderReturnDTO> GetOrders()
        {
            return _repository.GetOrders().Select(x => x.asReturnDTO());
        }

        [HttpGet("{id}")]
        public ActionResult<OrderReturnDTO> GetOrder(Guid id)
        {
            var order = _repository.GetOrder(id);

            if (order is null)
                return NotFound();

            return _repository.GetOrder(id).asReturnDTO();
        }

        [HttpPost]
        public ActionResult CreateOrder(CreateOrderDTO order)
        {
            var newOrder = new Order
            {
                OrderID = order.Id,
                Products = order.Products
            };
            _repository.GiveOrder(newOrder);
            return CreatedAtAction(nameof(GetOrder), new { orderID = newOrder.OrderID }, newOrder);
        }
    }
}
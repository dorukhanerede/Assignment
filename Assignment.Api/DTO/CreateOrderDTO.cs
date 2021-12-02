using Assignment.Api.Models;

namespace Assignment.Api.DTO
{
    public record CreateOrderDTO
    {
        public Guid Id { get; init; }
        public List<Product> Products { get; init; }
    }
}
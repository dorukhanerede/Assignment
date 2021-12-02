using Assignment.Api.Models;

namespace Assignment.Api.DTO
{
    public record OrderReturnDTO
    {
        public List<Product> Products { get; init; } = new();

        public double RequiredBinWidth { get; init; }
    }
}
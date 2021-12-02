using System.ComponentModel.DataAnnotations;

namespace Assignment.Api.Models
{
    public record Order
    {
        [Required]
        public Guid OrderID { get; init; }
        [Required]
        public List<Product> Products { get; init; }

        public double getTotalWidth()
        {

            var total = 0.0;
            if (Products != null)
            {
                foreach (var item in Products)
                {
                    total += item.getWidth();
                }
            }
            return total;
        }
    }
}
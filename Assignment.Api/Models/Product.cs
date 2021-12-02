using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Assignment.Api.Models
{
    public record Product
    {
        [EnumDataType(typeof(ProductType))]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Required]
        public ProductType ProductType { get; init; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; init; }

        public double getWidth()
        {
            var stackSize = (decimal)Quantity / (decimal)ProductType.getStackSize();
            return Decimal.ToInt32(Math.Ceiling(stackSize)) * ProductType.getWidth();
        }
    }
}
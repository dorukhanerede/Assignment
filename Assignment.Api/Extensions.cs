using System.Reflection;
using Assignment.Api.DTO;
using Assignment.Api.Helper;
using Assignment.Api.Models;

namespace Assignment.Api
{
    public static class Extensions
    {
        public static double getWidth(this ProductType type)
        {
            return typeof(ProductType).GetField(type.ToString())!
                .GetCustomAttribute<ProductTypeAttribute>(false)!
                .width;
        }

        public static int getStackSize(this ProductType type)
        {
            return typeof(ProductType).GetField(type.ToString())!
                .GetCustomAttribute<ProductTypeAttribute>(false)!
                .stackSize;
        }

        public static OrderReturnDTO asReturnDTO(this Order order)
        {
            return new OrderReturnDTO
            {
                Products = order.Products,
                RequiredBinWidth = order.getTotalWidth()
            };
        }

        public static CreateOrderDTO asCreateOrderDTO(this Order order)
        {
            return new CreateOrderDTO
            {
                Id = order.OrderID,
                Products = order.Products
            };
        }
    }
}
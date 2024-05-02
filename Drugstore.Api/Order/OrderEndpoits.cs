using Drugstore.Application.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;

namespace Drugstore.Api.Order
{
    public static class OrderEndpoints
    {
        public static void ConfigureOrderEndpoints(this WebApplication app)
        {
            var orders = app.MapGroup("/orders").WithTags("orders").WithOpenApi();

            orders.MapGet("", GetAllOrders);
            orders.MapGet("/{orderId}", GetOrderById);
     
            //orders.MapPut("/{OrderId}", UpdateOrder);
            // orders.MapDelete("/{OrderId}", DeleteOrder);
        }

        private static async Task<IActionResult> GetAllOrders([FromServices] IOrderService orderService)
        {
            var ordersDto = await orderService.GetAllOrders();
            return new OkObjectResult(ordersDto);
        }

        private static async Task<IActionResult> GetOrderById(int orderId, [FromServices] IOrderService orderService)
        {
            var orderDto = await orderService.GetOrderById(orderId);
            return new OkObjectResult(orderDto);
        }

    

    

        // private static async Task<IActionResult> DeleteOrder(int orderId, [FromServices] IOrderService orderService)
        // {
        //     await orderService.DeleteOrder(orderId);
        //     return new OkResult();
        // }
    }
}

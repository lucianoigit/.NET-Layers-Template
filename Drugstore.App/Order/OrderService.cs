using Drugstore.Domain.Order;
using Drugstore.Application;

namespace Drugstore.Application.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrders()
        {
            var orderEntity = await _orderRepository.GetAllAsync();
            var orderDTOList = new List<OrderDTO>();

            foreach (var order in orderEntity)
            {
                var orderDTO = GenericMapper<Drugstore.Domain.Order.Order, OrderDTO>.Map(order);
                orderDTOList.Add(orderDTO);
            }

            return orderDTOList;
        }

        public async Task<OrderDTO> GetOrderById(int orderId)
        {
            try
            {
                var orderEntity = await _orderRepository.GetByIdAsync(orderId);

                // Verifica si la entidad de pedido no es nula
                if (orderEntity != null)
                {
                    var orderDTO = GenericMapper<Drugstore.Domain.Order.Order, OrderDTO>.Map(orderEntity);
                    return orderDTO;
                }
                else
                {
                    
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la obtención del pedido
                // Por ejemplo, podrías registrar el error
                Console.WriteLine($"Error al obtener el pedido por ID: {ex.Message}");
                throw;
            }
        }
    }
}
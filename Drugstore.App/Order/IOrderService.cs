namespace Drugstore.Application.Order;

public interface IOrderService
{
    Task<IEnumerable<OrderDTO>> GetAllOrders();
    Task<OrderDTO> GetOrderById(int id);

}


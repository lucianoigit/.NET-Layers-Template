using Drugstore.Domain.Order;
using Drugstore.Infrastructure.Context;


namespace Drugstore.Infrastructure.Persitence;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationDbContext _context;

    public OrderRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Order> CreateAsync(Order entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Order>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetByIdAsync(object id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Order entity)
    {
        throw new NotImplementedException();
    }
}

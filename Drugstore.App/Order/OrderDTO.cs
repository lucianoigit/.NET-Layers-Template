namespace Drugstore.Application.Order;

public record OrderDTO(int Id, string NumberOrder, string Description, List<string> Products);

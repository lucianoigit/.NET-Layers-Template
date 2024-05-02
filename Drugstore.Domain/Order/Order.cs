namespace Drugstore.Domain.Order;

public class Order
{
    public int Id { get; set; }
    public string NumberOrder { get; set; }

    public string Description { get; set; }

    public List<string> Products { get; set; }
}



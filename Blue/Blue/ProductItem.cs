namespace Blue;

public class ProductItem(string id, decimal price)
{
    public string Id { get; } = id;
    public decimal Price { get; } = price;
}

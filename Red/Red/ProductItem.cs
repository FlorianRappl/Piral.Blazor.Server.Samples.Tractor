namespace Red;

public class ProductItem(string id, string name, string image, string thumb, string color, decimal price)
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string Image { get; } = image;
    public string Thumb { get; } = thumb;
    public string Color { get; } = color;
    public decimal Price { get; } = price;
}

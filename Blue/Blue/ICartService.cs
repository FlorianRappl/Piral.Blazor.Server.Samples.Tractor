namespace Blue;

public interface ICartService
{
    event EventHandler Changed;

    void AddToCart(ProductItem item);

    void RemoveFromCart(ProductItem item);

    bool IsEmpty { get; }

    int Count { get; }

    decimal Total { get; }
}

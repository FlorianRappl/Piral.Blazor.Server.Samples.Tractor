
namespace Blue;

public class CartService : ICartService
{
    public event EventHandler? Changed;

    private readonly List<ProductItem> _cart = [];

    public bool IsEmpty => _cart.Count == 0;

    public int Count => _cart.Count;

    public decimal Total => _cart.Sum(m => m.Price);

    public void AddToCart(ProductItem item)
    {
        _cart.Add(item);
        Changed?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveFromCart(ProductItem item)
    {
        _cart.Remove(item);
        Changed?.Invoke(this, EventArgs.Empty);
    }
}

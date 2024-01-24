namespace Red;

public class ProductService : IProductService
{
    private readonly List<ProductItem> _products =
    [
        new ProductItem("porsche", "Porsche-Diesel Master 419", "tractor-red.jpg", "tractor-red-thumb.jpg", "red", 66.00m),
        new ProductItem("fendt", "Fendt F20 Dieselroß", "tractor-green.jpg", "tractor-green-thumb.jpg", "green", 54.00m),
        new ProductItem("eicher", "Eicher Diesel 215/16", "tractor-blue.jpg", "tractor-blue-thumb.jpg", "blue", 58.00m),
    ];

    public ProductItem? GetProduct(string id)
    {
        foreach (var item in _products)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return null;
    }

    public IEnumerable<ProductItem> GetProducts() => _products;
}

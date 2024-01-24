namespace Red;

public interface IProductService
{
    IEnumerable<ProductItem> GetProducts();

    ProductItem? GetProduct(string id);
}

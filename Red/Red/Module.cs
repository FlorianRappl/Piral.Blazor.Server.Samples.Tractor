namespace Red;

public class Module : IMfModule
{
    public void Configure(IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
    }

    public Task Setup(IMfAppService app)
    {
        app.PrependStyleSheet("product-page.css");
        app.MapRoute<Products>();
        return Task.CompletedTask;
    }

    public Task Teardown(IMfAppService app)
    {
        return Task.CompletedTask;
    }
}

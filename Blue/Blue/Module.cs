namespace Blue;

public class Module : IMfModule
{
    public void Configure(IServiceCollection services)
    {
        services.AddSingleton<ICartService, CartService>();
    }

    public Task Setup(IMfAppService app)
    {
        app.PrependStyleSheet("basket-info.css");
        app.PrependStyleSheet("buy-button.css");
        app.MapComponent<Buy>("buy");
        app.MapComponent<Basket>("basket");
        return Task.CompletedTask;
    }

    public Task Teardown(IMfAppService app)
    {
        return Task.CompletedTask;
    }
}

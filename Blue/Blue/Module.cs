namespace Blue;

public class Module : IMfModule
{
    public void Configure(IServiceCollection services)
    {
        services.AddSingleton<ICartService, CartService>();
    }

    public Task Setup(IMfAppService app)
    {
        app.MapComponent<Buy>("buy");
        app.MapComponent<Basket>("basket");
#if DEBUG
        app.MapComponent<DebugView>("products");
#endif
        return Task.CompletedTask;
    }

    public Task Teardown(IMfAppService app)
    {
        return Task.CompletedTask;
    }
}

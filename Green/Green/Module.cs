namespace Green;

public class Module : IMfModule
{
    public void Configure(IServiceCollection services)
    {
        services.AddSingleton<IRecommendationService, RecommendationService>();
    }

    public Task Setup(IMfAppService app)
    {
        app.PrependStyleSheet("recommendations.css");
        app.MapComponent<Recommendations>("recommendations");

        // just for debug purposes we register this as "products"
        // which will display the recommendations already
        // -- luckily this uses the same parameter, otherwise
        // -- we'd need to wrap etc.

        //#if DEBUG
        //        app.MapComponent<Recommendations>("products");
        //#endif
        return Task.CompletedTask;
    }

    public Task Teardown(IMfAppService app)
    {
        return Task.CompletedTask;
    }
}

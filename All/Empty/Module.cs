namespace Empty;

public class Module : IMfModule
{
    public void Configure(IServiceCollection services)
    {
    }

    public Task Setup(IMfAppService app)
    {
        return Task.CompletedTask;
    }

    public Task Teardown(IMfAppService app)
    {
        return Task.CompletedTask;
    }
}

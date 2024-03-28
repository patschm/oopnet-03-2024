using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InfraStructure;

public class ConsoleHost : IHostedService
{
    // IServiceScopeFactory is always a singleton
    // while IServiceProvider can vary based on the lifetime of the containing class.
    // IServiceScopeFactory is preferred in IHostedService implementations.
    private readonly IServiceScopeFactory _scopeFactory;
    
    public ConsoleHost(IServiceScopeFactory scopeFactory, ICounter cnt)
    {
        _scopeFactory = scopeFactory;
        cnt.Increment();
        cnt.Increment();
        cnt.Show();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        using (var scope = _scopeFactory.CreateScope())
        {
            for (int i = 0; i < 5; i++)
            {
                var counter = scope.ServiceProvider.GetRequiredService<ICounter>();
                counter.Increment();
                counter.Show();
            }
        }
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}

using Microsoft.Extensions.Hosting;

namespace FizzBuzz.Cli;

public class Service(IDriver driver, IHostApplicationLifetime host):BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        driver.Run();
        host.StopApplication();
        return Task.CompletedTask;
    }
}
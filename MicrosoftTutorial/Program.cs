using App.WindowsService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.EventLog;

public class Program
{
    public static void Main(string[] args)
    {
        IHost host = CreateHostBuilder(args).Build();
        host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddWindowsService(options =>
                {
                    options.ServiceName = ".NET Joke Service";
                });

                LoggerProviderOptions.RegisterProviderOptions<
                    EventLogSettings, EventLogLoggerProvider>(services);

                services.AddSingleton<JokeService>();
                services.AddHostedService<WindowsBackgroundService>();
            });
}

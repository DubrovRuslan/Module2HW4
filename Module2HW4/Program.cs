using System;
using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Providers;
using Module2HW4.Services;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAnimalsProvider, AminalsProvider>()
                .AddSingleton<IAnimalService, AnimalService>()
                .AddSingleton<IConsoleNotificator, ConsoleNotificator>()
                .AddSingleton<INotificationService, NotificationService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}

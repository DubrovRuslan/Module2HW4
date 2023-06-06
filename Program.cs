using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Providers;
using Module2HW4.Services;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

var serviceProvider = new ServiceCollection()
                .AddTransient<IAnimalsProvider, AminalsProvider>()
                .AddSingleton<IAnimalService, AnimalService>()
                .AddSingleton<IConsoleNotificator, ConsoleNotificator>()
                .AddSingleton<INotificationService, NotificationService>()
                .AddTransient<Module2HW4.Starter>()
                .BuildServiceProvider();
var start = serviceProvider.GetService<Module2HW4.Starter>();
start.Run();

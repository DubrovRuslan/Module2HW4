using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Providers;
using Module2HW4.Services;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

var serviceProvider = new ServiceCollection()
                .AddSingleton<IAnimalsProvider, AminalsProvider>()
                .AddSingleton<IAnimalService, AnimalService>()
                .AddSingleton<IFishService, FishService>()
                .AddSingleton<IFlyingHighBirdService, FlyingHighBirdService>()
                .AddSingleton<IHerbivoreService, HerbivoreService>()
                .AddSingleton<IPredatorService, PredatorService>()
                .AddSingleton<IReptileService, ReptileService>()
                .AddSingleton<IRunningFarBirdService, RunningFarBirdService>()
                .AddSingleton<IConsoleNotificator, ConsoleNotificator>()
                .AddSingleton<INotificationService, NotificationService>()
                .AddTransient<Module2HW4.Starter>()
                .BuildServiceProvider();
var start = serviceProvider.GetService<Module2HW4.Starter>();
start.Run();

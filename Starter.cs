using System;
using Module2HW4.Services.Abstractions;
using Module2HW4.Models.Enums;

namespace Module2HW4
{
    public class Starter
    {
        private readonly IAnimalService _animalService;
        private readonly IFishService _fishService;
        private readonly IFlyingHighBirdService _flyingHighBirdService;
        private readonly IHerbivoreService _herbivoreService;
        private readonly IPredatorService _predatorService;
        private readonly IReptileService _reptileService;
        private readonly IRunningFarBirdService _runningFarBirdService;
        private readonly INotificationService _notificationService;

        public Starter(IAnimalService animalService, IFishService fishService, IFlyingHighBirdService flyingHighBirdService, IHerbivoreService herbivoreService, IPredatorService predatorService, IReptileService reptileService, IRunningFarBirdService runningFarBirdService, INotificationService notificationService)
        {
            _animalService = animalService;
            _fishService = fishService;
            _flyingHighBirdService = flyingHighBirdService;
            _herbivoreService = herbivoreService;
            _predatorService = predatorService;
            _reptileService = reptileService;
            _runningFarBirdService = runningFarBirdService;
            _notificationService = notificationService;
        }

        public void Run()
        {
            _fishService.AddFish("Селедка", 3.6, Habitat.Water, WaterType.SaltyWater);
            _fishService.AddFish("Пиранья", 0.2, Habitat.Water, WaterType.SaltyWater);
            _reptileService.AddReptile("Большая черепаха", 150, Habitat.WaterAndLand, true, false);
            _reptileService.AddReptile("Вечно голодный алигатор", 800, Habitat.WaterAndLand, false, true);
            _reptileService.AddReptile("Непонятная ящерица", 2, Habitat.Land, false, false);
            _flyingHighBirdService.AddFlyingHighBird("Просто гусь", 8, Habitat.AirAndLand, 10175);
            _flyingHighBirdService.AddFlyingHighBird("Голобь обыкновенус", 3, Habitat.AirAndLand, 60);
            _flyingHighBirdService.AddFlyingHighBird("Дятел", 0.3, Habitat.AirAndLand, 16);
            _runningFarBirdService.AddRunningFarBird("Трусливый страус", 70, Habitat.Land, 1);
            _predatorService.AddPredator("Просто Царь", 400, Habitat.Land, new string[] { "Все", "Подлый Шакал" });
            _predatorService.AddPredator("Подлый Шакал", 20, Habitat.Land, new string[] { "Непонятная ящерица", "Голобь обыкновенус", "Трусливый страус" });
            _predatorService.AddPredator("Гепард", 45, Habitat.Land, new string[] { "Кого догонит" });
            _herbivoreService.AddHerbivore("Большой слон", 4000, Habitat.Land, new string[] { "Еда" });
            _animalService.SortAniAnimalByName();
            var count = _fishService.FishesCount();
            _notificationService.CountNotify(count, "Рыбок");
            count = _reptileService.ReptilesCount();
            _notificationService.CountNotify(count, "Рептилоидов");
            count = _flyingHighBirdService.FlyingHighBirdsCount();
            _notificationService.CountNotify(count, "Высоко летающих птичек");
            count = _runningFarBirdService.RunningFarBirdsCount();
            _notificationService.CountNotify(count, "Далеко бегающих птичек");
            count = _predatorService.PredatorsCount();
            _notificationService.CountNotify(count, "Любителей мяса");
            count = _herbivoreService.HerbivoresCount();
            _notificationService.CountNotify(count, "Травоядные");
            var animals = _animalService.FindAnimalsByName("Царь");
            _notificationService.FindNotify(animals, "Найдено Царей животных)");
            animals = _animalService.FindAnimalsByHeadPenetrationDepth(1);
            _notificationService.FindNotify(animals, "Найдено птиц втыкающих голову в песок");
        }
    }
}

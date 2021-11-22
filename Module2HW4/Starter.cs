using System;
using Module2HW4.Services.Abstractions;
using Module2HW4.Models.Enums;

namespace Module2HW4
{
    public class Starter
    {
        private readonly IAnimalService _animalService;
        private readonly INotificationService _notificationService;

        public Starter(IAnimalService animalService, INotificationService notificationService)
        {
            _animalService = animalService;
            _notificationService = notificationService;
        }

        public void Run()
        {
            _animalService.AddFish("Селедка", 3.6, Habitat.Water, WaterType.SaltyWater);
            _animalService.AddFish("Пиранья", 0.2, Habitat.Water, WaterType.SaltyWater);
            _animalService.AddReptile("Большая черепаха", 150, Habitat.WaterAndLand, true, false);
            _animalService.AddReptile("Вечно голодный алигатор", 800, Habitat.WaterAndLand, false, true);
            _animalService.AddReptile("Непонятная ящерица", 2, Habitat.Land, false, false);
            _animalService.AddFlyingHighBird("Просто гусь", 8, Habitat.AirAndLand, 10175);
            _animalService.AddFlyingHighBird("Голобь обыкновенус", 3, Habitat.AirAndLand, 60);
            _animalService.AddFlyingHighBird("Дятел", 0.3, Habitat.AirAndLand, 16);
            _animalService.AddRunningFarBird("Трусливый страус", 70, Habitat.Land, 1);
            _animalService.AddPredator("Просто Царь", 400, Habitat.Land, new string[] { "Все", "Подлый Шакал" });
            _animalService.AddPredator("Подлый Шакал", 20, Habitat.Land, new string[] { "Непонятная ящерица", "Голобь обыкновенус", "Трусливый страус" });
            _animalService.AddPredator("Гепард", 45, Habitat.Land, new string[] { "Кого догонит" });
            _animalService.AddHerbivore("Большой слон", 4000, Habitat.Land, new string[] { "Еда" });
            _animalService.SortAniAnimalByName();
            var count = _animalService.FishesCount();
            _notificationService.CountNotify(count, "Рыбок");
            count = _animalService.ReptilesCount();
            _notificationService.CountNotify(count, "Рептилоидов");
            count = _animalService.FlyingHighBirdsCount();
            _notificationService.CountNotify(count, "Высоко летающих птичек");
            count = _animalService.RunningFarBirdsCount();
            _notificationService.CountNotify(count, "Далеко бегающих птичек");
            count = _animalService.PredatorsCount();
            _notificationService.CountNotify(count, "Любителей мяса");
            count = _animalService.HerbivoresCount();
            _notificationService.CountNotify(count, "Травоядные");
            var animals = _animalService.FindAnimalsByName("Царь");
            _notificationService.FindNotify(animals, "Найдено Царей животных)");
            animals = _animalService.FindAnimalsByHeadPenetrationDepth(1);
            _notificationService.FindNotify(animals, "Найдено птиц втыкающих голову в песок");
        }
    }
}

using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface INotificationService
    {
        public void FindNotify(Animal[] animals, string messageToNotify);
        public void CountNotify(int count, string message);
    }
}

using System.Text;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IConsoleNotificator _consoleNotificator;

        public NotificationService(IConsoleNotificator consoleNotificator)
        {
            _consoleNotificator = consoleNotificator;
        }

        public void FindNotify(Animal[] animals, string messageToNotify)
        {
            var message = new StringBuilder();
            message.AppendLine(messageToNotify);

            foreach (var animal in animals)
            {
                message.AppendLine(animal.Name);
            }

            _consoleNotificator.WriteToConsole(message.ToString());
        }

        public void CountNotify(int count, string message)
        {
            _consoleNotificator.WriteToConsole($"{message} : {count}");
        }
    }
}

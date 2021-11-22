using System;
using Module2HW4.Services.Abstractions;

public class ConsoleNotificator : IConsoleNotificator
{
    public void WriteToConsole(string message)
    {
        Console.WriteLine(message);
    }
}

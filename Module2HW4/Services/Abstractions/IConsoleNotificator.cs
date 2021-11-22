using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Services.Abstractions
{
    public interface IConsoleNotificator
    {
        public void WriteToConsole(string message);
    }
}

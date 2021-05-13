using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MartianRobots.Domain.Interfaces
{
    public interface IMessagesService
    {
        string GetMessage(string messageId);
    }
}

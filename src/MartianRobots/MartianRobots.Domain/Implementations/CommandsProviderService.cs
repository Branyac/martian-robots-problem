using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MartianRobots.Domain.Interfaces;

namespace MartianRobots.Domain.Implementations
{
    public class CommandsProviderService : ICommandsProviderService
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public IEnumerable<ICommand> Commands => _commands;

        public async Task Register(ICommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _commands.Add(command);
        }
    }
}

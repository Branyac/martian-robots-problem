using System.Threading.Tasks;
using MartianRobots.Domain.Implementations;

namespace MartianRobots.Domain.Interfaces
{
    public interface ICommand
    {
        Task Execute(Robot robot);
        Task<bool> CanExecute(char input);
    }
}

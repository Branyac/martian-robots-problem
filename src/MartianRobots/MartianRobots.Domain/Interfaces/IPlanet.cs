using System.Threading.Tasks;
using MartianRobots.Domain.Implementations;

namespace MartianRobots.Domain.Interfaces
{
    public interface IPlanet
    {
        ISurface Surface { get; }
        Task ProcessRobotInput(Robot robot, char input);
    }
}
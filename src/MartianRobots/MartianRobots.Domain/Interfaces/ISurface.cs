using System;
using System.Threading.Tasks;
using MartianRobots.Domain.Models;

namespace MartianRobots.Domain.Interfaces
{
    public interface ISurface
    {
        Task SetSize(Point upperCoordinates);
        Task<Tuple<bool, Point>> TryMove(Point actualCoordinates, Point newCoordinates);
    }
}

using System.Threading.Tasks;
using MartianRobots.Domain.Models;

namespace MartianRobots.Domain.Interfaces
{
    public interface IScentPointsService
    {
        Task Add(Point coordinate);
        Task<bool> IsScentPoint(Point coordinate);
    }
}

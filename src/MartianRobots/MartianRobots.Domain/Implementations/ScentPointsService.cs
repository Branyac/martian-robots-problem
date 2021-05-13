using System.Collections.Generic;
using System.Threading.Tasks;
using MartianRobots.Domain.Interfaces;
using MartianRobots.Domain.Models;

namespace MartianRobots.Domain.Implementations
{
    public class ScentPointsService : IScentPointsService
    {
        private List<Point> _scentPoints = new List<Point>();

        public async Task Add(Point coordinate)
        {
            _scentPoints.Add(coordinate);
        }

        public async Task<bool> IsScentPoint(Point coordinate)
        {
            return _scentPoints.Contains(coordinate);
        }
    }
}

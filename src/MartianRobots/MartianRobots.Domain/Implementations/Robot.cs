using System.Diagnostics.CodeAnalysis;
using System.Text;
using MartianRobots.Domain.Models;

namespace MartianRobots.Domain.Implementations
{
    public class Robot
    {
        private const char SEPARATOR = ' ';
        private const string STR_LOST = "LOST";

        public bool IsLost { get; set; }
        public Position LastValidPosition { get; set; }

        public string StatusToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendJoin(SEPARATOR, LastValidPosition.Coordinates.X, LastValidPosition.Coordinates.Y, (char) LastValidPosition.Orientation);
            if (IsLost)
            {
                result.Append(SEPARATOR + STR_LOST);
            }

            return result.ToString();
        }
    }
}

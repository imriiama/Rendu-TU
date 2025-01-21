using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class Pathfinding //faire à la fin si temps au moins getcoord+isoutofbound
    {
        public Pathfinding(string map1)
        {
        }

        public char[,] Grid { get; internal set; }

        internal Path BreadthFirstSearch(Vector2 start, Vector2 destination)
        {
            throw new NotImplementedException();
        }

        internal char GetCoord(Vector2 el)
        {
            if (IsOutOfBound(el))
            {
                throw new ArgumentException("hors limites !");
            }

            return Grid[el.X, el.Y];
        }

        internal List<char> GetNeighboors(Vector2 vector2)
        {
            throw new NotImplementedException();
        }

        internal List<char> GetNeighboors(Vector2 vector2, List<Vector2> exclude)
        {
            throw new NotImplementedException();
        }

        internal bool IsOutOfBound(Vector2 vector2)
        {
            if (vector2.X < 0 || vector2.X >= Grid.GetLength(0))
            {
                return true;  
            }

            if (vector2.Y < 0 || vector2.Y >= Grid.GetLength(1))
            {
                return true;  
            }
            return false;
        }
    }

}

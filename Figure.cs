using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpsnake
{
    class Figure
    {
        protected List<Point> obstacleList;
        public void Draw()
        {
            foreach (Point p in obstacleList)
            {
                p.Draw();

            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var p in obstacleList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in obstacleList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}

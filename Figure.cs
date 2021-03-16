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
        public virtual void Draw()
        {
            foreach (Point p in obstacleList)
            {
                p.Draw();

            }
        }
    }
}

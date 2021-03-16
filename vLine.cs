using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpsnake
{
    class vLine : Figure
    {
        

        public vLine(int yTop, int yBottom, int x, char sym)
        {
            obstacleList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                obstacleList.Add(p);
            }


        }

        
    }
}

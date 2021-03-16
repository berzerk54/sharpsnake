using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpsnake
{
    class hLine :Figure
    {
       

        public hLine(int xLeft, int xRight,int y, char sym)
        {
            obstacleList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                obstacleList.Add(p);
            }
            

        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Point p in obstacleList)
            {
                p.Draw();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpsnake
{
    class hLine
    {
        List<Point> obstacleList;

        public hLine(int xLeft, int xRight,int y, char sym)
        {
            obstacleList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                obstacleList.Add(p);
            }
            

        }

        public void Draw()
        {
            foreach (Point p in obstacleList)
            {
                p.Draw();

            }
        }
    }
}

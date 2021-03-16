﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpsnake
{
    class Walls
    {
        List<Figure> wallList;

       public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            hLine upLine = new hLine(0, mapWidth -2, 0, '#');
            hLine downLine = new hLine(0, mapWidth -2, mapHeight -1, '#');
            vLine leftLine = new vLine(0, mapHeight - 1, 0, '#');
            vLine rightLine = new vLine(0, mapHeight - 1, mapWidth-2, '#');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpsnake
{
    class Snake: Figure
    {
        Direction direction;
        public Snake(Point tail, int length,Direction _direction)
        {
            direction = _direction;
            obstacleList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                obstacleList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = obstacleList.First();
            obstacleList.Remove(tail);
            Point head = GetNextPoint();
            obstacleList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = obstacleList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}

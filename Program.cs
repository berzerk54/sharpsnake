using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sharpsnake
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 25);
            Console.SetBufferSize(60, 25);

            Point p1 = new Point(10,10,'*');
            
            hLine h1 = new hLine(5, 55, 2, '#');
            hLine h2 = new hLine(5, 55, 22, '#');
            vLine v1 = new vLine(2, 22, 5, '#');
            vLine v2 = new vLine(2, 22, 55, '#');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            
           
            h1.Draw();
            h2.Draw();
            v1.Draw();
            v2.Draw();
            snake.Draw();
            snake.Move();
           
        }
    }
}

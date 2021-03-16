using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Point p2 = new Point(15,12,'$');
            hLine h1 = new hLine(5, 55, 2, '#');
            hLine h2 = new hLine(5, 55, 22, '#');
            vLine v1 = new vLine(2, 22, 5, '#');
            vLine v2 = new vLine(2, 22, 55, '#');

            p1.Draw();
            p2.Draw();
            h1.Draw();
            h2.Draw();
            v1.Draw();
            v2.Draw();

            Console.ReadLine();
        }
    }
}

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
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Point p1 = new Point(10,10,'*');
            hLine h1 = new hLine(0, 78, 0, '#');
            hLine h2 = new hLine(0, 78, 24, '#');
            vLine v1 = new vLine(0, 24, 0, '#');
            vLine v2 = new vLine(0, 24, 78, '#');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
           
            h1.Draw();
            h2.Draw();
            v1.Draw();
            v2.Draw();
            snake.Draw();
            food.Draw();
            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    snake.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            
           
           
        }
    }
}

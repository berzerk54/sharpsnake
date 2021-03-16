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


            vLine vl = new vLine(0, 10, 5, '%');
            Draw(vl);
            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;
            hLine hl = new hLine(0, 5, 6, '&');
            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach (var f in figures)
            {
                f.Draw();
            }

        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }

            
            
           
           
        }
    }
/*hLine h1 = new hLine(0, 78, 0, '#');
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
            }*/

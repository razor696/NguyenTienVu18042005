using System;
using System.Text;

namespace System
{
    class Program
    {
        static bool isGameover = true;

        static void Main(string[] arg)
        {
            Random rand = new Random();
            int x = 2;
            int y = 5;

            int x1 = rand.Next(1, 17);
            int y1 = rand.Next(1, 7);

            Map(x, y, x1, y1, rand);

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    y--;
                    if (x == x1 - 1 && y == y1)
                    {
                        x1 = rand.Next(1, 18);
                        y1 = rand.Next(1, 8);
                        Map(x, y, x1, y1, rand);
                    }
                    Map(x, y, x1, y1, rand);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    y++;
                    if (x == x1 - 1 && y == y1)
                    {
                        x1 = rand.Next(1, 18);
                        y1 = rand.Next(1, 8);
                        Map(x, y, x1, y1, rand);
                    }
                    Map(x, y, x1, y1, rand);
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                    if (x == x1 - 1 && y == y1)
                    {
                        x1 = rand.Next(1, 18);
                        y1 = rand.Next(1, 8);
                        Map(x, y, x1, y1, rand);
                    }
                    Map(x, y, x1, y1, rand);
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    x++;
                    if (x == x1 - 1 && y == y1)
                    {
                        x1 = rand.Next(1, 18);
                        y1 = rand.Next(1, 8);
                        Map(x, y, x1, y1, rand);
                    }
                    Map(x, y, x1, y1, rand);
                }
                SetGameover(x, y);
            } while (isGameover);

            Console.Clear();
            int width = 20;
            int height = 8;

            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("#");
            }

            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, height);
                Console.WriteLine("#");
            }

            for (int i = 1; i < height + 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("#");
            }

            for (int i = 1; i < height + 1; i++)
            {
                Console.SetCursorPosition(width - 1, i);
                Console.Write('#');
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(1, 1);
            Console.Write("****Game Over****");
            Console.SetCursorPosition(0, 9);
        }

        static bool SetGameover(int x, int y)
        {
            if (y <= 0 || y >= 8 || x <= 0 || x >= 18)
            {
                isGameover = false;
            }
            return isGameover;
        }

        static void Map(int x, int y, int x1, int y1, Random rand)
        {
            Console.Clear();
            int width = 20;
            int height = 8;

            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("#");
            }

            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, height);
                Console.WriteLine("#");
            }

            for (int i = 1; i < height + 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("#");
            }

            for (int i = 1; i < height + 1; i++)
            {
                Console.SetCursorPosition(width - 1, i);
                Console.Write('#');
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y);
            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x1, y1);
            Console.Write(" ");

            Console.SetCursorPosition(0, 9);
            Console.ResetColor();
        }
    }
}
using System;
using static System.Net.Mime.MediaTypeNames;

namespace VeCacHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        
                        int n = 5;
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k <= i; k++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        
                        Console.WriteLine("Draw the square");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine("* * * * * *");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        
                        Console.WriteLine("Draw the rectangle");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("* * * * * *");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        return;
                    default:
                        
                        Console.WriteLine("No choice!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
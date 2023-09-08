﻿using System;

namespace TimGiaTri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Messi", "Ronaldo", "Neymar", "Lewandoski", "Benzema", "Rooney", "DeGea", "Beckham", };
            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");
            }
        }
    }
}
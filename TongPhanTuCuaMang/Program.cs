﻿using System;

namespace tongtongtong
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 11;
            numbers[1] = 12;
            numbers[2] = 13;
            numbers[3] = 14;
            numbers[4] = 15;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            Console.WriteLine(total.ToString());
        }
    }
}
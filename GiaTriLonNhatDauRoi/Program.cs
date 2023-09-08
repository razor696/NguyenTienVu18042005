﻿using System;

namespace dotnet_FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Nhap size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Kich thuoc lon nhat la 20");
            } while (size > 20);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Cu nhap di dung hoi nhieu" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Danh sach: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }

            int max = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("Gia tri lon nhat la " + max + " ,tai vi tri " + index);
        }
    }
}
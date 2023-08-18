using System;

namespace Lmao 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USD :");
            float USDf = float.Parse(Console.ReadLine());
            float VNDf = 23000*USDf;
            Console.WriteLine("VND :" + VNDf);
        }
    }
}

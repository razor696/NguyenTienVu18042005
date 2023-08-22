using System;

namespace CanBangCanNang
{
    public class CanBangCanNangVL
    {
        public static void Main(string[] args)
        {
            double height;
            double weight;
            Console.WriteLine("Please enter height (m) :");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter weight (kg) :");
            weight = float.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height,2);
            bmi = Math.Round(bmi,1);
            Console.WriteLine("BMI :" + bmi);
            if (bmi < 18) { Console.WriteLine("Underweight"); }
            else if (bmi < 25.0) { Console.WriteLine("Normal"); }
            else if (bmi < 30.0) { Console.WriteLine("Overheight"); }
            else { Console.WriteLine("Obese"); }
        }
    }
}
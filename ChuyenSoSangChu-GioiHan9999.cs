using System;
using System.Text;

namespace lmao
{
    public class NumberToEnglish
    {
        public static string NumberToWords(int number)
        {
            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" }; 
            if (number == 0)
                return "zero";
            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));
            string words = "";
            if ((number / 1000) > 0)
            {
                words += unitsMap[number / 1000] + " thousand "; //1,234
                number %= 1000; //234
            }

            if ((number / 100) > 0)
            {
                words += unitsMap[number / 100] + " hundred "; //2,34
                number %= 100; //34
            }

            if (number > 0)
            {
                if (words != "") // words có gì " 1 thousand + 2 hundred + and "
                    words += "and ";

                

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            do
            {
                Console.Write("nhập số có giới 0 đến 9999\nnhập số : ");
                a = int.Parse(Console.ReadLine());
                if (a < 0 || a > 9999) { Console.Write("vượt quá giới hạn nhập lại : "); }
            }
            while (a > 9999);
            Console.WriteLine("chữ tiếng anh là : "+NumberToWords(a));
        }
    }
}
using System;
using System.Collections.Generic;


namespace RomanNumber
{
    class Program
    {
        static void Main()
        {
            string number = string.Empty;
            Console.Write("Enter a number between 1 and 1000 :");
            number = Console.ReadLine();
            if (IsValid(number))
            {
                string roman = ConvertToRoman(number);
                Console.WriteLine("Roman Number is " + roman);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadKey();
        }
        private static string ConvertToRoman(string numberString)
        {
            string romanValue = string.Empty;
            int number = Convert.ToInt32(numberString);
            if (number >= 1)
            {
                foreach (int item in RomanDictionary().Keys)
                {
                    while (number >= item)
                    {
                        romanValue = romanValue + RomanString(item);
                        number -= item;
                    }
                }
            }
            return romanValue;
        }
        private static string RomanString(int n)
        {
            string romanString = string.Empty;
            romanString = RomanDictionary()[n].ToString();
            return romanString;
        }
        private static Dictionary<int, string> RomanDictionary()
        {
            Dictionary<int, string> romanDic = new Dictionary<int, string>();
            romanDic.Add(1000, "M");
            romanDic.Add(900, "CM");
            romanDic.Add(500, "D");
            romanDic.Add(400, "CD");
            romanDic.Add(100, "C");
            romanDic.Add(90, "XC");
            romanDic.Add(50, "L");
            romanDic.Add(40, "XL");
            romanDic.Add(10, "X");
            romanDic.Add(9, "IX");
            romanDic.Add(5, "V");
            romanDic.Add(4, "IV");
            romanDic.Add(1, "I");
            return romanDic;
        }
        private static bool IsValid(string input)
        {
            int value = 0;
            bool isValid = false;
            if (int.TryParse(input, out value))
            {
                if (value <= 1000)
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}

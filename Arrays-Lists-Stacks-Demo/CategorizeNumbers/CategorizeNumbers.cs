using System;
using System.Collections.Generic;
using System.Linq;

namespace CategorizeNumbers
{
    class CategorizeNumbers
    {
        static void Main()
        {
            var numbersString = Console.ReadLine();
            var numbersStringArray = numbersString.Split(' ');
            //double[] numbersArray = Array.ConvertAll(numbersStringArray, number => double.Parse(number));

            List<double> floatingPointNumbersArray = new List<double>();
            List<int> integerNumbersArray = new List<int>();
            int integerNumber;
            double doubleNumber;

            for (int i = 0; i < numbersStringArray.Length; i++)
            {
                if (int.TryParse(numbersStringArray[i], out integerNumber))
                {
                    integerNumbersArray.Add(integerNumber);
                }
                else if (double.TryParse(numbersStringArray[i], out doubleNumber))
                {
                    floatingPointNumbersArray.Add(doubleNumber);
                }
            }

            Console.WriteLine("[{0}] -> min: {1:F2}, max: {2:F2}, sum: {3:F2}, avg: {4}", String.Join(",", floatingPointNumbersArray), floatingPointNumbersArray.Min(), floatingPointNumbersArray.Max(), floatingPointNumbersArray.Sum(), floatingPointNumbersArray.Average());
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4}", String.Join(",", integerNumbersArray), integerNumbersArray.Min(), integerNumbersArray.Max(), integerNumbersArray.Sum(), integerNumbersArray.Average());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            var stringInput = Console.ReadLine();
            var numbersArrayStrings = stringInput.Split(' ');
            var numbersArray = Array.ConvertAll(numbersArrayStrings, number => int.Parse(number)).ToList();

            var minNumber = int.MinValue;
            int numberIndex = 0;
            var sortedNumbers = new List<int>();

            for (int i = 0; i < numbersArray.Count; i++)
            {
                minNumber = numbersArray[i];

                for (int j = 0; j < numbersArray.Count; j++)
                {
                    if (minNumber > numbersArray[j])
                    {
                        minNumber = numbersArray[j];
                        numberIndex = j;
                    }
                }

                sortedNumbers.Add(minNumber);
                numbersArray[numberIndex] = int.MaxValue;
            }

            Console.WriteLine(String.Join(" ", sortedNumbers));
        }
    }
}

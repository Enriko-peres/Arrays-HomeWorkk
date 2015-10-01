using System;
using System.Linq;

namespace Softuni_Matrix_Demo
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            var numbersString = Console.ReadLine();
            var numbersArrayStrings = numbersString.Split(' ');
            var numbersArray = Array.ConvertAll(numbersArrayStrings, number => int.Parse(number));

            Array.Sort(numbersArray);

            Console.WriteLine(String.Join(" ", numbersArray));
        }
    }
}

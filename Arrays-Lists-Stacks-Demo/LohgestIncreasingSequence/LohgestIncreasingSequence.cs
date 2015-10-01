using System;

namespace LohgestIncreasingSequence
{
    class LohgestIncreasingSequence
    {
        static void Main()
        {
            var inputString = Console.ReadLine();
            var stringsArray = inputString.Split(' ');
            string currentSequence = "";
            string longestSequence = "";

            for (int i = 0; i < stringsArray.Length; i++)
            {
                Console.Write(stringsArray[i]);

                if (i == stringsArray.Length - 1 && (longestSequence.Length == currentSequence.Length))
                {
                    longestSequence += stringsArray[i];
                }

                if (i < stringsArray.Length - 1 && (int.Parse(stringsArray[i]) < int.Parse(stringsArray[i + 1])))
                {
                    currentSequence += stringsArray[i] + " ";
                    
                    if (longestSequence.Length < currentSequence.Length)
                    {
                        longestSequence = currentSequence;
                    }
                    Console.Write(" ");
                }
                else
                {
                    currentSequence = "";
                    Console.WriteLine();
                }
            }

            Console.WriteLine(longestSequence);
        }
    }
}

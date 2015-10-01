using System;

namespace SequencesOfEqualString
{
    class SequencesOfEqualString
    {
        static void Main()
        {
            var inputString = Console.ReadLine();
            var stringsArray = inputString.Split(' ');

            for (int i = 0; i < stringsArray.Length; i++)
            {
                Console.Write(stringsArray[i]);

                if (i < stringsArray.Length - 1 && (stringsArray[i] == stringsArray[i + 1]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

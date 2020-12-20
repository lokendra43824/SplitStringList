using System;
using System.Collections.Generic;

namespace SplitStringUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String : ");
            string input = Console.ReadLine();
            string[] split = splitString(input, ' ');
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }
        }
       public static string[] splitString(string input, char delimeter)
        {
            List<string> list = new List<string>();
            int start = 0, count = 0, delCount = 0;

            foreach (var ch in input)
            {
                if (ch.Equals(delimeter))
                {
                    list.Add(input.Substring(start, count - start));
                    start = count + 1;
                    delCount++;
                }
                count++;
            }
            list.Add(input.Substring(start, input.Length - start));

            string[] stringArray = new string[delCount + 1];

            for (int i = 0; i < list.Count; i++)
            {
                stringArray[i] = list[i];
            }

            return stringArray;
        }

    }
}

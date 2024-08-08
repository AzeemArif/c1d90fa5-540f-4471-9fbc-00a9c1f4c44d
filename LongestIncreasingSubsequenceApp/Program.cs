using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = FindLongestIncreasingSubsequence(input);
            Console.WriteLine(string.Join(" ", result));
        }

        public static List<int> FindLongestIncreasingSubsequence(string input)
        {
            var numbers = input.Split(' ').Select(int.Parse).ToArray();
            int n = numbers.Length;
            if (n == 0) return new List<int>();

            var longestSequence = new List<int>();
            var currentSequence = new List<int> { numbers[0] };

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > currentSequence.Last())
                {
                    currentSequence.Add(numbers[i]);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }
                    currentSequence = new List<int> { numbers[i] };
                }
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = currentSequence;
            }

            return longestSequence;
        }
    }
}
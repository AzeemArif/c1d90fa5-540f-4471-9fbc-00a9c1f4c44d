using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequenceApp
{
    public class LongestSubsequenceFinder
    {
        public static List<int> FindLongestIncreasingSubsequence(List<int> numbers)
        {
            if (numbers.Count == 0) return new List<int>();
            var longestSequence = new List<int>();
            var currentSequence = new List<int> { numbers[0] };

            for (int i = 1; i < numbers.Count; i++)
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
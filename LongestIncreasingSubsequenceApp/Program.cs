using System;
using System.Collections.Generic;

namespace LongestIncreasingSubsequenceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = PromptUserForInput();
                if (ShouldExit(input))
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }

                try
                {
                    // Process the input and find the longest increasing subsequence
                    var numbers = ParseInput(input);
                    var result = LongestSubsequenceFinder.FindLongestIncreasingSubsequence(numbers);
                    Console.WriteLine("Longest Increasing Subsequence: " + string.Join(" ", result));
                }
                catch (Exception ex)
                {
                    // Log any exceptions that occur during processing
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        static string PromptUserForInput()
        {
            Console.WriteLine("Enter space-separated integers to find the longest increasing subsequence or type 'quit' to exit:");
            string? input = Console.ReadLine();
            return input ?? string.Empty;
        }

        public static bool ShouldExit(string input)
        {
            return string.IsNullOrWhiteSpace(input) || input.Trim().ToLower() == "quit";
        }

        public static List<int> ParseInput(string input)
        {
            Console.WriteLine("Processing input: " + input);

            var numberStrings = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var numbers = new List<int>();

            foreach (var numberString in numberStrings)
            {
                try
                {
                    numbers.Add(int.Parse(numberString));
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Invalid number format: '{numberString}'");
                    throw new ArgumentException("Input contains invalid number format.");
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No valid numbers entered.");
            }
            return numbers;
        }
    }
}
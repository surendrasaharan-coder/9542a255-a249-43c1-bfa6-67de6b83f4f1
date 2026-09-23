using System;

namespace App
{
    public static class Solver
    {
        public static string GetLongestIncreasingSubsequence(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return string.Empty;

            var numbers = new long[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                // We use long to defensively parse any large integer as the prompt indicates 'any number of integers'.
                if (long.TryParse(parts[i], out long num))
                {
                    numbers[i] = num;
                }
                else
                {
                    // Fallback to 0 if an invalid character is found
                    numbers[i] = 0;
                }
            }

            int maxLength = 1;
            int maxStart = 0;

            int currentLength = 1;
            int currentStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = currentStart;
                    }
                    currentStart = i;
                    currentLength = 1;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStart = currentStart;
            }

            var resultNumbers = new string[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                resultNumbers[i] = parts[maxStart + i];
            }

            return string.Join(" ", resultNumbers);
        }
    }
}

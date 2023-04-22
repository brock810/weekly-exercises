using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach (string str in words)
            {
                if (string.Equals(str, word, comparison))
                {
                    return true;
                }
            }

            return false;

        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!charCounts.ContainsKey(c))
                {
                    charCounts[c] = 1;
                }
                else
                {
                    charCounts[c]++;
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (charCounts[c] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;
            int currentCount = 0;
            int currentNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == currentNumber)
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 1;
                    currentNumber = numbers[i];
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n <= 0 || elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}

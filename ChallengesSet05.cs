using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber % n == 0) {
                return startNumber;
            } else {
                return startNumber + (n - startNumber % n);
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            if (businesses == null)
            {
                return;
            }

            foreach (Business b in businesses)
            {
                if (b.TotalRevenue == 0)
                {
                    b.Name = "CLOSED";
                }
            }
        }
        public bool IsAscendingOrder(int[] numbers)
        {
            return numbers == null || !numbers.Skip(1).Any() || numbers.Zip(numbers.Skip(1), (a, b) => a <= b).All(x => x);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }
        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            StringBuilder sentence = new StringBuilder(words[0].ToUpper());
            for (int i = 1; i < words.Length; i++)
            {
                sentence.Append(" ");
                sentence.Append(words[i].ToLower());
            }

            sentence.Append(".");

            return sentence.ToString();
        }
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(targetNumber - nums[i]))
                {
                    return true;
                }
                else
                {
                    set.Add(nums[i]);
                }
            }
            return false;
        }

    }
}

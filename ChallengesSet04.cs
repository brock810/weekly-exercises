using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evenSum = 0;
            int oddSum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            return evenSum - oddSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = int.MaxValue;

            foreach (string str in new string[] { str1, str2, str3, str4 })
            {
                if (str.Length < shortestLength)
                {
                    shortestLength = str.Length;
                }
            }

            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = int.MaxValue;

            foreach (int num in new int[] { number1, number2, number3, number4 })
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }

            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
           sideLength1 + sideLength3 > sideLength2 &&
           sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int notNullCount = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
                else
                {
                    notNullCount++;
                }
            }

            return nullCount > notNullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            int count = 0;
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                    sum += number;
                }
            }
            return count > 0 ? (double)sum / count : 0.0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative", nameof(number));
            }

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

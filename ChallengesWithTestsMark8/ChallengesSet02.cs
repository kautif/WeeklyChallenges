using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var type = char.IsLetter(c);
            if (type) {
                return true;
            } else {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = vals.Length;

            if (count % 2 == 0)
            {
                return true;
            } else {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.ToList().Count == 0)
            {
                return 0;
            }

            List<double> numList = new List<double>(numbers);
            numList.Sort();
            double smallest = numList[0];
            double largest = numList[0];

            if (numList.Count > 0) {
                foreach (double num in numList)
                {
                    if (num < smallest) {
                        smallest = num;
                    }

                    if (num > largest)
                    {
                        largest = num;
                    }
                }
            }
            double sum = smallest + largest;

            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int str1Length = str1.Length;
            int str2Length = str2.Length;
            int shortest = 0;
            if (str1Length < str2Length) {
                shortest = str1Length;
            } else {
                shortest = str2Length;
            }
            return shortest;
        }

        public int Sum(int[] numbers)
        {
            int sum;
            if (numbers != null)
            {
                sum = numbers.Sum(x => x);
            }
            else {
                sum = 0;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers != null) {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                sum = numbers.Sum(x => x);
            }
            else
            {
                sum = 0;
            }

            if (sum % 2 == 0)
            {
                return false;
            }
            else {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int num = 0; num < number; num++)
            {
                if (num % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

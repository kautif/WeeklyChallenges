using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evensSum = 0;
            int oddsDiff = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evensSum += numbers[i];
                }
                else
                {
                    oddsDiff -= numbers[i];
                }
            }
            return evensSum + oddsDiff;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = str1.Length;
            List<int> stringList = new List<int>();
            stringList.Add(str1.Length);
            stringList.Add(str2.Length);
            stringList.Add(str3.Length);
            stringList.Add(str4.Length);
            stringList.Sort();
            shortest = stringList[0];
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            numbers.Add(number4);
            numbers.Sort();
            return numbers[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders"; 
            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double value))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int objCount = objs.Length;
            int nullCount = 0;

            foreach (object obj in objs)
            {
                if (obj == null) {
                    nullCount++;
                }
            }

            if (nullCount > objCount / 2)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) {
                return 0;
            }

            int evensCount = 0;
            int evensSum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0) { 
                    evensCount++;
                    evensSum += number;
                }
            }

            if (evensCount == 0) {
                return 0;
            }

            return (double) evensSum / evensCount;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int factorial = 1;
            List<int> numList = new List<int>();
            for (int i = 1; i <= number; i++) {
                numList.Add(i);
            }

            foreach (var num in numList)
            {
                factorial *= num;
            }
            return factorial;
        }
    }
}

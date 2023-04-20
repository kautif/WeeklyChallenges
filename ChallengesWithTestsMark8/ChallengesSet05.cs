using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            /*            if (startNumber == 0) {
                            startNumber = n;
                        }

                        if (startNumber % n == 0) {
                            return startNumber;
                        } else {
                            int i = startNumber;
                            if (startNumber != 0)
                            {
                                while (i % n != 0)
                                {
                                    i++;
                                }
                            }
                            return i;
                        } */

            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses) {
                if (business.TotalRevenue == 0) {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool sorted = false;
            if (numbers == null) {
                return sorted;
            }

            if (numbers.Length == 1) {
                sorted = true;
                return sorted;
            }

            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i] < numbers[i - 1])
                {
                    sorted = false;
                    return sorted;
                }
                else {
                    sorted = true;
                }
            }
            return sorted;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null) {
                return 0;
            }

            int sum = 0;
            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i - 1] % 2 == 0) {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) {
                return "";
            }

            string sentence = "";

            for (int i = 0; i < words.Length; i++) {
                if (words[i].Trim().Length > 0) {
                    sentence += words[i].Trim() + " ";
                }
            }

            if (sentence.Length == 0) {
                return "";
            }

            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] emptyArr = new double[] { };
            if (elements == null) {
                return emptyArr;
            } 
            List<double> fourths = new List<double>();
            for (int i = 3; i < elements.Count; i += 4) {
                fourths.Add(elements[i]);                
            }

            return fourths.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++) {
                for (int k = i + 1; k < nums.Length; k++) {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;   
                    }
                }
            }            
            return false;
        }
    }
}

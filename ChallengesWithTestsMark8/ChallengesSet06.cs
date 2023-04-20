using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        // Go through each word in word list
        // For each word, check whether word is uppercase
        // Check whether target word is upper case at the same character
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            string[] wordsArray = words.ToArray();

            if (words == null || words.Count() == 0)
            {
                return false;
            }

            if (words.Contains(word) && ignoreCase)
            {
                return true;
            }
            else if (words.Contains(word) && ignoreCase == false)
            {
                for (int i = 0; i < wordsArray.Count(); i++)
                {
                    for (int k = 0; k < wordsArray[i].Length; i++)
                    {
                        if (Char.IsUpper(wordsArray[i][k]) && Char.IsUpper(word[k]))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2)
            {
                return true;
            }

            if (num < 2 || num % 2 == 0)
            {
                return false;
            }

            int sqrt = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= sqrt; i += 2)
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
            return str.IndexOf(str.Distinct()
                                .Reverse()
                                .Where(x => str.Where(y => y.Equals(x)).Count() == 1)
                                .FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            /*
            int maxCount = 0;
            List<int> counts = new List<int>();
            for (int i = 0; i < numbers.Length - 1; i++) {
                if (numbers[i + 1] == numbers[i] + 1)
                {
                    maxCount += 1;
                }
                else {
                    counts.Add(maxCount);
                    maxCount = 0;
                }
            }
            counts.Sort();
            return counts.Last(); */

            int count = 0;
            // iterate through numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                // 2nd for loop is the number after i
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // if numbers[j] does not equal numbers[i], numbers[j] isnt consecutive
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    // otherwise it is, so increment count
                    currentCount++;
                }
                // if currentCount is greater than count, then update count to currentCount to reflect current highest consecutive count
                if (currentCount > count)
                {
                    count = currentCount;
                }

            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            // initial attempt
            /*            List<double> nths = new List<double>();
                        if (elements != null || elements.Count > 0)
                        {
                            for (int i = n; i < elements.Count; i += n)
                            {
                                nths.Add(elements[i]);
                            }
                        }
                        else { 
                            return nths.ToArray();
                        }


                          return nths.ToArray(); */
            List<double> nths = new List<double>();
            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nths.ToArray();
            }

            for (int i = n - 1; i < elements.Count; i += n) {
                nths.Add(elements[i]);
            }
            return nths.ToArray();
        }
    }
}
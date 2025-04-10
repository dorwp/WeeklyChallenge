using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            string keyWord = word;
            foreach (var wordItem in words)
            {
                if (wordItem == null)
                {
                    continue;
                }
                if (ignoreCase == true)
                {
                    if (wordItem.ToLower() == keyWord)
                    {
                        return true;
                    }
                }
                if (ignoreCase == false)
                {
                    if (wordItem == keyWord)
                    {
                        return true;
                    } 
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num > 1)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
            }
            else if (num <= 1)
            {
                return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null)
            {
                return -1;
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char current = str[i];
                bool isUnique = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j && str[j] == current)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int maxCount = 1;
            int currentCount = 1;
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        { 
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            if (n < 0)
            {
                return new double[0];
            }
            List<double> everyN = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0)
                {
                    everyN.Add(elements[i]);
                }
            }
            return everyN.ToArray();        }
    }
}

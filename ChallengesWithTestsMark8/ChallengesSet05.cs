using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber;
            do
            {
                 nextNumber++;
            }
            while((nextNumber % n)!= 0);
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                if (numbers[i-1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";
    
            for (int i = 0; i < words.Length; i++)
            {
                string tempWord = words[i];
                string tempSentence = "";

                foreach (char c in tempWord)
                {
                    if (c != ' ')
                    {
                        tempSentence += c;
                    }
                }

                if (!string.IsNullOrEmpty(tempSentence))
                {
                    if (!string.IsNullOrEmpty(sentence)) 
                    {
                        sentence += " ";
                    }
                    sentence += tempSentence;
                }
            }

            if (!string.IsNullOrEmpty(sentence))
            {
                sentence += ".";
            }

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> everyFourth = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % 4 == 0)
                {
                    everyFourth.Add(elements[i]);
                }
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int a = i + 1; a < nums.Length; a++)
                {
                    if (nums[i] + nums[a] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

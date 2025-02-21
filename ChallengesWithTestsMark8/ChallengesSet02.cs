using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
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
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() > 0)
            {
            
                double min = numbers.Min();
                double max = numbers.Max();
                return min + max;
            }
            else
            {
                return 0;
            }
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = numbers.Sum();
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int total = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
            }
            return total;
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = numbers.Sum();
            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if( number < 2)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}

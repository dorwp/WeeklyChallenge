using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }

                {

                }
            }

            int odds = oddNumbers.Sum();


            int total = evenNumbers.Sum();
            total -= odds;
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length == 0 || str2.Length == 0 || str3.Length == 0 || str4.Length == 0) return 0;

            int result = 1000000;

            if (str1.Length < result)
            {
                result = str1.Length;
            }

            if (str2.Length < result)
            {
                result = str2.Length;
            }

            if (str3.Length < result)
            {
                result = str3.Length;
            }

            if (str4.Length < result)
            {
                result = str4.Length;
            }


            return result;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = 100;
            if (smallest > number1)
            {
                smallest = number1;
            }

            if (smallest > number2)
            {
                smallest = number2;
            }

            if (smallest > number3)
            {
                smallest = number3;
            }

            if (smallest > number4)
            {
                smallest = number4;
            }

            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3)
            {
                return false;
            }

            else if (sideLength1 + sideLength3 <= sideLength2)
            {
                return false;
            }

            else if (sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }

            if (input.Length == 0)
            {
                return false;
            }

            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int length = (objs.Length) / 2;
            int nullCount = 0;
            foreach (var VARIABLE in objs)
            {
                if (VARIABLE == null)
                {
                    nullCount++;
                }
            }

            if (nullCount > length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double evens = 0;
            int evenCount = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens += number;
                    evenCount++;
                }
            }

            if (evenCount == 0)
            {
                return 0;
            }
            else
            {
                return evens / evenCount;
            }

        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Input must be non-negative");
            }
            
            int result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}


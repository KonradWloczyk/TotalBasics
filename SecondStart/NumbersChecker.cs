using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace SecondStart
{
    public class NumbersChecker
    {
        public int GetSumOfArrayElements(int[] array)
        {
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                sum += array[i];
            }
            return sum;
        }
        public int GetMultiplicationOfArrayElements(int[] array)
        {
            var multiplication = 1;
            for (int i = 0; i < array.Length; i++)
            {

                multiplication *= array[i];
            }
            return multiplication;
        }
        public int GetMinValue(int[] array)
        {
            var lowestFound = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < lowestFound)
                {
                    lowestFound = array[i];
                }
            }
            return lowestFound;

        }
        public int GetMaxValue(int[] array)
        {
            var highestFound = array[0];

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > highestFound)
                {
                    highestFound = array[i];
                }
            }
            return highestFound;
        }
        public List<int> GetPrimeNumbers(int[] array)
        {
            var arrayOfPrimeNumbers = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPrime(array[i]))
                {
                    arrayOfPrimeNumbers.Add(array[i]);
                }
            }
            return arrayOfPrimeNumbers;
        }

        public bool IsPrime(int numberToCheck)
        {
            for (int i = 2; i < numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> GetNumbersDivisibleByTwo(int[] array)
        {
            var arrayOfEvenNumbers = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arrayOfEvenNumbers.Add(array[i]);
                }
            }
            return arrayOfEvenNumbers;
        }


        public List<int> GetOddNumbers(int[] array)
        {
            var arrayOfOddNumbers = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    arrayOfOddNumbers.Add(array[i]);
                }
            }
            return arrayOfOddNumbers;
        }
    }
}

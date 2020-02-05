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
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        public int GetMultiplicationOfArrayElements(int[] array)
        {
            int multiplication = 1;
            for (int i = 0; i < array.Length; i++)
            {
                multiplication = multiplication * array[i];
            }
            return multiplication;
        }
        public int GetMinValue(int[] array)
        {
            int lowestFound = array[0];
          
            for (int x = 0; x < array.Length; x++)
            {

                if (array[x] < lowestFound)
                {
                    lowestFound = array[x];
                }
            }
            return lowestFound;

        }
        public int GetMaxValue(int[] array)
        {
            int highestFound = array[0];

            for (int x = 0; x < array.Length; x++)
            {

                if (array[x] > highestFound)
                {
                    highestFound = array[x];
                }
            }
            return highestFound;
        }
        public List<int> GetPrimeNumbers(int[] array)
        {
            List<int> arrayOfPrimeNumbers = new List<int>();
            for (int c = 0; c < array.Length; c++)
            {
                if (IsPrime(array[c]))
                {
                    arrayOfPrimeNumbers.Add(array[c]);
                }
            }
            return arrayOfPrimeNumbers;
        }

        public bool IsPrime(int numberToCheck)
        {
            int i;

            for (i = 2; i < numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public List<int> GetNumbersDivisibleBy2(int[] array)
        {
            List<int> ArrayOfEvenNumbers = new List<int>();
            int b = 2;

            for (int y = 0; y < array.Length; y++)
            {
                if (array[y] % b == 0)
                {
                    ArrayOfEvenNumbers.Add(array[y]);
                }
            }
            return ArrayOfEvenNumbers;
        }

        public List<int> GetOddNumbers(int[] array)
        {
            List<int> ArrayOfOddNumbers = new List<int>();
            int b = 2;

            for (int z = 0; z < array.Length; z++)
            {
                if (array[z] % b == 1)
                {
                    ArrayOfOddNumbers.Add(array[z]);
                }
            }
            return ArrayOfOddNumbers;
        }
    }
}

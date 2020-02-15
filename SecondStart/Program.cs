using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace SecondStart
{
    class Program
    {

        static void Main()
        {
            var generator = new DataGenerator();
            var randoms = generator.GetArrayWithRandomNumbers();
            Console.WriteLine("Wygenerowano tablicę");
            for (int i = 0; i < randoms.Length; i++)
            {
                Console.Write(randoms[i] + " ");
            }
            Console.WriteLine();

            var checker = new NumbersChecker();
            var sumOfArray = checker.GetSumOfArrayElements(randoms);
            Console.WriteLine("Suma elementów z tablicy: ");
            Console.WriteLine(sumOfArray);

            var multiplicationOfArray = checker.GetMultiplicationOfArrayElements(randoms);
            Console.WriteLine("Iloczyn elementów z tablicy: ");
            Console.WriteLine(multiplicationOfArray);

            var minOfArray = checker.GetMinValue(randoms);
            Console.WriteLine("Wartosc minimalna : ");
            Console.WriteLine(minOfArray);

            var maxOfArray = checker.GetMaxValue(randoms);
            Console.WriteLine("Wartosc maksymalna: ");
            Console.WriteLine(maxOfArray);

            var primeNumb = checker.GetPrimeNumbers(randoms);
            Console.WriteLine("Liczby pierwsze: ");
            for (int x = 0; x < primeNumb.Count; x++)
            {
                Console.WriteLine(primeNumb[x] + " ");
            }
            Console.WriteLine();

            var evenNumbers = checker.GetNumbersDivisibleByTwo(randoms);
            Console.WriteLine("Liczby parzyste: ");
            for (int y = 0; y < evenNumbers.Count; y++)
            {
                Console.WriteLine(evenNumbers[y] + " ");
            }
            Console.WriteLine();

            var oddNumbers = checker.GetOddNumbers(randoms);
            Console.WriteLine("Liczby nieparzyste: ");
            for (int z = 0; z < oddNumbers.Count; z++)
            {
                Console.WriteLine(oddNumbers[z] + " ");
            }

            Console.WriteLine();

            var arrayDetails = new ArrayDetails
            {
                Array = randoms,
                LowestFound = minOfArray,
                HighestFound = maxOfArray,
                Sum = sumOfArray,
                Multiplication = multiplicationOfArray,
                Prime = primeNumb,
                OddNumbers = oddNumbers,
                EvenNumbers = evenNumbers
            };

        }
    }
}



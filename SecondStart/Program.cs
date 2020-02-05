﻿using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace SecondStart
{
    class Program
    {

        static void Main()
        {
            DataGenerator generator = new DataGenerator();
            int[] randoms = generator.GetArrayWithRandomNumbers();
            Console.WriteLine("Wygenerowano tablicę");
            for (int i = 0; i < randoms.Length; i++)
            {
                Console.Write(randoms[i] + " ");
            }
            Console.WriteLine();

            NumbersChecker checker = new NumbersChecker();
            int sumOfArray = checker.GetSumOfArrayElements(randoms);
            Console.WriteLine("Suma elementów z tablicy: ");
            Console.WriteLine(sumOfArray);

            int multiplicationOfArray = checker.GetMultiplicationOfArrayElements(randoms);
            Console.WriteLine("Iloczyn elementów z tablicy: ");
            Console.WriteLine(multiplicationOfArray);

            int MinOfArray = checker.GetMinValue(randoms);
            Console.WriteLine("Wartosc minimalna : ");
            Console.WriteLine(MinOfArray);

            int MaxOfArray = checker.GetMaxValue(randoms);
            Console.WriteLine("Wartosc maksymalna: ");
            Console.WriteLine(MaxOfArray);

            List<int> PrimeNumb = checker.GetPrimeNumbers(randoms);
            Console.WriteLine("Liczby pierwsze: ");
            for (int x = 0; x < PrimeNumb.Count; x++)
            {
                Console.WriteLine(PrimeNumb[x] + " ");
            }
            Console.WriteLine();

            List<int> EvenNumbers = checker.GetNumbersDivisibleBy2(randoms);
            Console.WriteLine("Liczby parzyste: ");
            for (int y = 0; y < EvenNumbers.Count; y++)
            {
                Console.WriteLine(EvenNumbers[y] + " ");
            }
            Console.WriteLine();

            List<int> OddNumbers = checker.GetOddNumbers(randoms);
            Console.WriteLine("Liczby nieparzyste: ");
            for (int z = 0; z < OddNumbers.Count; z++)
            {
                Console.WriteLine(OddNumbers[z] + " ");
            }

            Console.WriteLine();

            ArrayDetails NewObject = new ArrayDetails();
            NewObject.Array = randoms;
            NewObject.LowestFound = MinOfArray;
            NewObject.HighestFound = MaxOfArray;
            NewObject.Sum = sumOfArray;
            NewObject.Multiplication = multiplicationOfArray;
            NewObject.Prime = PrimeNumb;
            NewObject.OddNumbers = OddNumbers;
            NewObject.EvenNumbers = EvenNumbers;
            // ttuaj w podobny sposon jak zrobilem wyzej
            //NewObject.Numbers = 

        }
    }
}



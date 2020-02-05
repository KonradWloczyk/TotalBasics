using System;
using System.Collections.Generic;
using System.Text;

namespace SecondStart
{
    public class DataGenerator
    {
        public int[] GetArrayWithRandomNumbers()
        {
            int[] array = new int[10];
            Random randomGenerator = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = randomGenerator.Next(1, 10);
            }
            return array;
        }
    }
}


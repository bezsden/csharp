using System;

namespace BubleSort
{
    class Program
    {
        static int[] intArray = new int[] { 22, 0, -1, -2, -3, 0, 3, 5, 7, 9, 10, 22, -55, -66 };
        static int transferVal;

        static void Main(string[] args)
        {
            int k = 0;
            while (k < intArray.Length)
            {
                k++;
                BubleSort();
            }
            Console.ReadLine();
        }
        private static void BubleSort()
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i + 2 > intArray.Length)
                {
                }
                else
                {
                    if (intArray[i] <= intArray[i + 1])
                    {
                    }
                    else
                    {
                        transferVal = intArray[i];
                        intArray[i] = intArray[i + 1];
                        intArray[i + 1] = transferVal;
                    }
                }
                PrintaArray(intArray);
            }
        }

        static void PrintaArray(int[] arr)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(" " + intArray[i]);
            }
            Console.WriteLine();
        }
    }
}

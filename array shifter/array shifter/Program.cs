using System;
using System.Collections.Generic;
namespace array_shifter
{
    class ArrayShifter
    {
        static void MoveTwoPosition(int[] arr)
        {
            int[] shifted = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 2)
                {
                    shifted[i] = arr[i + 2];
                }
                else
                {
                    shifted[i] = arr[i - (arr.Length - 2)];
                }
            }
            Console.WriteLine(string.Join(", ", shifted));
        } 

        static void MoveEvens(int[] arr)
        {
            int[] shifted = new int[arr.Length];
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            foreach(int number in arr)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }
            evens.CopyTo(shifted,0);
            odds.CopyTo(shifted, evens.Count);
            Console.WriteLine(string.Join(", ", shifted));
        }
        static void Main(string[] args)        
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MoveTwoPosition(x);
            MoveEvens(x);

        }
    }
}

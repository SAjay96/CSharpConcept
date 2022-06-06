using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class Selection
    {
        public static void Main()
        {
            int[] arr = { 29, 72, 98, 13, 87 };
            Console.WriteLine("Before Selection Sort\n");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[index])
                    {
                        index = j;//searching for lowest index  
                    }
                }
                int smallerNumber = arr[index];
                arr[index] = arr[i];
                arr[i] = smallerNumber;
            }

            Console.WriteLine("\nAfter Selection Sort\n");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }

        }
    }
}

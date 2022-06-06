using System;



    class Bubble
    {
    public static void Main()
    {
            int[] arr = new int[5] { 20, 30, 88, 14, 6 };
            int num = 5, temp;
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            for (int x = 0; x < num - 1; x++)
            {
                for (int y = 0; y < num - x - 1; y++)
                {
                    if (arr[y] > arr[y + 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }




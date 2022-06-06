
//class Rstar
//{
//    public static void Main(String[] args)
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            for (int j = 1; j <= i; j++)
//            {
//                Console.Write("* ");
//            }
//            Console.WriteLine();
//        }
 
//   }
//  }



    class Pyramid
    {

        static void Main(String[] args)
        {

        Console.WriteLine("Pyramid programm");
            for (int i = 1; i < 8; i++)
            {
                //for (int j = 5; j > 1; j--)
                //{
                //    Console.Write("  ");
                //}

                for (int j = 8; j >1; j--)
                {
                if (j>i)
                {
                   // Console.Write("*");
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" *");
                   // Console.Write(" ");

                }
                   
                }

                Console.WriteLine();

            }
        }
    }




























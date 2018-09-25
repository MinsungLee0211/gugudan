using System;

namespace gugudan
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i++);
            //}
            //for (int j = 0; j < 10; ++j)
            //{
            //    Console.WriteLine(j);
            //}
            //i = 0;
            //while (i == 2)
            //{
            //    Console.WriteLine(i);
            //}
            //i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //}
            //while (i == 2);
            //Console.ReadKey();

            //for (int i = 1; i < 10; ++i)
            //{
            //    for (int j = 1; j < 10; ++j)
            //    {
            //        Console.WriteLine(i + " x " + j + " = " + (j * i));
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for(; ; )
            //{
            //    try
            //    {
            //        int a = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(Power(2,a));

            //        if (a == 0)
            //        {
            //            break;
            //        }
            //    }

            //    catch
            //    {
            //        Console.WriteLine("에러발생");
            //        continue;
            //    }
            //}

            while(true)
            {
                Console.WriteLine("윗부분");

                break;

                Console.WriteLine("아랫부분");

            }
            Console.WriteLine("끝");
            Console.ReadKey();
        }

        static long Power(int a, int b)
        {
            long num = 1;
            for (int i = 0; i < b ; i++ )
            {
                num = num * a;
            }
            return num;
        }
    }
}

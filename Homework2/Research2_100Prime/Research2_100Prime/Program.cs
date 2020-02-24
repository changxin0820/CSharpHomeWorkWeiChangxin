using System;

namespace Research2_100Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            PrimeInt(100);
        }
        static void PrimeInt(int num)
        {
            Console.Write("2-{0}以内的素数有:\n{1} ", num, 2);
            for(int i = 3; i < num; i+=2)
            {
                bool a = true;
                for(int j = 3;j<i; j++)
                {
                    if (i % j==0)
                    {
                        a = false;
                        break;
                          
                    }

                }
                if (a)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}

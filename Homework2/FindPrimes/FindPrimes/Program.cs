using System;

namespace FindPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个大于0的整数：");
            String str = Console.ReadLine();
            int number = int.Parse(str);         
            // 除去所有 2 的倍数的因子
            Console.Write("输入数字的质数因子为：");
            while (number % 2 == 0)
            {
                Console.Write(2+"  ");
                number /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    Console.Write(i+"  ");
                    number /= i;
                }
            }           
            if (number > 2)
                Console.WriteLine(number);

        }
    }
}

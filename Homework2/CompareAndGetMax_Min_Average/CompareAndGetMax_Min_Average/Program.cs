using System;

namespace CompareAndGetMax_Min_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 13,14,15,16,17 };
            Compare(input,input.Length);
        }
        static void Compare(int[]Com,int length)
        {
            int Max = Com[0];
            int Min = Com[0];
            int Average = 0;
            for(int i = 1; i < length; i++)
            {
                if (Com[i]>Max)
                {
                    Max = Com[i];
                }else if (Com[i] < Min)
                {
                    Min = Com[i];
                }
                
            }
            int sum = 0;
            for (int j = 0; j < length; j++)
            {
              
                sum += Com[j];
              
            }
            Average = sum / length;
            Console.WriteLine("该数组最大值为：{0}\n最小值为：{1}\n平均值为：{2}", Max, Min, Average);


        }
    }
   
}

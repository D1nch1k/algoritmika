
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите количество солдат: ");
            long N = Convert.ToInt64(Console.ReadLine());
            long[] res = new long[N+1];
            for (int i=0; i<res.Length; i++)
            {
                if (i<3) res[i]=0;
                else if (i==3) res[i]=1;

                else
                {
                    long nechetg = (i+1)/2;
                    long chetg = i/2;
                    res[i] = res[nechetg] + res[chetg];
                }
   
            }
            System.Console.WriteLine(res[N]);
            
}}}
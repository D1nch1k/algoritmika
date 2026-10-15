using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = a; i <= b; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine($"{(double)sum/(b-a+1)}");

            //4
            //int n = 1;

            //for (int i = 3; i<=24; i += 3)
            //{
            //    n *= 2;
            //    Console.WriteLine($"Через {i} часов: {n}");
            //}
            //6
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int chet = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a % 2 == 0) chet += 1;
            //    sum+= a;
            //}
            //Console.WriteLine($"сумма: {sum} Четные: {chet}");

            //8
            //long z = 1;
            //for (int i = 2; i<=20; i += 2)
            //{
            //    z = z*i;
            //}
            //Console.WriteLine(z);

            //10
//             double x = Convert.ToDouble(Console.ReadLine());
//             double sum = 0.0;
//             for (int i = 1; i<=17; i += 2)
//             {
//                 sum += x / i;
//             }
//             Console.WriteLine(sum);

            
            double y = 1;
            for (int i = 1; i<=10; i++)
            {
                if (i % 2 == 0) y += Math.Pow(3, i);
                else y -= Math.Pow(3, i);
            }
            Console.WriteLine(y);

//             int n = Convert.ToInt32(Console.ReadLine());
//             int pred = 0;
//             int cnt = 0;
//             for (int i = 0; i < n; i++)
//             {
//                 int cur = Convert.ToInt32(Console.ReadLine());
//                 if (pred == 0) pred = cur;
//                 else if (pred > 0 && cur < 0 || pred < 0 && cur > 0) cnt++;
//             }
//             Console.WriteLine(cnt);
//             byte yyy = Convert.ToByte(Console.ReadLine());
        }
    }
}


using System;
using System.Globalization;
using System.Net.Sockets;
class Program 
{ 
static void Main() 
{ 
	
    //1
    // int sumsimple = 0;
    // int sumpos = 0;

    // while (true)
    //     {
    //         int n = Convert.ToInt32(Console.ReadLine());
    //         if (n==0) break;
    //         bool ttt = true;
    //         for (int i=2; i<Math.Abs(n); i++)
    //         {
    //             if (n%i==0)
    //             {
    //                 System.Console.WriteLine(5454544
    //                 );
    //                 ttt = false;
    //                 break;
    //             }
    //         }
    //         if (ttt==true) sumsimple+=n;
    //         string nstr = Convert.ToString(n);
    //         if (nstr.Contains('2') && n>0) sumpos++;
    //     }
    // System.Console.WriteLine($"простые: {sumsimple}, с цифрой 2 положительные: {sumpos}");

    //2
    // string? n = Console.ReadLine();
    // int prosv = 1;
    // foreach(Char s in n)
    //     {
    //         prosv *= s - '0';

    //     }
    //     System.Console.WriteLine(prosv);

    //3
    // int currow = 0;
    // int rownum = 1;
    // double maxnum = double.NegativeInfinity;
    // while (true)
    //     {
    //         currow++;
    //         int n = Convert.ToInt32(Console.ReadLine());
    //         if (n==0) break;
    //         if (n<0) {
    //             string nstr = Convert.ToString(Math.Abs(n));
    //             int nechet = 0;
    //             foreach (char i in nstr)
    //             {
    //                 if ((i-'0') % 2 != 0) nechet++;
    //             }
    //             if (nechet % 2 == 0 && nechet>0)
    //             {
    //                 rownum = currow;
    //                 if (maxnum < n) maxnum=n;
    //             }
    //         }
    //     }
    //     System.Console.WriteLine($"номер: {rownum} макс отрицательный элемент: {maxnum}");

    //4
    // int predpred = 0;
    // int pred = 0;
    // int res = 0;

    // while (true)
    //     {
    //         int cur = Convert.ToInt32(Console.ReadLine());
    //         if (predpred<pred && pred > cur) res++;
    //         predpred = pred;
    //         pred = cur;

    //         if (cur<0) break;
    //     }
    // System.Console.WriteLine(res);

    //5
    // int num = Convert.ToInt32(Console.ReadLine());
    // int sumres = 0;
    // int res2 = 0;
    // int i = 0;
    // while (num / (int)Math.Pow(10, i) > 0)
    //     {
    //         res2++;
    //         sumres += (num / (int)Math.Pow(10, i))% 10;
    //         i++;
    //     }
    // System.Console.WriteLine($"{res2} {sumres}");

    //6

    Console.Write("Введите x: ");
    double x = Convert.ToInt32(Console.ReadLine());

    double eps = 0.00001;
    double y = 1.0;        
    double term = 1.0;     
    int n = 0;

    while (Math.Abs(term) > eps)
    {
        n++;
        term *= x / n;     // a_n = a_{n-1} * x / n
        y += term;
    }

    double yExp = Math.Exp(x);

    Console.WriteLine($"Сумма ряда: {y:F10}");
    Console.WriteLine($"Math.Exp(x): {yExp:F10}");
    Console.WriteLine($"Разница:  {Math.Abs(y - yExp):E6}");


} 
}


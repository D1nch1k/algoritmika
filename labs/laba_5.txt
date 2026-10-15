using System;

class Task1
{
    static void Main()
    {
        // int[] a = new int[15];
        // Random rnd = new Random();
        // for (int i = 0; i < 15; i++)
        //     a[i] = rnd.Next(-10, 11);

        // int resotr = 0;
        // int podr = 0;
        // int res2 = 0;
        // bool curotr = false;
        // foreach (int num in a)
        // {
        //     if (num < 0)
        //     {
        //         resotr++;
        //         podr++;

        //     }
        //     else
        //     {
        //         if (podr > res2) res2=podr;
        //         podr = 0;
        //     }
        // }   
        // if (podr > res2) res2=podr;

        // foreach (var n in a) System.Console.Write(n + " ");
        // Console.WriteLine($"Отрицательных: {resotr}");
        // Console.WriteLine($"Макс. подряд отрицательных: {res2}");

        //4

        // Console.Write("Введите количество товаров: ");
        // int n = int.Parse(Console.ReadLine());
        // double[] price = new double[n];
        // Random rnd = new Random();
        // for (int i = 0; i < n; i++)
        //     price[i] = Math.Round(rnd.NextDouble() * 1000, 2);
        
        // Console.Write("Введите x: ");
        // double x = double.Parse(Console.ReadLine());

        
        // Console.WriteLine("Исходные цены: " + string.Join(" ", price));

        // for (int i = 0; i<price.Length; i++)
        // {
        //     if (price[i] < 3) price[i] = Math.Round(price[i]*0.97, 2);
        //     else price[i] = Math.Round(price[i]*0.97, 2);
        // }
        // System.Console.WriteLine("Новые цены: " + string.Join(" ", price));

        //6

        System.Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        int[] D = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < D.Length; i++)
            D[i] = rnd.Next(-10, 11);

        Console.WriteLine("Массив: " + string.Join(" ", D));
        int res = 0;
        for (int i = 0; i<D.Length; i++)
        {
            if (i % 2 == 1) res+=D[i];
        }
        System.Console.WriteLine("сумма: " + res);
    }
}

using System;
using System.Security.Cryptography;
namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        //#1
        //int K = Convert.ToInt16(Console.ReadLine());
        //int H = K / 3600;
        //int M = (K - H * 3600) / 60;
        //int S = (K - H * 3600 - M * 60);
        //Console.WriteLine($"{H} часов, {M} минут, {S} секунд");
        //#2
        //double a = Convert.ToDouble(Console.ReadLine());
        //double b = Convert.ToDouble(Console.ReadLine());
        //double h = Convert.ToDouble(Console.ReadLine());
        //double Trap = (a + b) / 2 * h;
        //double Kon = h/3 * (a + Math.Sqrt(b*a)+b);
        //Console.WriteLine($"трапеция: {Trap}, конус: {Kon}");
        //#3
        //double R = Convert.ToDouble(Console.ReadLine());
        //double V = 1.0*4 / 3 * (Math.PI * R * R * R);
        //double S = Math.PI * R * R;
        //Console.WriteLine($"Круг: {S}см2, Шар: {V}см3? отношение: "+1.0*V/S);
        //#4
        //double a = Convert.ToDouble(Console.ReadLine());
        //double b = Convert.ToDouble(Console.ReadLine());
        //double c = Convert.ToDouble(Console.ReadLine());
        //double ma = 0.5 * Math.Sqrt(2 * c * c + 2 * b * b - a * a);
        //double mb = 0.5 * Math.Sqrt(2 * c * c + 2 * a * a - b * b);
        //double mc = 0.5 * Math.Sqrt(2 * a * a + 2 * b * b - c * c);
        //Console.WriteLine($"{ma} {mb} {mc}");
        //#5
        //double r = Convert.ToDouble(Console.ReadLine());
        //double h = Convert.ToDouble(Console.ReadLine());
        //double S = Math.PI * r * (r + Math.Sqrt(r * r + h * h));
        //double V = 1.0 / 3 * Math.PI * r * r * h;
        //Console.WriteLine($"S: {S}, V: {V}");
        //#6
        //double r = Convert.ToDouble(Console.ReadLine());
        //double V = 4.0 / 3 * Math.PI * r * r * r;
        //double S = 4 * Math.PI * r * r;
        //V = Math.Round(V, 3);
        //S = Math.Round(S, 3);
        //Console.WriteLine($"Объем: {V}, площадь: {S}");
        //#7
        //double x1 = Convert.ToDouble(Console.ReadLine());
        //double y1= Convert.ToDouble(Console.ReadLine());
        //double x2= Convert.ToDouble(Console.ReadLine());
        //double y2= Convert.ToDouble(Console.ReadLine());
        //double distance =Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //Console.WriteLine(distance);
        //#8
        //double x1 = Convert.ToDouble(Console.ReadLine());
        //double y1 = Convert.ToDouble(Console.ReadLine());
        //double c = x1 + y1;
        //double mod = Math.Abs(x1 - y1);
        //Console.WriteLine((mod+c)/2);
        //#9
        //double a = Convert.ToDouble(Console.ReadLine());
        //double b = Convert.ToDouble(Console.ReadLine());
        //a += b;
        //b = a - b;
        //a -= b;
        //Console.WriteLine($"{a}, {b}");
        //#10
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());
        //double sred = Math.Round((double)((a + b + c) / 3), 2);
        //Console.WriteLine(sred);
        //#11
        //double a = Convert.ToDouble(Console.ReadLine());
        //double b = Convert.ToDouble(Console.ReadLine());
        //double c = Convert.ToDouble(Console.ReadLine());
        //double sum = a + b + c;
        //a -= a * 0.13;
        //b -= b * 0.13;
        //c -= c * 0.13;
        //double posleskid = c + b + a;
        //Console.WriteLine(Math.Round(sum - posleskid, 1));
        //#12
        //int k = Convert.ToInt32(Console.ReadLine());
        //int a, b, c;
        //a = k / 100;
        //b = k / 10 % 10;
        //c = k % 10;
        //Console.WriteLine(a+b+c);
        //#13
        //double a = Convert.ToDouble(Console.ReadLine());
        //double b = Convert.ToDouble(Console.ReadLine());
        //double c = Math.Sqrt(a * a + b * b);
        //Console.WriteLine(Math.Round(c, 5));
    }
}

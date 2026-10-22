using System;

namespace MiniTasks;

class Program
{
    static void Main()
    {
        Console.Write("Номер задачи (1-13): ");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 1: Task1.Run(); break;
            case 2: Task2.Run(); break;
            case 3: Task3.Run(); break;
            case 4: Task4.Run(); break;
            case 5: Task5.Run(); break;
            case 6: Task6.Run(); break;
            case 7: Task7.Run(); break;
            case 8: Task8.Run(); break;
            case 9: Task9.Run(); break;
            case 10: Task10.Run(); break;
            case 11: Task11.Run(); break;
            case 12: Task12.Run(); break;
            case 13: Task13.Run(); break;
            default: Console.WriteLine("Нет такой задачи"); break;
        }
    }
}

// #1 Секунды -> часы, минуты, секунды
class Task1
{
    public static void Run()
    {
        int k = Convert.ToInt32(Console.ReadLine());
        int h = k / 3600;
        int m = k % 3600 / 60;
        int s = k % 60;
        Console.WriteLine($"{h} часов, {m} минут, {s} секунд");
    }
}

// #2 Площадь трапеции и объём усечённого конуса
class Task2
{
    public static void Run()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());
        double trapezoid = (a + b) / 2 * h;
        double cone = h / 3 * (a + Math.Sqrt(a * b) + b);
        Console.WriteLine($"трапеция: {trapezoid}, конус: {cone}");
    }
}

// #3 Площадь круга, объём шара и их отношение
class Task3
{
    public static void Run()
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double circle = Math.PI * r * r;
        double sphere = 4.0 / 3 * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Круг: {circle} см², шар: {sphere} см³, отношение: {sphere / circle}");
    }
}

// #4 Медианы треугольника
class Task4
{
    public static void Run()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{Median(a, b, c)} {Median(b, a, c)} {Median(c, a, b)}");
    }

    // Медиана к стороне side; other1, other2 — две другие стороны
    static double Median(double side, double other1, double other2) =>
        0.5 * Math.Sqrt(2 * other1 * other1 + 2 * other2 * other2 - side * side);
}

// #5 Площадь поверхности и объём конуса
class Task5
{
    public static void Run()
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());
        double l = Math.Sqrt(r * r + h * h); // образующая
        double s = Math.PI * r * (r + l);
        double v = Math.PI * r * r * h / 3;
        Console.WriteLine($"S: {s}, V: {v}");
    }
}

// #6 Объём и площадь шара (до 3 знаков)
class Task6
{
    public static void Run()
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double v = 4.0 / 3 * Math.PI * Math.Pow(r, 3);
        double s = 4 * Math.PI * r * r;
        Console.WriteLine($"Объем: {v:F3}, площадь: {s:F3}");
    }
}

// #7 Расстояние между точками
class Task7
{
    public static void Run()
    {
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
    }
}

// #8 Максимум из двух без if: (x + y + |x - y|) / 2
class Task8
{
    public static void Run()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine((x + y + Math.Abs(x - y)) / 2);
    }
}

// #9 Обмен значений без третьей переменной
class Task9
{
    public static void Run()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        a += b;
        b = a - b;
        a -= b;
        Console.WriteLine($"{a}, {b}");
    }
}

// #10 Среднее трёх чисел
class Task10
{
    public static void Run()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        double avg = (a + b + c) / 3.0; // 3.0, иначе целочисленное деление
        Console.WriteLine(Math.Round(avg, 2));
    }
}

// #11 Сколько сэкономили со скидкой 13%
class Task11
{
    public static void Run()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine(Math.Round(sum * 0.13, 1));
    }
}

// #12 Сумма цифр числа
class Task12
{
    public static void Run()
    {
        int k = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        int sum = 0;
        while (k > 0)
        {
            sum += k % 10;
            k /= 10;
        }
        Console.WriteLine(sum);
    }
}

// #13 Гипотенуза
class Task13
{
    public static void Run()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Round(Math.Sqrt(a * a + b * b), 5));
    }
}
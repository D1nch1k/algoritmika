class Program
{
    static void Main(string[] args)
    {
        // #1
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        if (a>=1 && a <= 3)
        {
            System.Console.WriteLine(a);
        }
        if (b>=1 && b <= 3)
        {
            System.Console.WriteLine(b);
        }
        if (c>=1 && c <= 3)
        {
            System.Console.WriteLine(c);
        }
        // #2
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        if (a<=b && a<=c) System.Console.WriteLine(a);
        else if (b<=a && b<=c) System.Console.WriteLine(b);
        else System.Console.WriteLine(c);
        // #3
        int year = Convert.ToInt32(Console.ReadLine());
        if (year % 4 == 0 && year%100!=0 || year%400==0) System.Console.WriteLine(366);
        else System.Console.WriteLine(365);
        // #4
        double price = Convert.ToDouble(Console.ReadLine());
        if (price > 500) System.Console.WriteLine(price*0.97);
        else if (price > 1000) System.Console.WriteLine(price*0.95);
        // #5
        int numberOfMonth = Convert.ToInt32(Console.ReadLine());
        switch (numberOfMonth)
        {
            case 1: 
                System.Console.WriteLine("Январь");
                break;
            case 2: System.Console.WriteLine("Февраль");
            break;
            case 3: System.Console.WriteLine("Март");
            break;
            case 4: System.Console.WriteLine("Апрель");
            break;
            case 5: System.Console.WriteLine("Май");
            break;
            case 6: System.Console.WriteLine("Июнь");
            break;
            case 7: System.Console.WriteLine("Июль");
            break;
            case 8: System.Console.WriteLine("Август");
            break;
            case 9: System.Console.WriteLine("Сентябрь");
            break;
            case 10: System.Console.WriteLine("Октябрь");
            break;
            case 11: System.Console.WriteLine("Ноябрь");
            break;
            case 12: System.Console.WriteLine("Декабрь");
            break;
            default:
            System.Console.WriteLine("Введен некорректный месяц");
            break;
        }
        // #6
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int cnt = 0;
        if (a>=0) cnt++;
        if (b>=0) cnt++;
        if (c>=0) cnt++;
        Console.WriteLine(cnt);
        //#7
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        if (x>0&&y>0) System.Console.WriteLine("1 четверть");
        else if (x<0 && y>0) System.Console.WriteLine("2 четверть");
        else if (x<0 && y<0) System.Console.WriteLine("3 четверть");
        else if (x>0 && y<0) System.Console.WriteLine("4 четверть");
        else if (x==0 && y==0) System.Console.WriteLine("В точке начала координат");
        else if (x==0) System.Console.WriteLine("На оси Y");
        else System.Console.WriteLine("На оси X");
        // //#8
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 0: System.Console.WriteLine("Ноль");
            break;
            case 1: System.Console.WriteLine("Один");
            break;
            case 2: System.Console.WriteLine("Два");
            break;
            case 3: System.Console.WriteLine("Три");
            break;
            case 4: System.Console.WriteLine("Четыре");
            break;
            case 5: System.Console.WriteLine("Пять");
            break;
            case 6: System.Console.WriteLine("Шесть");
            break;
            case 7: System.Console.WriteLine("Семь");
            break;
            case 8: System.Console.WriteLine("Восемь");
            break;
            case 9: System.Console.WriteLine("Девять");
            break;
            default: System.Console.WriteLine("Введена не цифра");
            break;
        }
        //#9
        int day = Convert.ToInt32(Console.ReadLine());
        int res = day%7;
        switch (res)
        {
            case 1: System.Console.WriteLine("Понедельник");
            break;
            case 2: System.Console.WriteLine("Вторник");
            break;
            case 3: System.Console.WriteLine("Среда");
            break;
            case 4: System.Console.WriteLine("Четверг");
            break;
            case 5: System.Console.WriteLine("Пятница");
            break;
            case 6: System.Console.WriteLine("Суббота");
            break;
            case 0: System.Console.WriteLine("Воскресенье");
            break;
        }
        //#10
        int n = Convert.ToInt32(Console.ReadLine());
        double r = Convert.ToDouble(Console.ReadLine());
        switch (n)
        {
            case 1: System.Console.WriteLine(Math.PI*r*r);
            break;
            case 2: System.Console.WriteLine(4.0/3*Math.PI*r*r*r);
            break;
            case 3: double h = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine(Math.PI*r*r*h);
            break;
            case 4: System.Console.WriteLine(4*Math.PI*r*r);
            break;
        }
        //#11
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1: System.Console.WriteLine("Введите длины сторон");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine(a*b);
            break;
            case 2: System.Console.WriteLine("Введите длину стороны и высоту");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double h2 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine(a2*h2);
            break;
            case 3: System.Console.WriteLine("Введите длины сторон и высоту");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double b3 = Convert.ToDouble(Console.ReadLine());
            double h3 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine((a3+b3)*h3);
            break;

        //12
        int num = Convert.ToInt32(Console.ReadLine());
        int ost = num%5;
        switch (ost)
        {
            case 0: System.Console.WriteLine("Ноль");
            break;
            case 1: System.Console.WriteLine("Один");
            break;
            case 2: System.Console.WriteLine("Два");
            break;
            case 3: System.Console.WriteLine("Три");
            break;
            case 4: System.Console.WriteLine("Четыре");
            break;
        }

        //#13
        
        double expr1 = 2 * Math.Pow(10 + Math.Pow(10, 1.0/10.0), 1.0/10.0) + 2 * Math.Pow(10, -3);
        System.Console.WriteLine($"expr1 = {expr1}");
        double expr2 = Math.PI/12 + Math.Asin(Math.Sqrt(3)/2);
        System.Console.WriteLine($"expr2 = {expr2}");

        double func;
        if (1.0/expr1 > expr2)
        {
            func = Math.Acos((expr1-expr2)/(1 + expr1 * Math.Sin(expr2)));
        }
        else
        {
            func = (Math.Sin(expr2))/(expr1 * Math.Sqrt(expr1)) + Math.Pow(Math.E, Math.Pow(expr1, 2)-1);
        }
        System.Console.WriteLine($"func = {func}");

        //14
        double p = Math.Pow(Math.E, Math.Pow(Math.Sin(2.0/3.0), 3)) + Math.Log(Math.Atan(2.0/3.0));
        System.Console.WriteLine($"p = {p}");

        double q = 7.5 * Math.Pow(Math.Pow(2.8, 1.0/3.0), -8) - Math.Log10(1.6 * Math.Pow(1.2, 1.0/3.0));
        System.Console.WriteLine($"q = {q}");

        double u, f;
        
        if (Math.Pow(p, 2) > q)
        {
            u = Math.Pow(Math.Pow(p, 2) - q, 1.0/5.0);
            f = Math.Sin(Math.Pow(p, 2));
        }
        else
        {
            u = 2 * Math.Asin(Math.Pow(p, 2) / q);
            f = Math.Sin(q);
        }
        
        System.Console.WriteLine($"u = {u}");
        System.Console.WriteLine($"f = {f}");


        //15

        System.Console.Write("Введите x: ");
        double x = Convert.ToDouble(System.Console.ReadLine());
        
        System.Console.Write("Введите y: ");
        double y = Convert.ToDouble(System.Console.ReadLine());

        System.Console.Write("Введите z: "); // z нужен для формул u и v
        double z = Convert.ToDouble(System.Console.ReadLine());

        double u = Math.Cos(Math.Abs(x + Math.Pow(Math.Abs(y), 1.0/3.0))) 
                 + Math.Sin(z - Math.Pow(x, 10) / (1 + Math.Pow(y, 2) + Math.Pow(z, 2)));
        System.Console.WriteLine($"u = {u}");

        double v = Math.Pow(Math.E, -Math.Pow(x, 2)) 
                 + Math.Pow(Math.Abs(x + y + z), 1.0/7.0) 
                 + Math.Pow(Math.E, y);
        System.Console.WriteLine($"v = {v}");

        double t;
        if (Math.Pow(u, 2) + Math.Pow(v, 2) >= 5)
        {
            t = Math.Log(v, 2) + Math.Pow(u, 2) + Math.Pow(5, 1.0/5.0);
        }
        else
        {
            t = Math.Log(v) + Math.Pow(u, 2.0/3.0) + Math.Sin(Math.Sqrt(5));
        }
        
        System.Console.WriteLine($"t = {t}");

        //16
        System.Console.Write("Введите x: ");
        double x = Convert.ToDouble(System.Console.ReadLine());
        
        System.Console.Write("Введите y: ");
        double y = Convert.ToDouble(System.Console.ReadLine());

        double f;
        if (Math.Abs(x) >= Math.Abs(y))
        {
            f = Math.Log(Math.Abs(x + y)) / (Math.Log(Math.Abs(x)) + Math.Log(Math.Abs(y))) 
                - Math.Sin(Math.Pow(Math.Pow(x, 8) + Math.Pow(y, 4), 1.0/5.0));
        }
        else
        {
            f = Math.Asin(Math.Abs(x) / Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) 
                + Math.Pow(Math.E, Math.Cos(Math.Sqrt(Math.Abs(x + y))));
        }

        double u;
        if (Math.Pow(x, 8) + Math.Pow(y, 8) >= 12)
        {
            u = Math.Sin(Math.Abs(x - y / (Math.Pow(x, 8) + Math.Pow(y, 8))));
        }
        else
        {
            u = Math.Cos(Math.Abs(x - y / (Math.Pow(x, 8) + Math.Pow(y, 8))));
        }

        System.Console.WriteLine($"f = {f}");
        System.Console.WriteLine($"u = {u}");

    }
}
}

using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static long CountGroups(long n)
        {   
            //базовые случаи
            if (n<3) return 0;
            if (n==3) return 1;

            //делим группу на 2
            long nechetg = (n+1)/2;
            long chetg = n/2;

            //рекурсия
            return CountGroups(nechetg) + CountGroups(chetg);

        }
        static void Main(string[] args)
        {
            
            Console.Write("Введите количество солдат: ");
            long N = Convert.ToInt64(Console.ReadLine());

            long res = CountGroups(N);
            System.Console.WriteLine(res);
            


}}}
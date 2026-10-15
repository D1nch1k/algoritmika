using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resfirm = 0;
            double resprice = 1000000000000000000.1;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Trim().Split(' ');


                double x1 = Convert.ToDouble(data[0]);
                double y1 = Convert.ToDouble(data[1]);
                double z1 = Convert.ToDouble(data[2]);
                double x2 = Convert.ToDouble(data[3]);
                double y2 = Convert.ToDouble(data[4]);
                double z2 = Convert.ToDouble(data[5]);
                double c1 = Convert.ToDouble(data[6]);
                double c2 = Convert.ToDouble(data[7]);

                double V1 = x1*y1*z1;
                double V2 = x2 * y2 * z2;
                double S1 = 2 * (x1 * y1 + x1 * z1 + y1 * z1);
                double S2 = 2* (x2 * y2 + x2 * z2 + y2 * z2);

                double s, m;

                m = (c2 * S1 - c1 * S2)/(S1*V2 - S2*V1);
                m = m * 1000;

                if (resprice > m)
                {
                    resfirm = i + 1;
                    resprice = m;
                }
            }
            
            Console.WriteLine($"{resfirm} {Math.Round(resprice, 2)}");

        }
    }
}


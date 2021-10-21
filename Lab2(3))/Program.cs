using System;

namespace Lab2_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 1,2 или 3!");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите x");
                double x = double.Parse(Console.ReadLine());
                double a = 0, b = 0, z, y = 0;
                switch (n)
                {
                    case 1: a = 6; b = 3.2; break;
                    case 2: a = 3; b = 6; break;
                    case 3: a = 2.7; b = 1.8; break;
                }
                z = Math.Exp(1.5 * a * x);
                if (x < -Math.Log(Math.Abs(a))) y = Math.Pow(3.5 * a - 7.3 * b * x + Math.Sin(z * x), 3);
                else if (-Math.Log(Math.Abs(a)) <= x && x < b) y = Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
                else if (x > b) y = Math.Sqrt(Math.Abs(Math.Tan(a - x))) - Math.Pow(x, 2);
                Console.WriteLine($"y={y:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;
class Program
{
    static void Main(string[] args)
    {
        double a = 1;
        double b = 2;
        double e = 0.001;

        while ((b - a) > 2 * e)
        {
            double c = (a + b) / 2;

            if (Function(a) * Function(c) < 0)
            {
                b = c;

            }
            else
            {
                a = c;
            }
        }
        double x = (a + b) / 2;
        Console.WriteLine(Math.Round(x, 3));
    }

    public static double Function(double x)
    {

        return x* Math.Sin(x) - 1;
    }

    
}
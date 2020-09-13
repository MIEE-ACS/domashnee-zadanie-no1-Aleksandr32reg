using System;

class Program
{
    static void Main()
    {
        double[] x = new double[2];
        double[] y = new double[2];

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Координата {0}-ой точки прямоугольника:", i + 1);
            Console.Write("X = ");

            string inputX = Console.ReadLine();            
            bool resultX = double.TryParse(inputX, out _);

            if (resultX)
            {
                x[i] = double.Parse(inputX);
            }

            else
            {
                Console.WriteLine("Преобразование невозможно");
                Environment.Exit(0);
            }

            Console.Write("Y = ");

            string inputY = Console.ReadLine();
            bool resultY = double.TryParse(inputY, out _);

            if (resultY)
            {
                y[i] = double.Parse(inputY);
            }

            else
            {
                Console.WriteLine("Преобразование невозможно");
                Environment.Exit(0);
            }
        }
        

        if (x[1] != x[0] && y[1] != y[0])
        {
            double a = GetSide(x[0], y[0], x[0], y[1]);
            double b = GetSide(x[0], y[1], x[1], y[1]);

            Console.WriteLine("Стороны прямоуголника");
            Console.WriteLine("a = {0}", Math.Round(a, 3));
            Console.WriteLine("b = {0}", Math.Round(b, 3));

            double p = (a + b) * 2;
            Console.WriteLine("Периметр");
            Console.WriteLine("P = {0}", Math.Round(p, 3));

            double s = a * b;
            Console.WriteLine("Площадь");
            Console.WriteLine("S = {0}", Math.Round(s, 3));
            
        }

        else
        {
            Console.WriteLine("Невозможные координаты");
            Environment.Exit(0);
        }
            
    }

    static double GetSide(double x1, double y1, double x2, double y2)
    {
        return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
    }
}
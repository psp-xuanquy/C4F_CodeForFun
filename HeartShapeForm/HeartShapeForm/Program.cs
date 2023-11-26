using System;


class HeartShape
{
    static void Main(string[] args)
    {
        for (double y = 1.5; y > -1.5; y -= 0.1)
        {
            for (double x = -1.5; x < 1.5; x += 0.05)
            {
                double a = x * x + y * y - 1;
                Console.Write(a * a * a - x * x * y * y * y <= 0 ? "Q" : ".");
            }
            Console.WriteLine();
        }
    }
}

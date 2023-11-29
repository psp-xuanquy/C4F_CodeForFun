using System;

class Program
{
    static void Main()
    {
        DisplayXuanQuyPattern();
    }

    static void DisplayXuanQuyPattern()
    {
        Console.Write("\n\n");
        Console.Write("------------------------------------------------------DAO XUAN QUY------------------------------------------------------");
        Console.Write("\n\n");
        string[] patternLines = {

            "        U       U     A A A A     NN       N     Q Q Q Q Q     U       U   Y       Y ",
            "        U       U     A     A     N N      N     Q       Q     U       U    Y     Y ",
            "X       U       U     A     A     N  N     N     Q       Q     U       U     Y   Y  ",
            " X      U       U     A     A     N   N    N     Q       Q     U       U      Y Y   ",
            "  X     U       U     A A A A     N    N   N     Q       Q     U       U       Y    ",
            "   X    U       U     A     A     N     N  N     Q       Q     U       U       Y    ",
            "  X     U       U     A     A     N      N N     Q       Q     U       U       Y    ",
            " X      U U U U U     A     A     N       NN     Q Q Q Q Q     U U U U U       Y    ",
            "                                                          Q                         "

        };

        for (int i = 0; i < patternLines.Length; i++)
        {
            for (int j = 0; j < patternLines[i].Length; j++)
            {
                Console.Write(patternLines[i][j]);
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine();
        }
    }
}

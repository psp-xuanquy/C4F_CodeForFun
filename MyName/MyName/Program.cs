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
        Console.Write("\n\n");
        string[] patternLines = {

            " D D D D      A A A A    O O O O O          X       X    U       U     A A A A     N       N          Q Q Q Q Q     U       U   Y       Y ",
            " D      D     A     A    O       O           X     X     U       U     A     A     NN      N          Q       Q     U       U    Y     Y  ",
            " D       D    A     A    O       O            X   X      U       U     A     A     N N     N          Q       Q     U       U     Y   Y   ",
            " D       D    A     A    O       O             X X       U       U     A     A     N  N    N          Q       Q     U       U      Y Y    ",
            " D       D    A A A A    O       O              X        U       U     A A A A     N   N   N          Q       Q     U       U       Y     ",
            " D       D    A     A    O       O             X X       U       U     A     A     N    N  N          Q       Q     U       U       Y     ",
            " D       D    A     A    O       O            X   X      U       U     A     A     N     N N          Q       Q     U       U       Y     ",
            " D      D     A     A    O       O           X     X     U       U     A     A     N      NN          Q       Q     U       U       Y     ",
            " D D D D      A     A    O O O O O          X       X    U U U U U     A     A     N       N          Q Q Q Q Q     U U U U U       Y     ",
            "                                                                                                               Q                          "

        };

        for (int i = 0; i < patternLines.Length; i++)
        {
            Console.WriteLine(patternLines[i]);
        }
    }
}

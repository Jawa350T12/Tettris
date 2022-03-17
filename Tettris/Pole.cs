using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tettris
{
    internal class Pole
    {
        public static void GameWindow()//Размер окна
        {
            Console.BufferWidth = 120;
            Console.WindowWidth = 120;
            Console.BufferHeight = 60;
            Console.WindowHeight = 60;
            Console.Title = "Tetris";
        }

        public static void HorizontBarrier(char C, int x, int y, int L)//Горезантальная граница
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < L; i++)
            {
                Console.SetCursorPosition(x + i, y);
                Console.Write(C);
            }
        }

        public static void VertikalBarrier(char C, int x, int y, int L)//Вертикальная граница
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < L; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(C);
            }

        }
        /*
        Rama.Horizont('═', 2, 1, 55);
        Rama.Vertikal('║', 1, 2, 50);
        Rama.Vertikal('║', 56, 2, 50);
        Rama.Horizont('═', 2, 51, 55);
        Rama.Horizont('╔', 1, 1, 1);
        Rama.Horizont('╚', 1, 51, 1);
        Rama.Horizont('╗', 56, 1, 1);
        Rama.Horizont('╝', 56, 51, 1);

        Rama.Horizont('═', 62, 1, 55);
        Rama.Vertikal('║', 61, 2, 50);
        Rama.Vertikal('║', 116, 2, 50);
        Rama.Horizont('═', 62, 51, 55);
        Rama.Horizont('╔', 61, 1, 1);
        Rama.Horizont('╚', 61, 51, 1);
        Rama.Horizont('╗', 116, 1, 1);
        Rama.Horizont('╝', 116, 51, 1);
        */
    }
}

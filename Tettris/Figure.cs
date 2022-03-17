using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tettris
{
    public class Figure
    {
        public static void Cub(int SpawnX,int SpawnY)//Отрисовка куба
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(SpawnX, SpawnY);
            Console.WriteLine("XX","\n");
            Console.SetCursorPosition(SpawnX, SpawnY-1);
            Console.WriteLine("XX","\n");
        }

        public static void Stick(int SpawnX, int SpawnY)//Отрисовка палки
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(SpawnX, SpawnY);
            Console.WriteLine("XXXX", "\n");
        }

        public static void NedoT(int SpawnX, int SpawnY)//Отрисовка Недо T
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(SpawnX, SpawnY);
            Console.WriteLine("X", "\n");
            Console.SetCursorPosition(SpawnX-1, SpawnY - 1);
            Console.WriteLine("XXX", "\n");
        }

        public static void GR(int SpawnX, int SpawnY)//Отрисовка Г правая
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(SpawnX, SpawnY);
            Console.WriteLine("X", "\n");
            Console.SetCursorPosition(SpawnX, SpawnY-1);
            Console.WriteLine("XXX", "\n");
        }

        public static void GL(int SpawnX, int SpawnY)//Отрисовка Г левая
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(SpawnX+2, SpawnY);
            Console.WriteLine("X", "\n");
            Console.SetCursorPosition(SpawnX, SpawnY-1);
            Console.WriteLine("XXX", "\n");
        }

        public static void ZL(int SpawnX, int SpawnY)//Отрисовка Z левая
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(SpawnX, SpawnY);
            Console.WriteLine("XX", "\n");
            Console.SetCursorPosition(SpawnX+1, SpawnY-1);
            Console.WriteLine("XX", "\n");
        }

        public static void ZR(int SpawnX, int SpawnY)//Отрисовка Z правая
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(SpawnX, SpawnY);
            Console.WriteLine("XX", "\n");
            Console.SetCursorPosition(SpawnX -1, SpawnY - 1);
            Console.WriteLine("XX", "\n");
        }
    }
}

using System;
using System.Threading;

namespace Tettris
{
    public class Program
    {
        static int xx=0;
        static String ss="";
        static int yy = 3;

        static void GamePole()// Отрисовка игрового поля
        {
            Pole.GameWindow();
            Pole.HorizontBarrier('═', 2, 1, 55);
            Pole.VertikalBarrier('║', 1, 2, 50);
            Pole.VertikalBarrier('║', 56, 2, 50);
            Pole.HorizontBarrier('═', 2, 51, 55);
            Pole.HorizontBarrier('╔', 1, 1, 1);
            Pole.HorizontBarrier('╚', 1, 51, 1);
            Pole.HorizontBarrier('╗', 56, 1, 1);
            Pole.HorizontBarrier('╝', 56, 51, 1);
        }

        static void RandomSpawn()//Случайная генерация фигур
        {
            xx = 0;
            ss = "";

            var rand = new Random();

            String[] s = { "Cub", "Stick", "NedoT", "GR", "GL", "ZR", "ZL" };
            
            switch (s[rand.Next(0, 7)])
            {
                case "Cub":
                    xx = rand.Next(3, 50);
                    ss = "Cub";
                    Figure.Cub(xx, 3);
                    break;

                case "Stick":
                    xx = rand.Next(3, 50);
                    ss = "Stick";
                    Figure.Stick(xx, 3);
                    break;

                case "NedoT":
                    xx = rand.Next(3, 50);
                    ss = "NedoT";
                    Figure.NedoT(xx, 3);
                    break;

                case "GR":
                    xx = rand.Next(3, 50);
                    ss = "GR";
                    Figure.GR(xx, 3);
                    break;

                case "GL":
                    xx = rand.Next(3, 50);
                    ss = "GL";
                    Figure.GL(xx, 3);
                    break;

                case "ZR":
                    xx = rand.Next(3, 50);
                    ss = "ZR";
                    Figure.ZR(xx, 3);
                    break;

                case "ZL":
                    xx = rand.Next(3, 50);
                    ss = "ZL";
                    Figure.ZL(xx, 3);
                    break;

            }
        }

        static void MoveFig(int x,String namefig)//Движение фигуры
        {
            
            Console.Clear();
            GamePole();
            switch (namefig)
            {
                case "Cub":
                    yy++;
                    Figure.Cub(xx, yy);
                    break;

                case "Stick":
                    yy++;
                    Figure.Stick(xx, yy);
                    break;

                case "NedoT":
                    yy++;
                    Figure.NedoT(xx, yy);
                    break;

                case "GR":
                    yy++;
                    Figure.GR(xx, yy);
                    break;

                case "GL":
                    yy++;
                    Figure.GL(xx, yy);
                    break;

                case "ZR":
                    yy++;
                    Figure.ZR(xx, yy);
                    break;

                case "ZL":
                    yy++;
                    Figure.Cub(xx, yy);
                    break;
            }
        }

        static void Main(string[] args)
        {
            GamePole();
            RandomSpawn();
            int c = 0;
            while (c < 47)
            {
                c++;
                MoveFig(xx, ss);
                Thread.Sleep(500);
            }
        }
    }
}
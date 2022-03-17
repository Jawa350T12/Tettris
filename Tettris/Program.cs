using System;

namespace Tettris
{
    public class Program
    {
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
            var rand = new Random();

            String[] s = { "Cub", "Stick", "NedoT", "GR", "GL", "ZR", "ZL" };
            
            switch (s[rand.Next(0, 7)])
            {
                case "Cub":
                    Figure.Cub(rand.Next(3,50), 3);
                    break;
                case "Stick":
                    Figure.Stick(rand.Next(3, 50), 3);
                    break;
                case "NedoT":
                    Figure.NedoT(rand.Next(3, 50), 3);
                    break;
                case "GR":
                    Figure.GR(rand.Next(3, 50), 3);
                    break;
                case "GL":
                    Figure.GL(rand.Next(3, 50), 3);
                    break;
                case "ZR":
                    Figure.ZR(rand.Next(3, 50), 3);
                    break;
                case "ZL":
                    Figure.ZL(rand.Next(3, 50), 3);
                    break;

            }
        }

        static void Main(string[] args)
        {
            GamePole();
            RandomSpawn();
        }
    }
}
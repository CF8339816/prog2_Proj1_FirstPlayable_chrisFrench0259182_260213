using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    class Program
    {
        static string player;
        static int p1_x_input;
        static int p1_y_input;
        static int p1_x_pos;
        static int p1_y_pos;

        static int p1_Old_X;
        static int p1_Old_Y;
        static string enemy;
        static int enemy_x_pos;
        static int enemy_y_pos;
        static int enemy_Old_X;
        static int enemy_Old_Y;

        static void Main(string[] args)
        {
            LoadMap map = new LoadMap();

            map.MapLoader();// use a loader to set the map to be used.

            while (isPlaying)
            {
                inCombat = false;
                CanMoveTo(mapXs, mapYs);
                DrawEnemy();
                //DrawEnemyAtCurrentPos();

                //if ((DateTime.Now - lastEnemyMoveTime).TotalMilliseconds >= enemyMoveSpeedMs)
                //{
                if (!inCombat)
                {
               
                    MoveEnemy();
                    //        lastEnemyMoveTime = DateTime.Now; // Reset the timer
                }
                //}
               
                DrawPlayer();
               

            }


        }







        static void DrawPlayer()
        {

            Player player = new Player(3, 3, 15, '@', 50, ConsoleColor.Blue); // sets player spawn and colouur            Console.SetCursorPosition(player.Position.x, player.Position.y);

            Console.ForegroundColor = player.Color;

            Console.Write("@");


            //Console.SetCursorPosition(player.Position._x, player.Position._y);

            //Console.ForegroundColor = player.Color;

            //Console.Write("@");


        }

        static void MovePlayer()
        {
            p1_x_input = 0;
            p1_y_input = 0;

            ConsoleKey input = Console.ReadKey(true).Key;

            if (input == ConsoleKey.A) p1_x_input = -1;
            if (input == ConsoleKey.D) p1_x_input = 1;
            if (input == ConsoleKey.W) p1_y_input = -1;
            if (input == ConsoleKey.S) p1_y_input = 1;


            int nextX = p1_x_pos + p1_x_input;
            int nextY = p1_y_pos + p1_y_input;

            if (_canMoveTo = true)
            {
                p1_Old_X = p1_x_pos;
                p1_Old_Y = p1_y_pos;
            }
            else
            {
                p1_x_input = 0;
                p1_y_input = 0;
            }

        }
    }



        public static void DrawEnemy()
        {

            Enemy enemy = new Enemy(3, 3, 15, '&', 50, ConsoleColor.Green);
            //Console.SetCursorPosition(enemy.Position.x, enemy.Position.y);

            Console.ForegroundColor = enemy.Color;

            Console.Write("&");



        }

        static void MoveEnemy()
        {

            if (p1_x_pos > enemy_x_pos)
            {
                enemy_x_pos++;
            }
            if (p1_x_pos < enemy_x_pos)
            {
                enemy_x_pos--;
            }
            if (p1_y_pos > enemy_y_pos)
            {
                enemy_y_pos++;
            }
            if (p1_y_pos < enemy_y_pos)
            {
                enemy_y_pos--;
            }
        }









    }
}

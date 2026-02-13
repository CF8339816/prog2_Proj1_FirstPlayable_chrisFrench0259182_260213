using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{

    class Program
    {
       
        static Player player = new Player(3, 3, 15, '!', 50, ConsoleColor.Blue);
        static Enemy enemy = new Enemy(50, 4, 10, '&', 25, ConsoleColor.Green);
        static LoadMap map = new LoadMap();
        static bool isPlaying = true;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            map.MapLoader(); 

            while (isPlaying)
            {
               
                MovePlayer();
                MoveEnemy();

                DrawEntities();
            }
        }

        static void MovePlayer()
        {
            if (!Console.KeyAvailable) return;

            int dx = 0, dy = 0;
            ConsoleKey input = Console.ReadKey(true).Key;

            if (input == ConsoleKey.A) dx = -1;
            if (input == ConsoleKey.D) dx = 1;
            if (input == ConsoleKey.W) dy = -1;
            if (input == ConsoleKey.S) dy = 1;

            int nextX = player._x + dx;
            int nextY = player._y + dy;

            if (map.CanMoveTo(nextX, nextY))
            {                
                Console.SetCursorPosition(player._x, player._y);
                
                char oldTile = map.Maps[player._y][player._x];
                WriteTileWithColor(oldTile);

             
                player._x = nextX;
                player._y = nextY;

              
                if (map.Maps[player._y][player._x] == '%')
                {
                    player._health -= 30;
                 
                    if (player._health <= 0) isPlaying = false;
                }
            }
        }

        static void WriteTileWithColor(char tile)
        {
            if (tile == '%') Console.ForegroundColor = ConsoleColor.Red;
            else if (tile == '#') Console.ForegroundColor = ConsoleColor.Gray;
            else Console.ForegroundColor = ConsoleColor.White;

            Console.Write(tile);
            Console.ResetColor();
        }

        static void MoveEnemy()
        {
            int nextX = enemy._x;
            int nextY = enemy._y;

          
            if (player._x > enemy._x) nextX++;
            else if (player._x < enemy._x) nextX--;
            if (player._y > enemy._y) nextY++;
            else if (player._y < enemy._y) nextY--;

            
            char targetTile = map.Maps[nextY][nextX];
            if (map.CanMoveTo(nextX, nextY) && targetTile != '%' && targetTile != '!')
            {
                Console.SetCursorPosition(enemy._x, enemy._y);
                Console.Write(" "); 

                enemy._x = nextX;
                enemy._y = nextY;
            }
        }

        static void DrawEntities()
        {
           
            Console.SetCursorPosition(enemy._x, enemy._y);
            Console.ForegroundColor = enemy._color;
            Console.Write(enemy._symbol);

           
            Console.SetCursorPosition(player._x, player._y);
            Console.ForegroundColor = player._color;
            Console.Write(player._symbol);

            Console.ResetColor();
        }
    }







   
}

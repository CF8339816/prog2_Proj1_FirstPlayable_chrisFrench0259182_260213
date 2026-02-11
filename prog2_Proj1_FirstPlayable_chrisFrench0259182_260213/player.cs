using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    public class Player : Character
    {
        static int p1_x_input;
        static int p1_y_input;
        static int p1_x_pos;
        static int p1_y_pos;
        static (int, int) p1_min_max_x = (1, 55);
        static (int, int) p1_min_max_y = (1, 29);
        static int p1_Old_X;
        static int p1_Old_Y;
        public void plSpawnLoc()
        { 
           base._x = 3;
          base._y = 3;
           base._symbol = "@";
        }
    

static void ProcessInput()
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

          if (_canMoveTo= true)
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
}

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
        
        public void plSpawnLoc()
        {
            base._x = 3;
            base._y = 3;
            base._symbol = '@';
            base._health = 50;
            base._attack = 15;
            base._color = ConsoleColor.Blue;
        }

        //public Player(Position position, ConsoleColor color)// established variables for  player locaTIUON AND COLOUR
        //{
        //    Position = position;
        //    Color = color;
        //    //Console.Write(" ");
        //}

    }


    //public struct Position
    //{
        

    //    public Position(int x, int y)// gets the player position
    //    {
    //        this._x = x;
    //        this._y = y;
    //    }


    }



}

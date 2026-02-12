using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    public class Enemy : Character
    {
        public int Xenemy;
        public int Yenemy;


        public void enlSpawnLoc()
        {
            base._x = Xenemy;
            base._y = Yenemy;
            base._symbol = '&';
            base._health = 25;
            base._attack = 10;
            base._color = ConsoleColor.Green;
        }


        Random xRanddo = new Random();

        Random yRanddo = new Random();

        Xenemy = xRanddo(4-50);
        Yenemy = yRanddo(2-29);


    }
}

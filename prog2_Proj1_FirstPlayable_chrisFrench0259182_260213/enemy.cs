using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{

    public class Enemy : Character
    {
       
        public Enemy(int x, int y, int attack, char symbol, int hp, ConsoleColor color)
            : base(x, y, attack, symbol, hp, color)
        {
        }

       
        private static Random enRando = new Random();

        public void RandomizeSpawn()
        {
            
            _x = enRando.Next(_min_max_x.Item1, _min_max_x.Item2 + 1);
            _y = enRando.Next(_min_max_y.Item1, _min_max_y.Item2 + 1);

            
            _health = 25;
            _attack = 10;
        }
    }





}

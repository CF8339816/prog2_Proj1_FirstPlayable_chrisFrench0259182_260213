using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    internal class Character
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; protected set; }
        public HealthSystem Health { get; }

        protected Character(int x, int y, char symbol, int hp)
        {
            X = x; Y = y; Symbol = symbol;
            Health = new HealthSystem(hp);
        }


    }
}

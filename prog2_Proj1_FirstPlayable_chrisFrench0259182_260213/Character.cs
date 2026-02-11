using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    public class Character
    {
        public int _x { get; set; }
        public int _y { get; set; }
        public int _attack { get; set; }
        public char _symbol { get; protected set; }
        public HealthSystem _health { get; }

        protected Character(int x, int y, char symbol, int hp)
        {
            _x = x; _y = y; _symbol = symbol;
            _health = new HealthSystem(hp);
        }


    }
}

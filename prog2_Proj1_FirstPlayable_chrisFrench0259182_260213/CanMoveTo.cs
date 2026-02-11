using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    internal class CanMoveTo : LoadMap
    {
        static bool _canMoveTo(int tarMapX, int tarMapY)
        {
            if (tarMapY >= 0 && tarMapY < Maps.Length && tarMapX >= 0 && tarMapX < Maps[tarMapY].Length)
            {
                char tarTile = Maps[tarMapY][tarMapX];

                switch (tarTile)
                {
                    case '#': //defines un traversable
                    case '|':
                    case '~':
                    case '+':



                        return false;

                    case ' ':  //verifies traversable
                    case '%':
                        return true;

                    default:
                        return true;
                }
            }
            return false;
        }
    }
}

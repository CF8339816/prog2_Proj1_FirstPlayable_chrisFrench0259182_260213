using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    public class HealthSystem
    {
        public int _currentHP { get; private set; }
        public bool _isDead => _currentHP <= 0;

        public HealthSystem(int maxHP) => _currentHP = maxHP;

        public void TakeDamage(int amount) => _currentHP -= amount;
    }


}


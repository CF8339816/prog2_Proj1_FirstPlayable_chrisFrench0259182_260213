using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Proj1_FirstPlayable_chrisFrench0259182_260213
{
    public class HealthSystem
    {
        public int _health { get; set; }
        public bool _isDead => _health <= 0;// defines dead state

        public HealthSystem(int maxHP) => _health = maxHP; // sets max health

        public void TakeDamage(int amount) =>  _health -= amount;// defines damage 
    }

    
}


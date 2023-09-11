using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerreiro.Classes
{
    internal class Weapon
    {
        private int damage;
        private static readonly int GOOD_GUY_DAMAGE = 40;
        private static readonly int BAD_GUY_DAMAGE = 50;

        public int Damage { get { return damage; } }

        public Weapon(Faction faction)
        {
            if (faction == Faction.goodGuy)
            {
                damage = GOOD_GUY_DAMAGE;
            }
            else if (faction == Faction.badGuy)
            {
                damage = BAD_GUY_DAMAGE;
            }
        }
    }
}

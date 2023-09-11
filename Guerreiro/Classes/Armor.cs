using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerreiro.Classes
{
    internal class Armor
    {
        private int armorPoints;
        private static readonly int GOOD_GUY_ARMOR = 50;
        private static readonly int BAD_GUY_ARMOR = 40;

        public int ArmorPoints { get { return armorPoints; } set { armorPoints = value; } }

        public Armor(Faction faction)
        {
            if (faction == Faction.goodGuy)
            {
                armorPoints = GOOD_GUY_ARMOR;
            }
            else if (faction == Faction.badGuy)
            {
                armorPoints = BAD_GUY_ARMOR;
            }
        }
    }
}

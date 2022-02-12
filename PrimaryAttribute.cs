using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public class PrimaryAttribute
    {
        public class Mage
        {
            protected double strenght = 1;
            protected double dexterity = 1;
            protected double intelligence = 8;
        }

        public class Ranger
        {
            protected double strenght = 1;
            protected double dexterity = 7;
            protected double intelligence = 1;
        }

        public class Rogue
        {
            protected double strenght = 2;
            protected double dexterity = 6;
            protected double intelligence = 1;
        }
        public class Warrior
        {
            protected double strenght = 5;
            protected double dexterity = 2;
            protected double intelligence = 1;
        }
    }
}

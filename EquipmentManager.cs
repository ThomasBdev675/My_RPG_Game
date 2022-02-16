using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{

    public class ArmorManager : PrimaryAttribute
    {
        public enum AvailableArmor
        {
            Cloth,
            Leather,
            Mail,
            Plate,
        }


        public class ArmorTypes : Item
        {
            public Enum MyArmor { get; set; }
        }
    }

    public class WeaponManager
    {
        public enum AvailableWeapons
        {
            Axes,
            Bows,
            Daggers,
            Hammers,
            Staffs,
            Swords,
            Wands,
        }

        public class WeaponTypes : Item
        {
            public double BaseDamage { get; set; }
            public double AttacksPerSecond { get; set; }                  
            public Enum MyWeapons { get; set; }
        }
    }
}




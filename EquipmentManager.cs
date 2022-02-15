using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{

    public class ArmorManager : PrimaryAttribute
    {
        protected enum AvailableArmor
        {
            Cloth = 1,
            Leather = 2,
            Mail = 3,
            Plate = 4,
        }

        public class ArmorTypes : Item
        {
            public void SelectArmor(int availableArmor)
            {
                AvailableArmor selectedArmor = (AvailableArmor)availableArmor;
                Console.WriteLine(selectedArmor);
            }               
        }
    }

    public class WeaponManager
    {
        protected enum AvailableWeapons
        {
            Axes = 1,
            Bows = 2,
            Daggers = 3,
            Hammers = 4,
            Staffs = 5,
            Swords = 6,
            Wands = 7,
        }

        public class WeaponTypes : Item
        {
            public double BaseDamage { get; set; }
            public double AttacksPerSecond { get; set; }

            public void SelectWeapon(int availableWeapon)
            {
                AvailableWeapons selectedWeapon = (AvailableWeapons)availableWeapon;
                Console.WriteLine(selectedWeapon);
            }

            public void CalculateDPS()
            {
                double calculatedDPS = BaseDamage * AttacksPerSecond;
            }                
        }
    }
}




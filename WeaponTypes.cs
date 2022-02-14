using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public enum AvailableWeapons
    {
        Axes = 1,
        Bows = 2,
        Daggers = 3,
        Hammers = 4,
        Staffs = 5,
        Swords = 6,
        Wands = 7,
    }

    class WeaponTypes : Item
    {
        public double BaseDamage { get; set; }
        public double AttacksPerSecond { get; set; }

        public void EquipWeapon(int availableWeapon)
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

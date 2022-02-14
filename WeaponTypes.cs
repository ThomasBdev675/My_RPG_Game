using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    class WeaponTypes
    {

        public class Axes : Item
        {
            protected double BaseDamage { get; set; }
            protected double AttacksPerSecond { get; set; }

            public Axes()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
                BaseDamage = 0;
                AttacksPerSecond = 0;
            }
            public void CalculateAxesDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = BaseDamage * AttacksPerSecond;
            }
        }

        public class Bows : Item
        {
            protected double BaseDamage { get; set; }
            protected double AttacksPerSecond { get; set; }

            public Bows()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
                BaseDamage = 0;
                AttacksPerSecond = 0;
            }

            public void CalculateBowsDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = BaseDamage * AttacksPerSecond;
            }

        }

        public class Daggers : Item
        {
            protected double BaseDamage { get; set; }
            protected double AttacksPerSecond { get; set; }

            public Daggers()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
                BaseDamage = 0;
                AttacksPerSecond = 0;
            }

            public void CalculateDaggersDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = BaseDamage * AttacksPerSecond;
            }

        }

        public class Hammers : Item
        {
            protected double BaseDamage { get; set; }
            protected double AttacksPerSecond { get; set; }

            public Hammers()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
                BaseDamage = 0;
                AttacksPerSecond = 0;
            }

            public void CalculateHammersDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = BaseDamage * AttacksPerSecond;
            }

        }

        public class Staffs : Item
        {
            protected double BaseDamage { get; set; }
            protected double AttacksPerSecond { get; set; }

            public Staffs()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
                BaseDamage = 0;
                AttacksPerSecond = 0;
            }

            public void CalculateStaffsDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = BaseDamage * AttacksPerSecond;
            }

        }

        public class Swords : Item
        {
            protected double BaseDamage { get; set; }
            protected double AttacksPerSecond { get; set; }

            public Swords()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
                BaseDamage = 0;
                AttacksPerSecond = 0;
            }

            public void CalculateSwordsDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = BaseDamage * AttacksPerSecond;
            }

        }

        public class Wands : Item
        {
            protected double BaseDamage { get; set; }
            protected double AttacksPerSecond { get; set; }

            public Wands()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
                BaseDamage = 0;
                AttacksPerSecond = 0;
            }

            public void CalculateWandsDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = BaseDamage * AttacksPerSecond;
            }

        }
    }
}

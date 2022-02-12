using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    class WeaponTypes
    {
        public class Axes
        {
            protected double baseDamage = 0;
            protected double attacksPerSecond = 0;

            public void CalculateAxesDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = baseDamage * attacksPerSecond;
            }
        }

        public class Bows
        {
            protected double baseDamage = 0;
            protected double attacksPerSecond = 0;


            public void CalculateBowsDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = baseDamage * attacksPerSecond;
            }

        }

        public class Daggers
        {
            protected double baseDamage = 0;
            protected double attacksPerSecond = 0;

            public void CalculateDaggersDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = baseDamage * attacksPerSecond;
            }

        }

        public class Hammers
        {
            protected double baseDamage = 0;
            protected double attacksPerSecond = 0;

            public void CalculateHammersDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = baseDamage * attacksPerSecond;
            }

        }

        public class Staffs
        {
            protected double baseDamage = 0;
            protected double attacksPerSecond = 0;

            public void CalculateStaffsDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = baseDamage * attacksPerSecond;
            }

        }

        public class Swords
        {
            protected double baseDamage = 0;
            protected double attacksPerSecond = 0;

            public void CalculateSwordsDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = baseDamage * attacksPerSecond;
            }

        }

        public class Wands
        {
            protected double baseDamage = 0;
            protected double attacksPerSecond = 0;

            public void CalculateWandsDPS()
            {
                CalculateDPS();
            }
            protected void CalculateDPS()
            {
                double calculatedDPS = baseDamage * attacksPerSecond;
            }

        }
    }
}

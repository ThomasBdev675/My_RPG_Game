using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    class ArmorTypes
    {
        public class Cloth : Item
        {



            public Cloth()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
            }

        }

        public class Leather : Item
        {



            public Leather()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
            }

        }
        public class Mail : Item
        {



            public Mail()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
            }

        }
        public class Plate : Item
        {



            public Plate()
            {
                Name += 1;
                RequiredLvl = 1;
                Slot = "";
            }

        }
    }
}

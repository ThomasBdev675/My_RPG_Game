using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public enum AvailableArmor
    {
        Cloth = 1,
        Leather = 2,
        Mail = 3,
        Plate = 4,
    }

    public class ArmorTypes : Item
    {
        public void EquipArmor(int availableArmor)
        {
            AvailableArmor selectedArmor = (AvailableArmor)availableArmor;
            Console.WriteLine(selectedArmor);
        }
    }
}

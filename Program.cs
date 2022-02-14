using System;

namespace My_RPG_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome to our RPG console game");
            Console.WriteLine("-------------------------------");
            //CharacterSelector
            CharacterSelector.ChooseCharacter ("Mage");
            //EquipmentManager Armor           
            EquipmentManager.ArmorManager.ChooseArmorEquipment(1);
            //EquipmentManager Weapon
            EquipmentManager.WeaponManager.ChooseWeaponEquipment(7);
            //Dictionary next to do


        }
    }
    
    
}

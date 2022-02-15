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
            CharacterManager.Charactertypes.ChooseCharacter("Mage");
            //EquipmentManager Armor           
            EquipmentManager.ArmorManager.ArmorTypes. ChooseArmorEquipment(2);
            //EquipmentManager Weapon
            EquipmentManager.WeaponManager.WeaponTypes.ChooseWeaponEquipment(5);       
            
            


            //Dictionary next to do                      


        }
    }
    
    
}

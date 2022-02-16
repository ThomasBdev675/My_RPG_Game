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

            //Creating Character
            CharacterManager.Charactertypes.Mage MyMage = new CharacterManager.Charactertypes.Mage();

            //ShowBaseStats
            MyMage.BaseStats();

            //Levelup
            MyMage.LevelUp();

            //Create Weapon
            WeaponManager.WeaponTypes MyWeapon = new WeaponManager.WeaponTypes()
            {
                Name = "Staffs",
                RequiredLvl = 2,
                Slot = WeaponManager.AllowedWeaponsSlots.Weapon,
                BaseDamage = 1,
                AttacksPerSecond = 1,
                MyWeapons = CharacterManager.Charactertypes.AllowedWeapons.Staffs,
            };

            //Create Cloth Armor
            ArmorManager.ArmorTypes MyClothArmor = new ArmorManager.ArmorTypes()
            {
                Name = "Cloth",
                RequiredLvl = 1,
                Slot = ArmorManager.AllowedArmorSlots.Head,  
                MyArmor = CharacterManager.Charactertypes.AllowedArmor.Cloth,
            };

            MyMage.EquipMyWeapon(MyWeapon);
            MyMage.EquipMyArmor(MyClothArmor);

        }
    }    
}

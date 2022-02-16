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
            CharacterManager.Charactertypes.Warrior MyWarrior = new CharacterManager.Charactertypes.Warrior()
            {
                Name = "MyWarrior",
            };

            //ShowBaseStats
            MyWarrior.BaseStats();

            //Levelup
            MyWarrior.LevelUp();

            //Create Weapon
            WeaponManager.WeaponTypes MyWeapon = new WeaponManager.WeaponTypes()
            {
                Name = "Sword",
                RequiredLvl = 1,
                Slot = WeaponManager.AllowedWeaponsSlots.Weapon,
                BaseDamage = 1,
                AttacksPerSecond = 1,
                MyWeapons = CharacterManager.Charactertypes.AllowedWeapons.Swords,
            };

            //Create Cloth Armor
            ArmorManager.ArmorTypes MyClothArmor = new ArmorManager.ArmorTypes()
            {
                Name = "Mail",
                RequiredLvl = 1,
                Slot = ArmorManager.AllowedArmorSlots.Head,  
                MyArmor = CharacterManager.Charactertypes.AllowedArmor.Mail,
            };

            MyWarrior.EquipMyWeapon(MyWeapon);
            MyWarrior.EquipMyArmor(MyClothArmor);

        }
    }    
}

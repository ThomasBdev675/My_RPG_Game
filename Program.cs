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
            Console.WriteLine("Mage created");

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
                MyWeapons = WeaponManager.AvailableWeapons.Daggers,
            };
            Console.WriteLine("Weapon Name: " + MyWeapon.Name);
            Console.WriteLine("Weapon required lvl: " + MyWeapon.RequiredLvl);
            Console.WriteLine("Weapon Slot: " + MyWeapon.Slot);
            Console.WriteLine("Weapon base damage: " + MyWeapon.RequiredLvl);
            Console.WriteLine("Weapon attack speed: " + MyWeapon.Slot);


            //Create Cloth Armor
            ArmorManager.ArmorTypes MyClothArmor = new ArmorManager.ArmorTypes()
            {
                Name = "Cloth",
                RequiredLvl = 1,
                Slot = ArmorManager.AllowedArmorSlots.Head,                
                MyArmor = ArmorManager.AvailableArmor.Cloth,
            };
           
            Console.WriteLine("Armor Name: " + MyClothArmor.Name);
            Console.WriteLine("Armor required lvl: " + MyClothArmor.RequiredLvl);
            Console.WriteLine("Armor Slot: " + MyClothArmor.Slot);

            //Create Plate Armor
            ArmorManager.ArmorTypes MyPlateArmor = new ArmorManager.ArmorTypes()
            {
                Name = "Plate",
                RequiredLvl = 2,
                Slot = ArmorManager.AllowedArmorSlots.Body,
                MyArmor = ArmorManager.AvailableArmor.Plate,
            };

            Console.WriteLine("Armor Name: " + MyClothArmor.Name);
            Console.WriteLine("Armor required lvl: " + MyClothArmor.RequiredLvl);
            Console.WriteLine("Armor Slot: " + MyClothArmor.Slot);




            MyMage.EquipMyWeapon(MyWeapon);
            //MyMage.EquipMyArmor(MyClothArmor);
            //MyMage.EquipMyArmor(MyPlateArmor);

        }
    }    
}

using System;

namespace My_RPG_Game
{
    class Program
    {

        public static  void EquipMyselectedWeapon(WeaponManager.WeaponTypes weaponTypes)
        {
            Console.WriteLine(weaponTypes.RequiredLvl);
            Console.WriteLine("Test");
        }

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

            //Create Armor
            ArmorManager.ArmorTypes MyClothArmor = new ArmorManager.ArmorTypes()
            {
                Name = "Cloth Armor",
                RequiredLvl = 1,
                Slot = "Slot",
            };
            MyClothArmor.SelectArmor(1);
            Console.WriteLine("Armor Name: " + MyClothArmor.Name);
            Console.WriteLine("Armor required lvl: " + MyClothArmor.RequiredLvl);
            Console.WriteLine("Armor Slot: " + MyClothArmor.Slot);

            //Create Weapon
            WeaponManager.WeaponTypes MyWeapon = new WeaponManager.WeaponTypes()
            {
                Name = "Axe Weapon",
                RequiredLvl = 1,
                Slot = "Slot",
                BaseDamage = 1,
                AttacksPerSecond = 1,
            };
            MyWeapon.SelectWeapon(1);
            Console.WriteLine("Weapon Name: " + MyWeapon.Name);
            Console.WriteLine("Weapon required lvl: " + MyWeapon.RequiredLvl);
            Console.WriteLine("Weapon Slot: " + MyWeapon.Slot);
            Console.WriteLine("Weapon base damage: " + MyWeapon.RequiredLvl);
            Console.WriteLine("Weapon attack speed: " + MyWeapon.Slot);

            EquipMyselectedWeapon(MyWeapon);


            












        }
    }
    
    
}

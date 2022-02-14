using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public class EquipmentManager
    {
        public class ArmorManager
        {
            ///EquipmentManager 
            ///Available values are: 1 for Cloth, 2 for Leather, 3 for Mail,4 for Plate
            /// <param name="selectedArmor"></param>                        
            public static void ChooseArmorEquipment(int selectedArmor)
            {
                try
                {
                    AvailableArmor myArmor = (AvailableArmor)selectedArmor;
                    Console.WriteLine("Armor selected: " + myArmor);
                    switch (selectedArmor)
                    {
                        case 1:
                            ArmorTypes MyClothArmor = new ArmorTypes()
                            {
                                Name = "Cloth Armor",
                                RequiredLvl = 1,
                                Slot = "Slot",
                            };
                            MyClothArmor.EquipArmor(1);
                            Console.WriteLine("Armor Name: " + MyClothArmor.Name);
                            Console.WriteLine("Armor required lvl: " + MyClothArmor.RequiredLvl);
                            Console.WriteLine("Armor Slot: " + MyClothArmor.Slot);
                            break;
                        case 2:
                            ArmorTypes MyLeatherArmor = new ArmorTypes()
                            {
                                Name = "Leather Armor",
                                RequiredLvl = 1,
                                Slot = "Slot",
                            };
                            MyLeatherArmor.EquipArmor(2);
                            Console.WriteLine("Armor Name: " + MyLeatherArmor.Name);
                            Console.WriteLine("Armor required lvl: " + MyLeatherArmor.RequiredLvl);
                            Console.WriteLine("Armor Slot: " + MyLeatherArmor.Slot);
                            break;
                        case 3:
                            ArmorTypes MyMailArmor = new ArmorTypes()
                            {
                                Name = "Mail Armor",
                                RequiredLvl = 1,
                                Slot = "Slot",
                            };
                            MyMailArmor.EquipArmor(3);
                            Console.WriteLine("Armor Name: " + MyMailArmor.Name);
                            Console.WriteLine("Armor required lvl: " + MyMailArmor.RequiredLvl);
                            Console.WriteLine("Armor Slot: " + MyMailArmor.Slot);
                            break;
                        case 4:
                            ArmorTypes MyPlateArmor = new ArmorTypes()
                            {
                                Name = "Plate Armor",
                                RequiredLvl = 1,
                                Slot = "Slot",
                            };
                            MyPlateArmor.EquipArmor(4);
                            Console.WriteLine("Armor Name: " + MyPlateArmor.Name);
                            Console.WriteLine("Armor required lvl: " + MyPlateArmor.RequiredLvl);
                            Console.WriteLine("Armor Slot: " + MyPlateArmor.Slot);
                            break;
                        default:
                            Console.WriteLine("You did not selected any available Armor Type");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    //Exception NOT YET DONE
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("End of our Armor Manager");
                    Console.WriteLine("--------------------");
                }
            }
        }

        public class WeaponManager
        {
            ///EquipmentManager 
            ///Available values are: 1 for Axes, 2 for Bows, 3 for Daggers,4 for Hammers, 5 for Staffs, 6 for Swords, 7 for Wands
            /// <param name="selectedWeapon"></param>                        
            public static void ChooseWeaponEquipment(int selectedWeapon)
            {
                try
                {
                    AvailableWeapons myWeapon = (AvailableWeapons)selectedWeapon;
                    Console.WriteLine("Weapon selected: " + myWeapon);
                    switch (selectedWeapon)
                    {
                        case 1:
                            WeaponTypes MyAxeWeapon = new WeaponTypes()
                            {
                                Name = "Axe Weapon",
                                RequiredLvl = 1,
                                Slot = "Slot",
                                BaseDamage = 1,
                                AttacksPerSecond = 1,
                            };
                            MyAxeWeapon.EquipWeapon(1);
                            Console.WriteLine("Weapon Name: " + MyAxeWeapon.Name);
                            Console.WriteLine("Weapon required lvl: " + MyAxeWeapon.RequiredLvl);
                            Console.WriteLine("Weapon Slot: " + MyAxeWeapon.Slot);
                            Console.WriteLine("Weapon base damage: " + MyAxeWeapon.RequiredLvl);
                            Console.WriteLine("Weapon attack speed: " + MyAxeWeapon.Slot);
                            break;
                        case 2:
                            WeaponTypes MyBowWeapon = new WeaponTypes()
                            {
                                Name = "Bow Weapon",
                                RequiredLvl = 1,
                                Slot = "Slot",
                                BaseDamage = 1,
                                AttacksPerSecond = 1,
                            };
                            MyBowWeapon.EquipWeapon(2);
                            Console.WriteLine("Weapon Name: " + MyBowWeapon.Name);
                            Console.WriteLine("Weapon required lvl: " + MyBowWeapon.RequiredLvl);
                            Console.WriteLine("Weapon Slot: " + MyBowWeapon.Slot);
                            Console.WriteLine("Weapon base damage: " + MyBowWeapon.RequiredLvl);
                            Console.WriteLine("Weapon attack speed: " + MyBowWeapon.Slot);
                            break;
                        case 3:
                            WeaponTypes MyDaggerWeapon = new WeaponTypes()
                            {
                                Name = "Dagger Weapon",
                                RequiredLvl = 1,
                                Slot = "Slot",
                                BaseDamage = 1,
                                AttacksPerSecond = 1,
                            };
                            MyDaggerWeapon.EquipWeapon(3);
                            Console.WriteLine("Weapon Name: " + MyDaggerWeapon.Name);
                            Console.WriteLine("Weapon required lvl: " + MyDaggerWeapon.RequiredLvl);
                            Console.WriteLine("Weapon Slot: " + MyDaggerWeapon.Slot);
                            Console.WriteLine("Weapon base damage: " + MyDaggerWeapon.RequiredLvl);
                            Console.WriteLine("Weapon attack speed: " + MyDaggerWeapon.Slot);
                            break;
                        case 4:
                            WeaponTypes MyHammerWeapon = new WeaponTypes()
                            {
                                Name = "Hammer Weapon",
                                RequiredLvl = 1,
                                Slot = "Slot",
                                BaseDamage = 1,
                                AttacksPerSecond = 1,
                            };
                            MyHammerWeapon.EquipWeapon(4);
                            Console.WriteLine("Weapon Name: " + MyHammerWeapon.Name);
                            Console.WriteLine("Weapon required lvl: " + MyHammerWeapon.RequiredLvl);
                            Console.WriteLine("Weapon Slot: " + MyHammerWeapon.Slot);
                            Console.WriteLine("Weapon base damage: " + MyHammerWeapon.RequiredLvl);
                            Console.WriteLine("Weapon attack speed: " + MyHammerWeapon.Slot);
                            break;

                        case 5:
                            WeaponTypes MyStaffWeapon = new WeaponTypes()
                            {
                                Name = "Staff Weapon",
                                RequiredLvl = 1,
                                Slot = "Slot",
                                BaseDamage = 1,
                                AttacksPerSecond = 1,
                            };
                            MyStaffWeapon.EquipWeapon(5);
                            Console.WriteLine("Weapon Name: " + MyStaffWeapon.Name);
                            Console.WriteLine("Weapon required lvl: " + MyStaffWeapon.RequiredLvl);
                            Console.WriteLine("Weapon Slot: " + MyStaffWeapon.Slot);
                            Console.WriteLine("Weapon base damage: " + MyStaffWeapon.RequiredLvl);
                            Console.WriteLine("Weapon attack speed: " + MyStaffWeapon.Slot);
                            break;
                        case 6:
                            WeaponTypes MySwordWeapon = new WeaponTypes()
                            {
                                Name = "Sword Weapon",
                                RequiredLvl = 1,
                                Slot = "Slot",
                                BaseDamage = 1,
                                AttacksPerSecond = 1,
                            };
                            MySwordWeapon.EquipWeapon(6);
                            Console.WriteLine("Weapon Name: " + MySwordWeapon.Name);
                            Console.WriteLine("Weapon required lvl: " + MySwordWeapon.RequiredLvl);
                            Console.WriteLine("Weapon Slot: " + MySwordWeapon.Slot);
                            Console.WriteLine("Weapon base damage: " + MySwordWeapon.RequiredLvl);
                            Console.WriteLine("Weapon attack speed: " + MySwordWeapon.Slot);
                            break;
                        case 7:
                            WeaponTypes MyWandWeapon = new WeaponTypes()
                            {
                                Name = "Wand Weapon",
                                RequiredLvl = 1,
                                Slot = "Slot",
                                BaseDamage = 1,
                                AttacksPerSecond = 1,
                            };
                            MyWandWeapon.EquipWeapon(7);
                            Console.WriteLine("Weapon Name: " + MyWandWeapon.Name);
                            Console.WriteLine("Weapon required lvl: " + MyWandWeapon.RequiredLvl);
                            Console.WriteLine("Weapon Slot: " + MyWandWeapon.Slot);
                            Console.WriteLine("Weapon base damage: " + MyWandWeapon.RequiredLvl);
                            Console.WriteLine("Weapon attack speed: " + MyWandWeapon.Slot);
                            break;
                        default:
                            Console.WriteLine("You did not selected any available Weapon Type");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    //Exception NOT YET DONE
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("End of our Weapon Manager");
                    Console.WriteLine("--------------------");
                }
            }
        }

    }
}



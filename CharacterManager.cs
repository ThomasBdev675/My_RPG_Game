using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public class CharacterManager
    {
        public class Charactertypes
        {
            /// Using Enumerator for a list of overall AvailableSlots
            public enum AvailableSlots
            {
                Head,
                Body,
                Legs,
                Weapon,
            }

            /// Using Enumerator for a list of overall AllowedWeapons
            public enum AllowedWeapons
            {
                Axes,
                Bows,
                Daggers,
                Hammers,
                Staffs,
                Swords,
                Wands,
            }

            /// Using Enumerator for a list of overall AllowedArmors  
            public enum AllowedArmor
            {
                Cloth,
                Leather,
                Mail,
                Plate,
            }
            
            /// Dictionaries added to handle Characters Available Slots, AllowedWeapons and AllowedArmors            
            protected static Dictionary<AvailableSlots, string> CharacterAvailableSlots = new Dictionary<AvailableSlots, string>();
            protected static Dictionary<int, AllowedWeapons> CharacterAllowedWeapons = new Dictionary<int, AllowedWeapons>();
            protected static Dictionary<int ,AllowedArmor> CharacterAllowedArmors = new Dictionary<int, AllowedArmor>();

            ///Public class to define Mage class and their attributes
            public class Mage : PrimaryAttribute
            {
                protected string Name { get; set; }
                protected int Lvl { get; set; }
                protected double Damage { get; set; }

                ///Constructor for the Mage class to define their attributes
                public Mage()
                {
                    ///Setting base stats
                    Lvl += 1;
                    Damage += 0;
                    Strenght += 1;
                    Dexterity += 1;
                    Intelligence += 8;

                    ///Defining available Slots for Character using Dictionary
                    CharacterAvailableSlots.Add(AvailableSlots.Head, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Body, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Legs, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Weapon, "Empty");

                    ///Defining allowed Weapons for Character using Dictionary
                    CharacterAllowedWeapons.Add(0, AllowedWeapons.Staffs);
                    CharacterAllowedWeapons.Add(1, AllowedWeapons.Wands);

                    ///Defining allowed Armor for Character using Dictionary
                    CharacterAllowedArmors.Add(0, AllowedArmor.Cloth);
                }

                /// Overriding method to show primary stats             
                public override void ShowPrimaryStats()
                {
                    base.ShowPrimaryStats();
                }

                ///Public method to show base stats
                ///No parameters are needed
                public void BaseStats()
                {   ///Show base stats
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Base stats:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Name: " + Name);
                    Console.WriteLine("lvl: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                    Console.WriteLine("Damage: " + Damage);
                    Console.WriteLine("Available Slots:");
                    Console.WriteLine(AvailableSlots.Body);
                    Console.WriteLine(AvailableSlots.Head);
                    Console.WriteLine(AvailableSlots.Legs);
                    Console.WriteLine(AvailableSlots.Weapon);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("End of Base stats:");
                    Console.WriteLine("--------------------");
                }

                ///Public override method to calculate provided stats
                ///Please add Strenght, Dexterity and Intelligence for calculation
                protected override void CalculateCurrentStats(double addStrenght, double addDexterity, double addIntelligence)
                {
                    ///Run stat calculation from shared method using ovveride
                    base.CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
                }

                ///Public method to calculate level up based on provided lvl
                ///Please provide the lvl to increase
                public void LevelUp()
                {
                    CalculateLevelUp();
                }

                ///Protected method to perform the calculate based on provided stats
                ///Calculate new lvl based on the provided increase
                protected void CalculateLevelUp()
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Before lvl calculation:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Level: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                    //CompleteAttributeCalculation missing
                    Lvl += 1;
                    Strenght += 1 * 1;
                    Dexterity += 1 * 1;
                    Intelligence += 5 * 1;

                    Console.WriteLine("--------------------");
                    Console.WriteLine("After lvl calculation:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Level: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                }
                public void EquipMyWeapon(WeaponManager.WeaponTypes weaponTypes)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Equip Weapon Method:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine(weaponTypes.Slot);
                    Console.WriteLine(weaponTypes.RequiredLvl);
                    Console.WriteLine(weaponTypes.Name);
                    Console.WriteLine(weaponTypes.MyWeapons);
                    Console.WriteLine("--------------------");

                    if (weaponTypes.RequiredLvl > Lvl) throw new ArgumentException();
                    string myAvailableSlot = CharacterAvailableSlots[AvailableSlots.Weapon];
                    //Console.WriteLine(myAvailableSlot);
                    string checkSlot = weaponTypes.Slot.ToString();
                    bool weaponAllowed = false;

                    
                    for (int i = 0; i < CharacterAllowedWeapons.Count; i++)
                    {
                        if (CharacterAllowedWeapons[i].Equals(weaponTypes.MyWeapons))
                        {
                            weaponAllowed = true;
                            break;
                        }
                    }

                    if (weaponAllowed == true)
                    {                  
                        try
                        {
                            switch (checkSlot)
                            {
                                case "Weapon":
                                    Console.WriteLine("Weapon Slot provided");
                                    Console.WriteLine(myAvailableSlot);
                                    if (myAvailableSlot == "Empty")
                                    {
                                            Console.WriteLine("Peronal Weapon Slot is 'Empty'");
                                            CharacterAvailableSlots[AvailableSlots.Weapon] = weaponTypes.Name;
                                            Console.WriteLine("New euipped Weapon is set to " + weaponTypes.Name);
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Your Weapon Slot is already used, You cant equip a second weapon on the same slot");
                                        throw new ArgumentException();
                                    }

                                    break;
                                case "Legs":
                                    throw new WrongSlotException();                               
                                case "Body":
                                    Console.WriteLine("Body Slot provided");
                                    Console.WriteLine("You are trying to equip a Weapon on your Body Slot. You cant equip a weapon using the Body Slot");
                                    throw new ArgumentException();                                
                                case "Head":
                                    Console.WriteLine("Head Slot provided");                                
                                    Console.WriteLine("You are trying to equip a Weapon on your Head Slot. You cant equip a weapon using the Head Slot");
                                    throw new ArgumentException();

                                default:
                                    Console.WriteLine("You did not provided the correct slot. Please choose one of the available slot from 'WeaponManager.AllowedWeaponsSlots'");
                                    throw new ArgumentException();                                
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Weapon is not allowed");
                        throw new NotAllowedWeapon();
                    }
                }

                public void EquipMyArmor(ArmorManager.ArmorTypes armorTypes)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Equip Armor Method:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine(armorTypes.Slot);
                    Console.WriteLine(armorTypes.RequiredLvl);
                    Console.WriteLine(armorTypes.Name);
                    Console.WriteLine("--------------------");

                    if (armorTypes.RequiredLvl > Lvl) throw new ArgumentException();
                    string myAvailableBodySlot = CharacterAvailableSlots[AvailableSlots.Body];
                    string myAvailableHeadSlot = CharacterAvailableSlots[AvailableSlots.Head];
                    string myAvailableLegsSlot = CharacterAvailableSlots[AvailableSlots.Legs];

                    Console.WriteLine(myAvailableBodySlot);
                    Console.WriteLine(myAvailableHeadSlot);
                    Console.WriteLine(myAvailableLegsSlot);

                    string checkSlot = armorTypes.Slot.ToString();

                    try
                    {
                        switch (checkSlot)
                        {
                            case "Body":
                                Console.WriteLine("Body Slot provided");
                                Console.WriteLine(myAvailableBodySlot);        

                                if (myAvailableBodySlot == "Empty")
                                {
                                    Console.WriteLine("Peronal Body Slot is 'Empty'");
                                    CharacterAvailableSlots[AvailableSlots.Body] = armorTypes.Name;
                                    Console.WriteLine("New euipped Body armor is set to " + armorTypes.Name);
                                }
                                else
                                {
                                    Console.WriteLine("Your Body Slot is already used, You cant equip a second armor on the same slot");
                                    throw new ArgumentException();
                                }

                                break;
                            case "Head":
                                Console.WriteLine("Head Slot provided");
                                Console.WriteLine(myAvailableHeadSlot);

                                if (myAvailableHeadSlot == "Empty")
                                {
                                    Console.WriteLine("Peronal Head Slot is 'Empty'");
                                    CharacterAvailableSlots[AvailableSlots.Head] = armorTypes.Name;
                                    Console.WriteLine("New euipped armor is set to " + armorTypes.Name);
                                }
                                else
                                {
                                    Console.WriteLine("Your Head Slot is already used, You cant equip a second armor on the same slot");
                                    throw new ArgumentException();
                                }
                                break;
                                
                            case "Legs":
                                Console.WriteLine("Legs Slot provided");
                                Console.WriteLine(myAvailableLegsSlot);

                                if (myAvailableLegsSlot == "Empty")
                                {
                                    Console.WriteLine("Peronal Legs Slot is 'Empty'");
                                    CharacterAvailableSlots[AvailableSlots.Legs] = armorTypes.Name;
                                    Console.WriteLine("New euipped Legs armor is set to " + armorTypes.Name);
                                }
                                else
                                {
                                    Console.WriteLine("Your Legs Slot is already used, You cant equip a second armor on the same slot");
                                    throw new ArgumentException();
                                }
                                break;

                            case "Weapon":
                                Console.WriteLine("Weapon Slot provided");
                                Console.WriteLine("You are trying to equip an Armor on your Weapon Slot. You cant equip an armor using the Weapon Slot");
                                throw new ArgumentException();

                            default:
                                Console.WriteLine("You did not provided the correct slot. Please chose one of the available slot from 'ArmorManager.AllowedArmorSlots'");
                                throw new ArgumentException();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            ///Public class to define Ranger class and their attributes
            public class Ranger : PrimaryAttribute
            {
                protected string Name { get; set; }
                protected int Lvl { get; set; }
                protected double Damage { get; set; }

                ///Constructor for the Mage class to define their attributes
                public Ranger()
                {
                    ///Setting base stats
                    Lvl += 1;
                    Damage += 0;
                    Strenght += 1;
                    Dexterity += 7;
                    Intelligence += 1;

                    ///Defining available Slots for Character using Dictionary
                    CharacterAvailableSlots.Add(AvailableSlots.Head, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Body, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Legs, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Weapon, "Empty");

                    ///Defining allowed Weapons for Character using Dictionary
                    CharacterAllowedWeapons.Add(0, AllowedWeapons.Bows);

                    ///Defining allowed Armor for Character using Dictionary
                    CharacterAllowedArmors.Add(0, AllowedArmor.Leather);
                    CharacterAllowedArmors.Add(1, AllowedArmor.Mail);
                }

                /// Overriding method to show primary stats
                public override void ShowPrimaryStats()
                {
                    base.ShowPrimaryStats();
                }

                ///Public method to show base stats
                ///No parameters are needed
                public void BaseStats()
                {   ///Show base stats
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Base stats:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Name: " + Name);
                    Console.WriteLine("lvl: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                    Console.WriteLine("Damage: " + Damage);
                    Console.WriteLine("Available Slots:");
                    Console.WriteLine(AvailableSlots.Body);
                    Console.WriteLine(AvailableSlots.Head);
                    Console.WriteLine(AvailableSlots.Legs);
                    Console.WriteLine(AvailableSlots.Weapon);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("End of Base stats:");
                    Console.WriteLine("--------------------");
                }

                ///Public override method to calculate provided stats
                ///Please add Strenght, Dexterity and Intelligence for calculation
                protected override void CalculateCurrentStats(double addStrenght, double addDexterity, double addIntelligence)
                {
                    ///Run stat calculation from shared method using ovveride
                    base.CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
                }

                ///Public method to calculate level up based on provided lvl
                ///Please provide the lvl to increase
                public void LevelUp()
                {
                    CalculateLevelUp();
                }

                ///Protected method to perform the calculate based on provided stats
                ///Calculate new lvl based on the provided increase
                protected void CalculateLevelUp()
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Before lvl calculation:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Level: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);

                    Lvl += 1;
                    Strenght += 1 * 1;
                    Dexterity += 1 * 1;
                    Intelligence += 5 * 1;

                    Console.WriteLine("--------------------");
                    Console.WriteLine("After lvl calculation:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Level: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                }
            }

            ///Public class to define Rogue class and their attributes
            public class Rogue : PrimaryAttribute
            {
                protected string Name { get; set; }
                protected int Lvl { get; set; }
                protected double Damage { get; set; }

                ///Constructor for the Mage class to define their attributes
                public Rogue()
                {
                    /// Seeting base stats
                    Lvl += 1;
                    Damage += 0;
                    Strenght += 2;
                    Dexterity += 6;
                    Intelligence += 1;

                    ///Defining available Slots for Character using Dictionary
                    CharacterAvailableSlots.Add(AvailableSlots.Head, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Body, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Legs, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Weapon, "Empty");

                    ///Defining allowed Weapons for Character using Dictionary
                    CharacterAllowedWeapons.Add(0, AllowedWeapons.Daggers);
                    CharacterAllowedWeapons.Add(1, AllowedWeapons.Swords);

                    ///Defining allowed Armor for Character using Dictionary
                    CharacterAllowedArmors.Add(0, AllowedArmor.Leather);
                    CharacterAllowedArmors.Add(1, AllowedArmor.Mail);
                }

                /// Overriding method to show primary stats
                public override void ShowPrimaryStats()
                {
                    base.ShowPrimaryStats();
                }

                ///Public method to show base stats
                ///No parameters are needed
                public void BaseStats()
                {   ///Show base stats
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Base stats:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Name: " + Name);
                    Console.WriteLine("lvl: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                    Console.WriteLine("Damage: " + Damage);
                    Console.WriteLine("Available Slots:");
                    Console.WriteLine(AvailableSlots.Body);
                    Console.WriteLine(AvailableSlots.Head);
                    Console.WriteLine(AvailableSlots.Legs);
                    Console.WriteLine(AvailableSlots.Weapon);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("End of Base stats:");
                    Console.WriteLine("--------------------");
                }

                ///Public override method to calculate provided stats
                ///Please add Strenght, Dexterity and Intelligence for calculation
                protected override void CalculateCurrentStats(double addStrenght, double addDexterity, double addIntelligence)
                {
                    ///Run stat calculation from shared method using ovveride
                    base.CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
                }

                ///Public method to calculate level up based on provided lvl
                ///Please provide the lvl to increase
                public void LevelUp()
                {
                    CalculateLevelUp();
                }

                ///Protected method to perform the calculate based on provided stats
                ///Calculate new lvl based on the provided increase
                protected void CalculateLevelUp()
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Before lvl calculation:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Level: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);

                    Lvl += 1;
                    Strenght += 1 * 1;
                    Dexterity += 1 * 1;
                    Intelligence += 5 * 1;

                    Console.WriteLine("--------------------");
                    Console.WriteLine("After lvl calculation:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Level: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                }
            }

            ///Public class to define Warrior class and their attributes
            public class Warrior : PrimaryAttribute
            {
                protected string Name { get; set; }
                protected int Lvl { get; set; }
                protected double Damage { get; set; }

                ///Constructor for the Mage class to define their attributes
                public Warrior()
                {
                    /// Setting base stats
                    Lvl += 1;
                    Damage += 0;
                    Strenght += 5;
                    Dexterity += 2;
                    Intelligence += 1;

                    ///Defining available Slots for Character using Dictionary
                    CharacterAvailableSlots.Add(AvailableSlots.Head, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Body, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Legs, "Empty");
                    CharacterAvailableSlots.Add(AvailableSlots.Weapon, "Empty");

                    ///Defining allowed Weapons for Character using Dictionary
                    CharacterAllowedWeapons.Add(0,AllowedWeapons.Axes);
                    CharacterAllowedWeapons.Add(1,AllowedWeapons.Hammers);
                    CharacterAllowedWeapons.Add(2,AllowedWeapons.Swords);

                    ///Defining allowed Armor for Character using Dictionary
                    CharacterAllowedArmors.Add(0,AllowedArmor.Mail);
                    CharacterAllowedArmors.Add(1,AllowedArmor.Plate);
                }

                /// Overriding method to show primary stats
                public override void ShowPrimaryStats()
                {
                    base.ShowPrimaryStats();
                }

                ///Public method to show base stats
                ///No parameters are needed
                public void BaseStats()
                {   ///Show base stats
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Base stats:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Name: " + Name);
                    Console.WriteLine("lvl: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                    Console.WriteLine("Damage: " + Damage);
                    Console.WriteLine("Available Slots:");
                    Console.WriteLine(AvailableSlots.Body);
                    Console.WriteLine(AvailableSlots.Head);
                    Console.WriteLine(AvailableSlots.Legs);
                    Console.WriteLine(AvailableSlots.Weapon);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("End of Base stats:");
                    Console.WriteLine("--------------------");
                }

                ///Public override method to calculate provided stats
                ///Please add Strenght, Dexterity and Intelligence for calculation
                protected override void CalculateCurrentStats(double addStrenght, double addDexterity, double addIntelligence)
                {
                    ///Run stat calculation from shared method using ovveride
                    base.CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
                }

                ///Public method to calculate level up based on provided lvl
                ///Please provide the lvl to increase
                public void LevelUp()
                {
                    CalculateLevelUp();
                }

                ///Protected method to perform the calculate based on provided stats
                ///Calculate new lvl based on the provided increase
                protected void CalculateLevelUp()
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Before lvl calculation:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Level: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);

                    Lvl += 1;
                    Strenght += 1 * 1;
                    Dexterity += 1 * 1;
                    Intelligence += 5 * 1;

                    Console.WriteLine("--------------------");
                    Console.WriteLine("After lvl calculation:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Level: " + Lvl);
                    Console.WriteLine("Strenght: " + Strenght);
                    Console.WriteLine("Dexterity: " + Dexterity);
                    Console.WriteLine("Intelligence: " + Intelligence);
                }
            }
        }       
    }
}




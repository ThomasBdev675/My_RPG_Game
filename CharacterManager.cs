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
            protected static Dictionary<AllowedWeapons, string> CharacterAllowedWeapons = new Dictionary<AllowedWeapons, string>();
            protected static Dictionary<AllowedArmor, string> CharacterAllowedArmors = new Dictionary<AllowedArmor, string>();

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
                    CharacterAllowedWeapons.Add(AllowedWeapons.Staffs, "Empty");
                    CharacterAllowedWeapons.Add(AllowedWeapons.Wands, "Empty");

                    ///Defining allowed Armor for Character using Dictionary
                    CharacterAllowedArmors.Add(AllowedArmor.Cloth, "Empty");
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
                    Console.WriteLine("Available Head Slot:");
                    Console.WriteLine("");
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
                    CharacterAllowedWeapons.Add(AllowedWeapons.Bows, "Empty");

                    ///Defining allowed Armor for Character using Dictionary
                    CharacterAllowedArmors.Add(AllowedArmor.Leather, "Empty");
                    CharacterAllowedArmors.Add(AllowedArmor.Mail, "Empty");
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
                    CharacterAllowedWeapons.Add(AllowedWeapons.Daggers, "Empty");
                    CharacterAllowedWeapons.Add(AllowedWeapons.Swords, "Empty");

                    ///Defining allowed Armor for Character using Dictionary
                    CharacterAllowedArmors.Add(AllowedArmor.Leather, "Empty");
                    CharacterAllowedArmors.Add(AllowedArmor.Mail, "Empty");
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
                    CharacterAllowedWeapons.Add(AllowedWeapons.Axes, "Empty");
                    CharacterAllowedWeapons.Add(AllowedWeapons.Hammers, "Empty");
                    CharacterAllowedWeapons.Add(AllowedWeapons.Swords, "Empty");

                    ///Defining allowed Armor for Character using Dictionary
                    CharacterAllowedArmors.Add(AllowedArmor.Mail, "Empty");
                    CharacterAllowedArmors.Add(AllowedArmor.Plate, "Empty");
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

            public static void ChooseCharacter(string CharacterClass)
            {
                try
                {
                    Console.WriteLine("Character selected: " + CharacterClass);
                    switch (CharacterClass)
                    {
                        case "Mage":
                            Charactertypes.Mage MyMage = new Charactertypes.Mage();
                            MyMage.BaseStats();
                            break;
                        case "Ranger":
                            Charactertypes.Ranger MyRanger = new Charactertypes.Ranger();
                            MyRanger.BaseStats();
                            break;
                        case "Rogue":
                            Charactertypes.Rogue MyRogue = new Charactertypes.Rogue();
                            MyRogue.BaseStats();
                            break;
                        case "Warrior":
                            Charactertypes.Warrior MyWarrior = new Charactertypes.Warrior();
                            MyWarrior.BaseStats();
                            break;
                        default:
                            Console.WriteLine("You did not selected any available Character Type");
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
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("End of our Character Selector");
                    Console.WriteLine("-----------------------------");
                }
            }
        }       
    }
}




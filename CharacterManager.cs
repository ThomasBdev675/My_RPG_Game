using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    class CharacterManager
    {

        public class Charactertypes
        {
            ///Public class to define Mage class and their attributes
            protected class Mage : PrimaryAttribute
            {
                protected string Name { get; set; }
                protected int Lvl { get; set; }
                protected string AllowedArmor { get; set; }
                protected string AllowedWeapons { get; set; }
                protected double Damage { get; set; }

                ///Constructor for the Mage class to define their attributes
                public Mage()
                {
                    Lvl += 1;
                    AllowedArmor = "Cloth";
                    AllowedWeapons = "Staff, Wand";
                    Damage += 0;
                    Strenght += 1;
                    Dexterity += 1;
                    Intelligence += 8;
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

            ///Public class to define Ranger class and their attributes
            protected class Ranger : PrimaryAttribute
            {
                protected string Name { get; set; }
                protected int Lvl { get; set; }
                protected string AllowedArmor { get; set; }
                protected string AllowedWeapons { get; set; }
                protected double Damage { get; set; }

                ///Constructor for the Mage class to define their attributes
                public Ranger()
                {
                    Lvl += 1;
                    AllowedArmor = "Leather, Mail";
                    AllowedWeapons = "Bow";
                    Damage += 0;
                    Strenght += 1;
                    Dexterity += 7;
                    Intelligence += 1;
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
            protected class Rogue : PrimaryAttribute
            {
                protected string Name { get; set; }
                protected int Lvl { get; set; }
                protected string AllowedArmor { get; set; }
                protected string AllowedWeapons { get; set; }
                protected double Damage { get; set; }

                ///Constructor for the Mage class to define their attributes
                public Rogue()
                {
                    Lvl += 1;
                    AllowedArmor = "Leather, Mail";
                    AllowedWeapons = "Dagger, Sword";
                    Damage += 0;
                    Strenght += 2;
                    Dexterity += 6;
                    Intelligence += 1;
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
            protected class Warrior : PrimaryAttribute
            {
                protected string Name { get; set; }
                protected int Lvl { get; set; }
                protected string AllowedArmor { get; set; }
                protected string AllowedWeapons { get; set; }
                protected double Damage { get; set; }

                ///Constructor for the Mage class to define their attributes
                public Warrior()
                {
                    Lvl += 1;
                    AllowedArmor = "Mail, Plate";
                    AllowedWeapons = "Axe,, Hammer, Sword";
                    Damage += 0;
                    Strenght += 5;
                    Dexterity += 2;
                    Intelligence += 1;
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
                            MyMage.ShowPrimaryStats();
                            //MyMage.BaseStats();
                            //MyMage.CalculateCurrentStats(1, 1, 1);
                            //MyMage.LevelUp();
                            break;
                        case "Ranger":
                            Charactertypes.Ranger MyRanger = new Charactertypes.Ranger();
                            MyRanger.BaseStats();
                            //MyRanger.CalculateCurrentStats(1, 1, 1);
                            MyRanger.LevelUp();
                            break;
                        case "Rogue":
                            Charactertypes.Rogue MyRogue = new Charactertypes.Rogue();
                            MyRogue.BaseStats();
                            //MyRogue.CalculateCurrentStats(1, 1, 1);
                            MyRogue.LevelUp();
                            break;
                        case "Warrior":
                            Charactertypes.Warrior MyWarrior = new Charactertypes.Warrior();
                            MyWarrior.BaseStats();
                            //MyWarrior.CalculateCurrentStats(1, 1, 1);
                            MyWarrior.LevelUp();
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
                    Console.WriteLine("--------------------");
                    Console.WriteLine("End of our RPG Game");
                    Console.WriteLine("--------------------");
                }
            }
        }       
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public class Charactertypes
    {
        ///Public class to define Mage class and their attributes
        public class Mage : PrimaryAttribute
        {
            protected string name = "";
            protected int lvl = 1;
            protected string allowedArmor = "Cloth";
            protected string allowedWeapons = "Staff, Wand";
            protected double damage = 0;

            ///Constructor for the Mage class to define their attributes
            public Mage()
            {
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
                Console.WriteLine("Name: " + name);
                Console.WriteLine("lvl: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
                Console.WriteLine("Damage: " + damage);
            }

            ///Public override method to calculate provided stats
            ///Please add Strenght, Dexterity and Intelligence for calculation
            public override void CalculateCurrentStats(double addStrenght, double addDexterity, double addIntelligence)
            { 
                ///Run stat calculation from shared method using ovveride
                base.CalculateCurrentStats(addStrenght,addDexterity,addIntelligence);  
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
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);

                lvl += 1;
                Strenght += 1 * 1;
                Dexterity += 1 * 1;
                Intelligence += 5 * 1;

                Console.WriteLine("--------------------");
                Console.WriteLine("After lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
            }

        }

        ///Public class to define Ranger class and their attributes
        public class Ranger : PrimaryAttribute
        {
            protected string name = "";
            protected int lvl = 1;
            protected string allowedArmor = "Leather, Mail";
            protected string allowedWeapons = "Bow";
            protected double damage = 0;

            ///Constructor for the Mage class to define their attributes
            public Ranger()
            {
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
                Console.WriteLine("Name: " + name);
                Console.WriteLine("lvl: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
                Console.WriteLine("Damage: " + damage);
            }

            ///Public override method to calculate provided stats
            ///Please add Strenght, Dexterity and Intelligence for calculation
            public override void CalculateCurrentStats(double addStrenght, double addDexterity, double addIntelligence)
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
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);

                lvl += 1;
                Strenght += 1 * 1;
                Dexterity += 1 * 1;
                Intelligence += 5 * 1;

                Console.WriteLine("--------------------");
                Console.WriteLine("After lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
            }
        }

        ///Public class to define Rogue class and their attributes
        public class Rogue : PrimaryAttribute
        {
            protected string name = "";
            protected int lvl = 1;
            protected string allowedArmor = "Leather, Mail";
            protected string allowedWeapons = "Dagger, Sword";
            protected double damage = 0;

            ///Constructor for the Mage class to define their attributes
            public Rogue()
            {
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
                Console.WriteLine("Name: " + name);
                Console.WriteLine("lvl: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
                Console.WriteLine("Damage: " + damage);
            }

            ///Public override method to calculate provided stats
            ///Please add Strenght, Dexterity and Intelligence for calculation
            public override void CalculateCurrentStats(double addStrenght, double addDexterity, double addIntelligence)
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
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);

                lvl += 1;
                Strenght += 1 * 1;
                Dexterity += 1 * 1;
                Intelligence += 5 * 1;

                Console.WriteLine("--------------------");
                Console.WriteLine("After lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
            }
        }

        ///Public class to define Warrior class and their attributes
        public class Warrior : PrimaryAttribute
        {
            protected string name = "";
            protected int lvl = 1;
            protected string allowedArmor = "Mail, Plate";
            protected string allowedWeapons = "Axe,, Hammer, Sword";
            protected double damage = 0;

            ///Constructor for the Mage class to define their attributes
            public Warrior()
            {
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
                Console.WriteLine("Name: " + name);
                Console.WriteLine("lvl: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
                Console.WriteLine("Damage: " + damage);
            }

            ///Public override method to calculate provided stats
            ///Please add Strenght, Dexterity and Intelligence for calculation
            public override void CalculateCurrentStats(double addStrenght, double addDexterity, double addIntelligence)
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
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);

                lvl += 1;
                Strenght += 1 * 1;
                Dexterity += 1 * 1;
                Intelligence += 5 * 1;

                Console.WriteLine("--------------------");
                Console.WriteLine("After lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + Strenght);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
            }
        }
    }
}




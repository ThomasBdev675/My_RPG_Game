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
        public class Mage : PrimaryAttribute.Mage
        {
            protected string name = "";
            protected int lvl = 1;
            protected string allowedArmor = "Cloth";
            protected string allowedWeapons = "Staff, Wand";
            protected double damage = 0;

            ///Public method to show base stats
            ///No parameters are needed
            public void BaseStats()
            {   ///Show base stats
                Console.WriteLine("--------------------");
                Console.WriteLine("Base stats:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("lvl: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                Console.WriteLine("Damage: " + damage);
            }

            ///Public method using overloading to calculate provided stats
            ///Please add Strenght, Dexterity and Intelligence for calculation
            public void BaseStats(double addStrenght, double addDexterity, double addIntelligence)
            { 
                ///Run stat calculation
                CalculateCurrentStats(addStrenght,addDexterity,addIntelligence);  
            }

            ///Protected method to calculate provided stats
            ///Calculate new stats based on the provided increase
            ///ATT!! WEAPON AND ARMOR STATS NOT YET CALCULATED
            protected void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
            {
                double calculatedStrenght =  calculateStrenght +  strenght;
                double calculalatedDexterity = calculateDexterity + dexterity;
                double calculatedIntelligence = calculateIntelligence + intelligence;

                Console.WriteLine("--------------------");
                Console.WriteLine("New calculated stats:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Calculated Strenght: ");
                Console.WriteLine(calculatedStrenght);
                Console.WriteLine("Calculated Dexterity: ");
                Console.WriteLine(calculalatedDexterity);
                Console.WriteLine("Calculated Intelligence:");
                Console.WriteLine(calculatedIntelligence);  
            }

            ///Public method to calculate level up based on provided lvl
            ///Please provide the lvl to increase
            public void LevelUp(int lvlIncrease)
            {
                CalculateLevelUp(lvlIncrease);
            }

            ///Protected method to perform the calculate based on provided stats
            ///Calculate new lvl based on the provided increase
            protected void CalculateLevelUp( int lvlIncrease)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Before lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);

                lvl += lvl + lvlIncrease;
                strenght += 1 * lvlIncrease;
                dexterity += 1 * lvlIncrease;
                intelligence += 5 * lvlIncrease;

                Console.WriteLine("--------------------");
                Console.WriteLine("After lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
            }

        }
        ///Public class to define Ranger class and their attributes
        public class Ranger : PrimaryAttribute.Ranger
        {
            protected string name = "";
            protected int lvl = 1;
            protected string allowedArmor = "Leather, Mail";
            protected string allowedWeapons = "Bow";
            protected double damage = 0;

            ///Public method to show base stats
            ///No parameters are needed
            public void BaseStats()
            {   ///Show base stats
                Console.WriteLine("--------------------");
                Console.WriteLine("Base stats:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("lvl: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                Console.WriteLine("Damage: " + damage);
            }

            ///Public method using overloading to calculate provided stats
            ///Please add Strenght, Dexterity and Intelligence for calculation
            public void BaseStats(double addStrenght, double addDexterity, double addIntelligence)
            {   
                ///Run stat calculation
                CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
            }

            ///Protected method to calculate provided stats
            ///Calculate new stats based on the provided increase 
            //////ATT!! WEAPON AND ARMOR STATS NOT YET CALCULATED
            protected void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
            {
                double calculatedStrenght = calculateStrenght + strenght;
                double calculalatedDexterity = calculateDexterity + dexterity;
                double calculatedIntelligence = calculateIntelligence + intelligence;

                Console.WriteLine("--------------------");
                Console.WriteLine("New calculated stats:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Calculated Strenght: ");
                Console.WriteLine(calculatedStrenght);
                Console.WriteLine("Calculated Dexterity: ");
                Console.WriteLine(calculalatedDexterity);
                Console.WriteLine("Calculated Intelligence:");
                Console.WriteLine(calculatedIntelligence);
            }

            ///Public method to calculate level up based on provided lvl
            ///Please provide the lvl to increase
            public void LevelUp(int lvlIncrease)
            {
                CalculateLevelUp(lvlIncrease);
            }

            ///Protected method to perform the calculate based on provided stats
            ///Calculate new lvl based on the provided increase
            protected void CalculateLevelUp(int lvlIncrease)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Before lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);

                lvl += lvl + lvlIncrease;
                strenght += 1 * lvlIncrease;
                dexterity += 1 * lvlIncrease;
                intelligence += 5 * lvlIncrease;

                Console.WriteLine("--------------------");
                Console.WriteLine("After lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
            }
        }
        ///Public class to define Rogue class and their attributes
        public class Rogue : PrimaryAttribute.Rogue
        {
            protected string name = "";
            protected int lvl = 1;
            protected string allowedArmor = "Leather, Mail";
            protected string allowedWeapons = "Dagger, Sword";
            protected double damage = 0;

            ///Public method to show base stats
            ///No parameters are needed
            public void BaseStats()
            {   ///Show base stats
                Console.WriteLine("--------------------");
                Console.WriteLine("Base stats:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("lvl: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                Console.WriteLine("Damage: " + damage);
            }

            ///Public method using overloading to calculate provided stats
            ///Please add Strenght, Dexterity and Intelligence for calculation
            public void BaseStats(double addStrenght, double addDexterity, double addIntelligence)
            {   
                ///Run stat calculation
                CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
            }

            ///Protected method to calculate provided stats
            ///Calculate new stats based on the provided increase
            //////ATT!! WEAPON AND ARMOR STATS NOT YET CALCULATED
            protected void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
            {
                double calculatedStrenght = calculateStrenght + strenght;
                double calculalatedDexterity = calculateDexterity + dexterity;
                double calculatedIntelligence = calculateIntelligence + intelligence;

                Console.WriteLine("--------------------");
                Console.WriteLine("New calculated stats:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Calculated Strenght: ");
                Console.WriteLine(calculatedStrenght);
                Console.WriteLine("Calculated Dexterity: ");
                Console.WriteLine(calculalatedDexterity);
                Console.WriteLine("Calculated Intelligence:");
                Console.WriteLine(calculatedIntelligence);

            }

            ///Public method to calculate level up based on provided lvl
            ///Please provide the lvl to increase
            public void LevelUp(int lvlIncrease)
            {
                CalculateLevelUp(lvlIncrease);
            }

            ///Protected method to perform the calculate based on provided stats
            ///Calculate new lvl based on the provided increase
            protected void CalculateLevelUp(int lvlIncrease)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Before lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);

                lvl += lvl + lvlIncrease;
                strenght += 1 * lvlIncrease;
                dexterity += 1 * lvlIncrease;
                intelligence += 5 * lvlIncrease;

                Console.WriteLine("--------------------");
                Console.WriteLine("After lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
            }
        }
        ///Public class to define Warrior class and their attributes
        public class Warrior : PrimaryAttribute.Warrior
        {
            protected string name = "";
            protected int lvl = 1;
            protected string allowedArmor = "Mail, Plate";
            protected string allowedWeapons = "Axe,, Hammer, Sword";
            protected double damage = 0;

            ///Public method to show base stats
            ///No parameters are needed
            public void BaseStats()
            {   ///Show base stats
                Console.WriteLine("--------------------");
                Console.WriteLine("Base stats:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("lvl: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                Console.WriteLine("Damage: " + damage);
            }

            ///Public method using overloading to calculate provided stats
            ///Please add Strenght, Dexterity and Intelligence for calculation
            public void BaseStats(double addStrenght, double addDexterity, double addIntelligence)
            {  
                ///Run stat calculation
                CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
            }

            ///Protected method to calculate provided stats
            ///Calculate new stats based on the provided increase
            //////ATT!! WEAPON AND ARMOR STATS NOT YET CALCULATED
            protected void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
            {
                double calculatedStrenght = calculateStrenght + strenght;
                double calculalatedDexterity = calculateDexterity + dexterity;
                double calculatedIntelligence = calculateIntelligence + intelligence;

                Console.WriteLine("--------------------");
                Console.WriteLine("New calculated stats:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Calculated Strenght: ");
                Console.WriteLine(calculatedStrenght);
                Console.WriteLine("Calculated Dexterity: ");
                Console.WriteLine(calculalatedDexterity);
                Console.WriteLine("Calculated Intelligence:");
                Console.WriteLine(calculatedIntelligence);
            }

            ///Public method to calculate level up based on provided lvl
            ///Please provide the lvl to increase
            public void LevelUp(int lvlIncrease)
            {
                CalculateLevelUp(lvlIncrease);
            }

            ///Protected method to perform the calculate based on provided stats
            ///Calculate new lvl based on the provided increase
            protected void CalculateLevelUp(int lvlIncrease)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Before lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);

                lvl += lvl + lvlIncrease;
                strenght += 1 * lvlIncrease;
                dexterity += 1 * lvlIncrease;
                intelligence += 5 * lvlIncrease;

                Console.WriteLine("--------------------");
                Console.WriteLine("After lvl calculation:");
                Console.WriteLine("--------------------");
                Console.WriteLine("Level: " + lvl);
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
            }
        }
    }
}




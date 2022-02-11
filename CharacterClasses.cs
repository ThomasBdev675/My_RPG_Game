using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public class Classtypes
    {
        ///Define Mage class and their attributes
        public class Mage
        {
            protected double strenght = 1;
            protected double dexterity = 1;
            protected double intelligence = 8;

            ///Show stats
            public void Stats(double addStrenght, double addDexterity, double addIntelligence)
            {   ///Show base stats             
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                ///Run stat calculation
                CalculateCurrentStats(addStrenght,addDexterity,addIntelligence);  
            }

            ///Calculate current stats  NOT YET DONE
            protected void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
            {
                double calculatedStrenght =  calculateStrenght +  strenght;
                double calculalatedDexterity = calculateDexterity + dexterity;
                double calculatedIntelligence = calculateIntelligence + intelligence;
                
                Console.WriteLine("Calculated Strenght: ");
                Console.WriteLine(calculatedStrenght);
                Console.WriteLine("Calculated Dexterity: ");
                Console.WriteLine(calculalatedDexterity);
                Console.WriteLine("Calculated Intelligence:");
                Console.WriteLine(calculatedIntelligence);  
            }
        }

        public class Ranger
        {
            protected double strenght = 1;
            protected double dexterity = 7;
            protected double intelligence = 1;

            ///Show stats
            public void Stats(double addStrenght, double addDexterity, double addIntelligence)
            {   ///Show base stats             
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                ///Run stat calculation
                CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
            }

            ///Calculate current stats  NOT YET DONE
            protected void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
            {
                double calculatedStrenght = calculateStrenght + strenght;
                double calculalatedDexterity = calculateDexterity + dexterity;
                double calculatedIntelligence = calculateIntelligence + intelligence;

                Console.WriteLine("Calculated Strenght: ");
                Console.WriteLine(calculatedStrenght);
                Console.WriteLine("Calculated Dexterity: ");
                Console.WriteLine(calculalatedDexterity);
                Console.WriteLine("Calculated Intelligence:");
                Console.WriteLine(calculatedIntelligence);
            }
        }

        public class Rogue
        {
            protected double strenght = 2;
            protected double dexterity = 6;
            protected double intelligence = 1;

            ///Show stats
            public void Stats(double addStrenght, double addDexterity, double addIntelligence)
            {   ///Show base stats             
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                ///Run stat calculation
                CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
            }

            ///Calculate current stats  NOT YET DONE
            protected void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
            {
                double calculatedStrenght = calculateStrenght + strenght;
                double calculalatedDexterity = calculateDexterity + dexterity;
                double calculatedIntelligence = calculateIntelligence + intelligence;

                Console.WriteLine("Calculated Strenght: ");
                Console.WriteLine(calculatedStrenght);
                Console.WriteLine("Calculated Dexterity: ");
                Console.WriteLine(calculalatedDexterity);
                Console.WriteLine("Calculated Intelligence:");
                Console.WriteLine(calculatedIntelligence);
            }
        }

        public class Warrior
        {
            protected double strenght = 5;
            protected double dexterity = 2;
            protected double intelligence = 1;
            ///Show stats
            public void Stats(double addStrenght, double addDexterity, double addIntelligence)
            {   ///Show base stats             
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                ///Run stat calculation
                CalculateCurrentStats(addStrenght, addDexterity, addIntelligence);
            }

            ///Calculate current stats  NOT YET DONE
            protected void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
            {
                double calculatedStrenght = calculateStrenght + strenght;
                double calculalatedDexterity = calculateDexterity + dexterity;
                double calculatedIntelligence = calculateIntelligence + intelligence;

                Console.WriteLine("Calculated Strenght: ");
                Console.WriteLine(calculatedStrenght);
                Console.WriteLine("Calculated Dexterity: ");
                Console.WriteLine(calculalatedDexterity);
                Console.WriteLine("Calculated Intelligence:");
                Console.WriteLine(calculatedIntelligence);
            }
        }
    }
}




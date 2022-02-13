using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public class PrimaryAttribute
    {
        protected double Strenght { get; set; }
        protected double Dexterity { get; set; }
        protected double Intelligence { get; set; }

        ///Virtual method to show base stats
        public virtual void ShowPrimaryStats()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Primary stats:");
            Console.WriteLine("--------------------");
            Console.WriteLine("Strenght: " + Strenght);
            Console.WriteLine("Dexterity: " + Dexterity);
            Console.WriteLine("Intelligence: " + Intelligence);
        }

        ///Virtual method to calculate provided stats
        ///Calculate new stats based on the provided increase
        ///ATT!! WEAPON AND ARMOR STATS NOT YET CALCULATED
        public virtual void CalculateCurrentStats(double calculateStrenght, double calculateDexterity, double calculateIntelligence)
        {
            double calculatedStrenght = calculateStrenght + Strenght;
            double calculalatedDexterity = calculateDexterity + Dexterity;
            double calculatedIntelligence = calculateIntelligence + Intelligence;

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

    }
}

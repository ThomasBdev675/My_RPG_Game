using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    public class AvailableClasses
    {
        ///Define Mage class and their attributes
        public class Mage
        {
            protected double strenght = 1;
            protected double dexterity = 1;
            protected double intelligence = 8;

            ///Show stats
            public void ShowStats()
            {   ///Show base stats             
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                ///Run stat calculation
                CalculateCurrentStats();  
            }

            ///Calculate current stats  NOT YET DONE
            protected void CalculateCurrentStats()
            {
                strenght += 1;
                dexterity += 1;
                intelligence += 1;
                Console.WriteLine("Calculated Strenght: " + strenght );
                Console.WriteLine("Calculated Dexterity: " + dexterity );
                Console.WriteLine("Calculated Intelligence: " + intelligence );

            }
        }

        public class Ranger
        {
            protected double strenght = 1;
            protected double dexterity = 7;
            protected double intelligence = 1;

            ///Show stats
            public void ShowStats()
            {   ///Show base stats             
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                ///Run stat calculation
                CalculateCurrentStats();
            }

            ///Calculate current stats  NOT YET DONE
            protected void CalculateCurrentStats()
            {
                strenght += 1;
                dexterity += 1;
                intelligence += 1;
                Console.WriteLine("Calculated Strenght: " + strenght);
                Console.WriteLine("Calculated Dexterity: " + dexterity);
                Console.WriteLine("Calculated Intelligence: " + intelligence);

            }
        }

        public class Rogue
        {
            protected double strenght = 2;
            protected double dexterity = 6;
            protected double intelligence = 1;

            ///Show stats
            public void ShowStats()
            {   ///Show base stats             
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                ///Run stat calculation
                CalculateCurrentStats();
            }

            ///Calculate current stats  NOT YET DONE
            protected void CalculateCurrentStats()
            {
                strenght += 1;
                dexterity += 1;
                intelligence += 1;
                Console.WriteLine("Calculated Strenght: " + strenght);
                Console.WriteLine("Calculated Dexterity: " + dexterity);
                Console.WriteLine("Calculated Intelligence: " + intelligence);

            }
        }

        public class Warrior
        {
            protected double strenght = 5;
            protected double dexterity = 2;
            protected double intelligence = 1;
            ///Show stats
            public void ShowStats()
            {   ///Show base stats             
                Console.WriteLine("Strenght: " + strenght);
                Console.WriteLine("Dexterity: " + dexterity);
                Console.WriteLine("Intelligence: " + intelligence);
                ///Run stat calculation
                CalculateCurrentStats();
            }

            ///Calculate current stats  NOT YET DONE
            protected void CalculateCurrentStats()
            {
                strenght += 1;
                dexterity += 1;
                intelligence += 1;
                Console.WriteLine("Calculated Strenght: " + strenght);
                Console.WriteLine("Calculated Dexterity: " + dexterity);
                Console.WriteLine("Calculated Intelligence: " + intelligence);

            }
        }
    }
}




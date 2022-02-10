using System;

namespace My_RPG_Game
{
    class Program
    {
        ///Character Selector
        ///Available values are: Mage, Ranger, Rogue, Warrior
        static void CharacterSelector(string myCharacterSelection)            
            {
                try
                {
                    Console.WriteLine("Character selected: " + myCharacterSelection);
                    switch (myCharacterSelection)
                {
                    case "Mage":
                        AvailableClasses.Mage MyMage = new AvailableClasses.Mage();
                        MyMage.ShowStats();
                        break;
                    case "Ranger":
                        AvailableClasses.Ranger MyRanger = new AvailableClasses.Ranger();
                        MyRanger.ShowStats();
                        break;
                    case "Rogue":
                        AvailableClasses.Rogue MyRogue = new AvailableClasses.Rogue();
                        MyRogue.ShowStats();
                        break;
                    case "Warrior":
                        AvailableClasses.Warrior MyWarrior = new AvailableClasses.Warrior();
                        MyWarrior.ShowStats();
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
                Console.WriteLine("Character Selection done");
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our RPG console game");
            CharacterSelector("test");

        }
    }
    
    
}

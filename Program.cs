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
                        Classtypes.Mage MyMage = new Classtypes.Mage();
                        MyMage.Stats(1,1,1);
                        break;
                    case "Ranger":
                        Classtypes.Ranger MyRanger = new Classtypes.Ranger();
                        MyRanger.Stats(1,1,1);
                        break;
                    case "Rogue":
                        Classtypes.Rogue MyRogue = new Classtypes.Rogue();
                        MyRogue.Stats(1,1,1);
                        break;
                    case "Warrior":
                        Classtypes.Warrior MyWarrior = new Classtypes.Warrior();
                        MyWarrior.Stats(1,1,1);
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
            CharacterSelector("Warrior");

        }
    }
    
    
}

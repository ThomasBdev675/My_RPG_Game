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
                        Charactertypes.Mage MyMage = new Charactertypes.Mage();
                        MyMage.Stats();
                        MyMage.Stats(1, 1, 1);
                        MyMage.LevelUp(1);
                        break;
                    case "Ranger":
                        Charactertypes.Ranger MyRanger = new Charactertypes.Ranger();
                        MyRanger.Stats();
                        MyRanger.Stats(1,1,1);
                        MyRanger.LevelUp(1);
                        break;
                    case "Rogue":
                        Charactertypes.Rogue MyRogue = new Charactertypes.Rogue();
                        MyRogue.Stats();
                        MyRogue.Stats(1, 1, 1);
                        MyRogue.LevelUp(1);
                        break;
                    case "Warrior":
                        Charactertypes.Warrior MyWarrior = new Charactertypes.Warrior();
                        MyWarrior.Stats();
                        MyWarrior.Stats(1, 1, 1);
                        MyWarrior.LevelUp(1);
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




        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome to our RPG console game");
            Console.WriteLine("-------------------------------");
            CharacterSelector("Mage");

        }
    }
    
    
}

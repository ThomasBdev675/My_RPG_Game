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
                        MyMage.BaseStats();
                        MyMage.BaseStats(1, 1, 1);
                        MyMage.LevelUp();
                        break;
                    case "Ranger":
                        Charactertypes.Ranger MyRanger = new Charactertypes.Ranger();
                        MyRanger.BaseStats();
                        MyRanger.BaseStats(1, 1, 1);
                        MyRanger.LevelUp();
                        break;
                    case "Rogue":
                        Charactertypes.Rogue MyRogue = new Charactertypes.Rogue();
                        MyRogue.BaseStats();
                        MyRogue.BaseStats(1, 1, 1);
                        MyRogue.LevelUp();
                        break;
                    case "Warrior":
                        Charactertypes.Warrior MyWarrior = new Charactertypes.Warrior();
                        MyWarrior.BaseStats();
                        MyWarrior.BaseStats(1, 1, 1);
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



        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome to our RPG console game");
            Console.WriteLine("-------------------------------");
            CharacterSelector("Warrior");

                       

        }
    }
    
    
}

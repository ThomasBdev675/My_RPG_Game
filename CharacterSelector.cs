using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_RPG_Game
{
    class CharacterSelector
    {
        ///Character Selector
        ///Available values are: Mage, Ranger, Rogue, Warrior
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
                        MyMage.BaseStats();
                        MyMage.CalculateCurrentStats(1, 1, 1);
                        MyMage.LevelUp();
                        break;
                    case "Ranger":
                        Charactertypes.Ranger MyRanger = new Charactertypes.Ranger();
                        MyRanger.BaseStats();
                        MyRanger.CalculateCurrentStats(1, 1, 1);
                        MyRanger.LevelUp();
                        break;
                    case "Rogue":
                        Charactertypes.Rogue MyRogue = new Charactertypes.Rogue();
                        MyRogue.BaseStats();
                        MyRogue.CalculateCurrentStats(1, 1, 1);
                        MyRogue.LevelUp();
                        break;
                    case "Warrior":
                        Charactertypes.Warrior MyWarrior = new Charactertypes.Warrior();
                        MyWarrior.BaseStats();
                        MyWarrior.CalculateCurrentStats(1, 1, 1);
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

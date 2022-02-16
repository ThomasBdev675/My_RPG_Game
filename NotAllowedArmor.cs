using System;
using System.Runtime.Serialization;

namespace My_RPG_Game
{
    [Serializable]
    internal class NotAllowedArmor : Exception
    {
        public NotAllowedArmor()
        {
            Console.WriteLine("You are trying to equip a not allowed Armor.");
            System.Environment.Exit(0);
        }

        public NotAllowedArmor(string message) : base(message)
        {
            Console.WriteLine("You are trying to equip a not allowed Armor.");
            System.Environment.Exit(0);
        }

        public NotAllowedArmor(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("You are trying to equip a not allowed Armor.");
            System.Environment.Exit(0);
        }

        protected NotAllowedArmor(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Console.WriteLine("You are trying to equip a not allowed Armor.");
            System.Environment.Exit(0);
        }
    }
}
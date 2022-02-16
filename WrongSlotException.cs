using System;
using System.Runtime.Serialization;

namespace My_RPG_Game
{
    [Serializable]
    internal class WrongSlotException : Exception
    {
        public WrongSlotException()
        {
            Console.WriteLine("You are trying to equip an Item within a wrong Slot.");
            System.Environment.Exit(0);
        }

        public WrongSlotException(string message) : base(message)
        {            
            Console.WriteLine("You are trying to equip an Item within a wrong Slot.");
            System.Environment.Exit(0);
        }

        public WrongSlotException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("You are trying to equip an Item within a wrong Slot.");
            System.Environment.Exit(0);
        }

        protected WrongSlotException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Console.WriteLine("You are trying to equip an Item within a wrong Slot.");
            System.Environment.Exit(0);
        }
    }
}
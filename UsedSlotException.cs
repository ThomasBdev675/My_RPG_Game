using System;
using System.Runtime.Serialization;

namespace My_RPG_Game
{
    [Serializable]
    internal class UsedSlotException : Exception
    {
        public UsedSlotException()
        {
            Console.WriteLine("Your Slot is already used and blocked");
            System.Environment.Exit(0);
        }

        public UsedSlotException(string message) : base(message)
        {
            Console.WriteLine("Your Slot is already used and blocked");
            System.Environment.Exit(0);
        }

        public UsedSlotException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("Your Slot is already used and blocked");
            System.Environment.Exit(0);
        }

        protected UsedSlotException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Console.WriteLine("Your Slot is already used and blocked");
            System.Environment.Exit(0);
        }
    }
}
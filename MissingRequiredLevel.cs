using System;
using System.Runtime.Serialization;

namespace My_RPG_Game
{
    [Serializable]
    internal class MissingRequiredLevel : Exception
    {
        public MissingRequiredLevel()
        {
            Console.WriteLine("Your Level is no sufficient, please level up first");
            System.Environment.Exit(0);
        }

        public MissingRequiredLevel(string message) : base(message)
        {
            Console.WriteLine("Your Level is no sufficient, please level up first");
            System.Environment.Exit(0);
        }

        public MissingRequiredLevel(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("Your Level is no sufficient, please level up first");
            System.Environment.Exit(0);
        }

        protected MissingRequiredLevel(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Console.WriteLine("Your Level is no sufficient, please level up first");
            System.Environment.Exit(0);
        }
    }
}
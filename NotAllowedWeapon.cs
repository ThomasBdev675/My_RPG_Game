using System;
using System.Runtime.Serialization;

namespace My_RPG_Game
{
    [Serializable]
    internal class NotAllowedWeapon : Exception
    {
        public NotAllowedWeapon()
        {
            Console.WriteLine("You are trying to equip a not allowed Weapon.");
            System.Environment.Exit(0);
        }

        public NotAllowedWeapon(string message) : base(message)
        {
            Console.WriteLine("You are trying to equip a not allowed Weapon.");
            System.Environment.Exit(0);
        }

        public NotAllowedWeapon(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("You are trying to equip a not allowed Weapon.");
            System.Environment.Exit(0);
        }

        protected NotAllowedWeapon(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Console.WriteLine("You are trying to equip a not allowed Weapon.");
            System.Environment.Exit(0);
        }
    }
}
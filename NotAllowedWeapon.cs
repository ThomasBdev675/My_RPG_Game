using System;
using System.Runtime.Serialization;

namespace My_RPG_Game
{
    [Serializable]
    internal class NotAllowedWeapon : Exception
    {
        public NotAllowedWeapon()
        {
        }

        public NotAllowedWeapon(string message) : base(message)
        {
        }

        public NotAllowedWeapon(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotAllowedWeapon(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
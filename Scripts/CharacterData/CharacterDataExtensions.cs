using System.Collections.Generic;

namespace MultiplayerARPG
{
    public static partial class CharacterDataExtensions
    {
        public static System.Type ClassType { get; private set; }

        static CharacterDataExtensions()
        {
            ClassType = typeof(CharacterDataExtensions);
        }
    }
}

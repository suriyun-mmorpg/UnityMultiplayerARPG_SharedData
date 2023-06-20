namespace MultiplayerARPG
{
    [System.Serializable]
    public class CharacterDataBoolean
    {
        public int hashedKey;
        public bool value;

        public CharacterDataBoolean Clone()
        {
            return new CharacterDataBoolean()
            {
                hashedKey = hashedKey,
                value = value,
            };
        }

        public static CharacterDataBoolean Create(int hashedKey, bool value = false)
        {
            return new CharacterDataBoolean()
            {
                hashedKey = hashedKey,
                value = value,
            };
        }
    }
}
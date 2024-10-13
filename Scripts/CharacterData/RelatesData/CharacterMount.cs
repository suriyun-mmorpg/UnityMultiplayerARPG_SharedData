namespace MultiplayerARPG
{
    public enum MountType : byte
    {
        None,
        Skill,
        MountItem,
        Custom = 254,
    }

    [System.Serializable]
    public partial struct CharacterMount
    {
        public MountType type;
        public int dataId;
        public int level;
        public int exp;

        public CharacterMount Clone()
        {
            CharacterMount result = new CharacterMount()
            {
                type = type,
                dataId = dataId,
                level = level,
                exp = exp,
            };
            return result;
        }

        public static CharacterMount Create(MountType type, int dataId, int level = 1, int exp = 0)
        {
            return new CharacterMount()
            {
                type = type,
                dataId = dataId,
                level = level,
                exp = exp,
            };
        }
    }
}

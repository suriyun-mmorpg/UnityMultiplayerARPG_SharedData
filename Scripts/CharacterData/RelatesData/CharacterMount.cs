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
    }
}

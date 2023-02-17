namespace MultiplayerARPG
{
    public enum SummonType : byte
    {
        None,
        Skill,
        PetItem,
        Custom = byte.MaxValue
    }

    [System.Serializable]
    public partial class CharacterSummon
    {
        public static readonly CharacterSummon Empty = new CharacterSummon();
        public string id;
        public SummonType type;
        public int dataId;
        public float summonRemainsDuration;
        public uint objectId;
        public int level;
        public int exp;
        public int currentHp;
        public int currentMp;
    }
}

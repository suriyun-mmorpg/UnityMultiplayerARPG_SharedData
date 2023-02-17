namespace MultiplayerARPG
{
    public enum BuffType : byte
    {
        SkillBuff,
        SkillDebuff,
        PotionBuff,
        GuildSkillBuff,
        StatusEffect,
    }

    [System.Serializable]
    public partial class CharacterBuff
    {
        public static readonly CharacterBuff Empty = new CharacterBuff();
        public string id;
        public BuffType type;
        public int dataId;
        public int level;
        public float buffRemainsDuration;
    }
}

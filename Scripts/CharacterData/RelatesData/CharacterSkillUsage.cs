namespace MultiplayerARPG
{
    public enum SkillUsageType : byte
    {
        Skill,
        GuildSkill,
        UsableItem,
    }

    [System.Serializable]
    public partial class CharacterSkillUsage
    {
        public static readonly CharacterSkillUsage Empty = new CharacterSkillUsage();
        public SkillUsageType type;
        public int dataId;
        public float coolDownRemainsDuration;
    }
}

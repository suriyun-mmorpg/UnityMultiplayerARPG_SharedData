namespace MultiplayerARPG
{
    public enum SkillUsageType : byte
    {
        Skill,
        GuildSkill,
        UsableItem,
    }

    public partial class CharacterSkillUsage
    {
        public static readonly CharacterSkillUsage Empty = new CharacterSkillUsage();
        public SkillUsageType type;
        public int dataId;
        public float coolDownRemainsDuration;
    }
}

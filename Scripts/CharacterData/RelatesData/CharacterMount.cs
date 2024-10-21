namespace MultiplayerARPG
{
    public enum MountType : byte
    {
        None,
        Skill,
        MountItem,
        SkillBuff,
        SkillDebuff,
        PotionBuff,
        GuildSkillBuff,
        StatusEffect,
        Custom = 254,
    }

    [System.Serializable]
    public partial struct CharacterMount
    {
        public static readonly CharacterMount Empty = new CharacterMount();
        public MountType type;
        public int dataId;
        public float mountRemainsDuration;
        public int level;
        public int currentHp;

        public bool IsBuffMount()
        {
            switch (type)
            {
                case MountType.SkillBuff:
                case MountType.SkillDebuff:
                case MountType.PotionBuff:
                case MountType.GuildSkillBuff:
                case MountType.StatusEffect:
                    return true;
            }
            return false;
        }

        public CharacterMount Clone()
        {
            CharacterMount result = new CharacterMount()
            {
                type = type,
                dataId = dataId,
                mountRemainsDuration = mountRemainsDuration,
                level = level,
                currentHp = currentHp,
            };
            return result;
        }
    }
}

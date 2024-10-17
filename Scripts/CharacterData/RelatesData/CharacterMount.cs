using LiteNetLib.Utils;

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
    public partial struct CharacterMount : INetSerializable
    {
        public static readonly CharacterMount Empty = new CharacterMount();
        public MountType type;
        public int dataId;
        public float mountRemainsDuration;
        public int level;
        public int currentHp;

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

        public void Serialize(NetDataWriter writer)
        {
            writer.Put((byte)type);
            if (type != MountType.None)
            {
                writer.PutPackedInt(dataId);
                writer.Put(mountRemainsDuration);
                writer.PutPackedInt(level);
                writer.PutPackedInt(currentHp);
            }
        }

        public void Deserialize(NetDataReader reader)
        {
            type = (MountType)reader.GetByte();
            if (type != MountType.None)
            {
                dataId = reader.GetPackedInt();
                mountRemainsDuration = reader.GetFloat();
                level = reader.GetPackedInt();
                currentHp = reader.GetPackedInt();
            }
        }
    }
}

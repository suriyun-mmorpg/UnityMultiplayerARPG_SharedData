using LiteNetLib.Utils;

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
    public partial struct CharacterMount : INetSerializable
    {
        public static readonly CharacterMount Empty = new CharacterMount();
        public MountType type;
        public int dataId;
        public float mountRemainsDuration;
        public uint objectId;
        public int level;
        public int exp;
        public int currentHp;
        public int currentMp;

        public CharacterMount Clone()
        {
            CharacterMount result = new CharacterMount()
            {
                type = type,
                dataId = dataId,
                mountRemainsDuration = mountRemainsDuration,
                objectId = objectId,
                level = level,
                exp = exp,
                currentHp = currentHp,
                currentMp = currentMp,
            };
            return result;
        }

        public static CharacterMount Create(MountType type, int dataId)
        {
            return new CharacterMount()
            {
                type = type,
                dataId = dataId,
            };
        }

        public void Serialize(NetDataWriter writer)
        {
            writer.Put((byte)type);
            if (type != MountType.None)
            {
                writer.PutPackedInt(dataId);
                writer.Put(mountRemainsDuration);
                writer.PutPackedUInt(objectId);
                writer.PutPackedInt(level);
                writer.PutPackedInt(exp);
                writer.PutPackedInt(currentHp);
                writer.PutPackedInt(currentMp);
            }
        }

        public void Deserialize(NetDataReader reader)
        {
            type = (MountType)reader.GetByte();
            if (type != MountType.None)
            {
                dataId = reader.GetPackedInt();
                mountRemainsDuration = reader.GetFloat();
                objectId = reader.GetPackedUInt();
                level = reader.GetPackedInt();
                exp = reader.GetPackedInt();
                currentHp = reader.GetPackedInt();
                currentMp = reader.GetPackedInt();
            }
        }
    }
}

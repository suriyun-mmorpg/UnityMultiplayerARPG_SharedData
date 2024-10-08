using LiteNetLib.Utils;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial struct CharacterMount : INetSerializable
    {
        public byte mountType;
        public int dataId;
        public int level;
        public int exp;
        public bool isMounted;
        public long unmountTime;

        public void Deserialize(NetDataReader reader)
        {
            mountType = reader.GetByte();
            dataId = reader.GetPackedInt();
            level = reader.GetPackedInt();
            exp = reader.GetPackedInt();
            isMounted = reader.GetBool();
            if (isMounted)
                unmountTime = reader.GetPackedLong();
        }

        public void Serialize(NetDataWriter writer)
        {
            writer.Put(mountType);
            writer.PutPackedInt(dataId);
            writer.PutPackedInt(level);
            writer.PutPackedInt(exp);
            writer.Put(isMounted);
            if (isMounted)
                writer.PutPackedLong(unmountTime);
        }
    }
}

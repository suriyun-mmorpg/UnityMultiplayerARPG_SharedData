using LiteNetLib.Utils;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial struct FormattedGameMessage : INetSerializable
    {
        public UIFormatKeys format;
        public string[] args;

        public void Deserialize(NetDataReader reader)
        {
            format = (UIFormatKeys)reader.GetPackedUShort();
            args = reader.GetArray<string>();
        }

        public void Serialize(NetDataWriter writer)
        {
            writer.PutPackedUShort((ushort)format);
            writer.PutArray<string>(args);
        }
    }
}

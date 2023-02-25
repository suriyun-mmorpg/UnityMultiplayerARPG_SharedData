using Cysharp.Text;
using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class CharacterItem
    {
        public static readonly CharacterItem Empty = new CharacterItem();
        public string id;
        public int dataId;
        public int level;
        public int amount;
        public byte equipSlotIndex;
        public float durability;
        public int exp;
        public float lockRemainsDuration;
        public long expireTime;
        public int randomSeed;
        public int ammo;
        public List<int> sockets = new List<int>();

        public List<int> Sockets
        {
            get
            {
                if (sockets == null)
                    sockets = new List<int>();
                return sockets;
            }
        }

        public List<int> ReadSockets(string sockets, char separator = ';')
        {
            Sockets.Clear();
            string[] splitTexts = sockets.Split(separator);
            foreach (string text in splitTexts)
            {
                if (string.IsNullOrEmpty(text))
                    continue;
                Sockets.Add(int.Parse(text));
            }
            return Sockets;
        }

        public string WriteSockets(char separator = ';')
        {
            using (Utf16ValueStringBuilder stringBuilder = ZString.CreateStringBuilder(true))
            {
                foreach (int socket in Sockets)
                {
                    stringBuilder.Append(socket);
                    stringBuilder.Append(separator);
                }
                return stringBuilder.ToString();
            }
        }
    }
}

using Cysharp.Text;
using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial struct CharacterItem
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
        public int ammoDataId;
        public int ammo;
        public List<int> sockets;
        public byte version;

        public List<int> ReadSockets(string socketsString, char separator = ';')
        {
            if (sockets == null)
                sockets = new List<int>();
            sockets.Clear();
            string[] splitTexts = socketsString.Split(separator);
            foreach (string text in splitTexts)
            {
                if (string.IsNullOrEmpty(text))
                    continue;
                sockets.Add(int.Parse(text));
            }
            return sockets;
        }

        public string WriteSockets(char separator = ';')
        {
            using (Utf16ValueStringBuilder stringBuilder = ZString.CreateStringBuilder(true))
            {
                if (sockets != null && sockets.Count > 0)
                {
                    foreach (int socket in sockets)
                    {
                        stringBuilder.Append(socket);
                        stringBuilder.Append(separator);
                    }
                }
                return stringBuilder.ToString();
            }
        }

        public CharacterItem Clone(bool generateNewId = false)
        {
            List<int> sockets = this.sockets == null ? new List<int>() : new List<int>(this.sockets);
            return new CharacterItem()
            {
                id = generateNewId ? GenericUtils.GetUniqueId() : id,
                dataId = dataId,
                level = level,
                amount = amount,
                equipSlotIndex = equipSlotIndex,
                durability = durability,
                exp = exp,
                lockRemainsDuration = lockRemainsDuration,
                expireTime = expireTime,
                randomSeed = randomSeed,
                ammoDataId = ammoDataId,
                ammo = ammo,
                sockets = sockets,
                version = version,
            };
        }
    }
}

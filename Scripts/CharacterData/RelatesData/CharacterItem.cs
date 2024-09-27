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

        public bool TryGetSocketEnhancerItemDataId(int index, out int dataId)
        {
            dataId = 0;
            if (index >= 0 && sockets != null && index < sockets.Count && sockets[index] != 0)
            {
                dataId = sockets[index];
                return true;
            }
            return false;
        }

        public bool TryGetSocketEnhancerItem(int index, out BaseItem data)
        {
            data = null;
            return TryGetSocketEnhancerItemDataId(index, out int dataId) && GameInstance.Items.TryGetValue(dataId, out data);
        }

        public List<int> ReadSockets(string socketsString, char separator = ';')
        {
            sockets = socketsString.ReadCharacterItemSockets(separator);
            return sockets;
        }

        public string WriteSockets(char separator = ';')
        {
            return sockets.WriteCharacterItemSockets(separator);
        }

        public CharacterItem Clone(bool generateNewId = false)
        {
            List<int> sockets = this.sockets == null ? new List<int>() : new List<int>(this.sockets);
            return new CharacterItem()
            {
                id = generateNewId || string.IsNullOrWhiteSpace(id) ? GenericUtils.GetUniqueId() : id,
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
                sockets = new List<int>(sockets),
                version = version,
            };
        }
    }
}

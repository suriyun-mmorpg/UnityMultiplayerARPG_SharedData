using System.Collections.Generic;

namespace MultiplayerARPG
{
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
    }
}

using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class PlayerCharacterData : CharacterData, IPlayerCharacterData
    {
        private List<CharacterHotkey> _hotkeys = new List<CharacterHotkey>();
        private List<CharacterQuest> _quests = new List<CharacterQuest>();
        private List<CharacterCurrency> _currencies = new List<CharacterCurrency>();
        private List<CharacterDataBoolean> _serverBools = new List<CharacterDataBoolean>();
        private List<CharacterDataInt32> _serverInts = new List<CharacterDataInt32>();
        private List<CharacterDataFloat32> _serverFloats = new List<CharacterDataFloat32>();
        private List<CharacterDataBoolean> _privateBools = new List<CharacterDataBoolean>();
        private List<CharacterDataInt32> _privateInts = new List<CharacterDataInt32>();
        private List<CharacterDataFloat32> _privateFloats = new List<CharacterDataFloat32>();
        private List<CharacterDataBoolean> _publicBools = new List<CharacterDataBoolean>();
        private List<CharacterDataInt32> _publicInts = new List<CharacterDataInt32>();
        private List<CharacterDataFloat32> _publicFloats = new List<CharacterDataFloat32>();

        public string UserId { get; set; }
        public int FactionId { get; set; }
        public float StatPoint { get; set; }
        public float SkillPoint { get; set; }
        public int Gold { get; set; }
        public int UserGold { get; set; }
        public int UserCash { get; set; }
        public int PartyId { get; set; }
        public int GuildId { get; set; }
        public byte GuildRole { get; set; }
        public int SharedGuildExp { get; set; }
        public string CurrentMapName { get; set; }
        public Vec3 CurrentPosition { get; set; }
        public Vec3 CurrentRotation { get; set; }
        public string RespawnMapName { get; set; }
        public Vec3 RespawnPosition { get; set; }
        public int MountDataId { get; set; }
        public long LastDeadTime { get; set; }
        public long UnmuteTime { get; set; }
        public long LastUpdate { get; set; }
        public bool IsPkOn { get; set; }
        public long LastPkOnTime { get; set; }
        public int PkPoint { get; set; }
        public int ConsecutivePkKills { get; set; }

        public IList<CharacterHotkey> Hotkeys
        {
            get { return _hotkeys; }
            set
            {
                _hotkeys = new List<CharacterHotkey>();
                _hotkeys.AddRange(value);
            }
        }

        public IList<CharacterQuest> Quests
        {
            get { return _quests; }
            set
            {
                _quests = new List<CharacterQuest>();
                _quests.AddRange(value);
            }
        }

        public IList<CharacterCurrency> Currencies
        {
            get { return _currencies; }
            set
            {
                _currencies = new List<CharacterCurrency>();
                _currencies.AddRange(value);
            }
        }

        public IList<CharacterDataBoolean> ServerBools
        {
            get { return _serverBools; }
            set
            {
                _serverBools = new List<CharacterDataBoolean>();
                _serverBools.AddRange(value);
            }
        }

        public IList<CharacterDataInt32> ServerInts
        {
            get { return _serverInts; }
            set
            {
                _serverInts = new List<CharacterDataInt32>();
                _serverInts.AddRange(value);
            }
        }

        public IList<CharacterDataFloat32> ServerFloats
        {
            get { return _serverFloats; }
            set
            {
                _serverFloats = new List<CharacterDataFloat32>();
                _serverFloats.AddRange(value);
            }
        }

        public IList<CharacterDataBoolean> PrivateBools
        {
            get { return _privateBools; }
            set
            {
                _privateBools = new List<CharacterDataBoolean>();
                _privateBools.AddRange(value);
            }
        }

        public IList<CharacterDataInt32> PrivateInts
        {
            get { return _privateInts; }
            set
            {
                _privateInts = new List<CharacterDataInt32>();
                _privateInts.AddRange(value);
            }
        }

        public IList<CharacterDataFloat32> PrivateFloats
        {
            get { return _privateFloats; }
            set
            {
                _privateFloats = new List<CharacterDataFloat32>();
                _privateFloats.AddRange(value);
            }
        }

        public IList<CharacterDataBoolean> PublicBools
        {
            get { return _publicBools; }
            set
            {
                _publicBools = new List<CharacterDataBoolean>();
                _publicBools.AddRange(value);
            }
        }

        public IList<CharacterDataInt32> PublicInts
        {
            get { return _publicInts; }
            set
            {
                _publicInts = new List<CharacterDataInt32>();
                _publicInts.AddRange(value);
            }
        }

        public IList<CharacterDataFloat32> PublicFloats
        {
            get { return _publicFloats; }
            set
            {
                _publicFloats = new List<CharacterDataFloat32>();
                _publicFloats.AddRange(value);
            }
        }
    }

    public class PlayerCharacterDataLastUpdateComparer : IComparer<PlayerCharacterData>
    {
        private int _sortMultiplier = 1;

        public PlayerCharacterDataLastUpdateComparer Asc()
        {
            _sortMultiplier = 1;
            return this;
        }

        public PlayerCharacterDataLastUpdateComparer Desc()
        {
            _sortMultiplier = -1;
            return this;
        }

        public int Compare(PlayerCharacterData x, PlayerCharacterData y)
        {
            if (x == null && y == null)
                return 0;

            if (x == null && y != null)
                return -1;

            if (x != null && y == null)
                return 1;

            return x.LastUpdate.CompareTo(y.LastUpdate) * _sortMultiplier;
        }
    }
}

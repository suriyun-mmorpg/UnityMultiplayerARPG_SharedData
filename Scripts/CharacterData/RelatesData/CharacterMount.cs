namespace MultiplayerARPG
{
    [System.Serializable]
    public partial struct CharacterMount
    {
        public byte mountType;
        public int dataId;
        public int level;
        public int exp;
        public bool isMounted;
        public long unmountTime;
    }
}

namespace MultiplayerARPG
{
    [System.Serializable]
    public struct MinimalItem
    {
        public string Id { get; set; }
        public int DataId { get; set; }
        public int ItemType { get; set; }
        public int SellPrice { get; set; }
        public float Weight { get; set; }
        public int MaxStack { get; set; }
        public int MaxLevel { get; set; }
        public float LockDuration { get; set; }
        public float ExpireDuration { get; set; }
        public float MaxDurability { get; set; }
        public bool DestroyIfBroken { get; set; }
        public int MaxSocket { get; set; }
        public int AmmoCapacity { get; set; }
    }
}
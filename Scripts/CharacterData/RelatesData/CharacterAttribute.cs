namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class CharacterAttribute
    {
        public static readonly CharacterAttribute Empty = new CharacterAttribute();
        public int dataId;
        public int amount;
    }
}

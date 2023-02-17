namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class CharacterCurrency
    {
        public static readonly CharacterCurrency Empty = new CharacterCurrency();
        public int dataId;
        public int amount;
    }
}

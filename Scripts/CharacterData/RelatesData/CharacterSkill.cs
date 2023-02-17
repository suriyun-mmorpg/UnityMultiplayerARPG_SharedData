namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class CharacterSkill
    {
        public static readonly CharacterSkill Empty = new CharacterSkill();
        public int dataId;
        public int level;
    }
}

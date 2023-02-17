namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class EquipWeapons
    {
        public CharacterItem rightHand;
        public CharacterItem leftHand;

        public EquipWeapons()
        {
            rightHand = new CharacterItem();
            leftHand = new CharacterItem();
        }
    }
}

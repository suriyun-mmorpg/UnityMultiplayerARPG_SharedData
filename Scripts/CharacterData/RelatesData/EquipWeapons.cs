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

        public EquipWeapons Clone(bool generateNewId = false)
        {
            return new EquipWeapons()
            {
                rightHand = rightHand.Clone(generateNewId),
                leftHand = leftHand.Clone(generateNewId),
            };
        }
    }
}

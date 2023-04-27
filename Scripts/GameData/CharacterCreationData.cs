using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class CharacterCreationData
    {
        public Dictionary<int, Dictionary<int, PlayerCharacterData>> AvailableCharacters = new Dictionary<int, Dictionary<int, PlayerCharacterData>>();
        public HashSet<int> AvailableFactionIds = new HashSet<int>();

        public bool CanCreateCharacter(int entityId, int dataId, int factionId)
        {
            return AvailableCharacters.ContainsKey(entityId) && AvailableCharacters[entityId].ContainsKey(dataId) && AvailableFactionIds.Contains(factionId);
        }

        public PlayerCharacterData GetCreateCharacterData(string characterName, int entity, int dataId, int factionId)
        {
            PlayerCharacterData result = AvailableCharacters[entity][dataId].CloneTo(new PlayerCharacterData());
            result.CharacterName = characterName;
            result.FactionId = factionId;
            return result;
        }
    }
}

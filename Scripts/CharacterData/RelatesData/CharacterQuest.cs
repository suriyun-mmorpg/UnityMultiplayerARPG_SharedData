using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class CharacterQuest
    {
        public static readonly CharacterQuest Empty = new CharacterQuest();
        public int dataId;
        public bool isComplete;
        public bool isTracking;
        public Dictionary<int, int> killedMonsters = new Dictionary<int, int>();
        public List<int> completedTasks = new List<int>();
    }
}

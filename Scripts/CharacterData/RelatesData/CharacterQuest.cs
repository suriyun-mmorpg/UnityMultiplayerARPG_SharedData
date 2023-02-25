using Cysharp.Text;
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

        public Dictionary<int, int> KilledMonsters
        {
            get
            {
                if (killedMonsters == null)
                    killedMonsters = new Dictionary<int, int>();
                return killedMonsters;
            }
        }

        public List<int> CompletedTasks
        {
            get
            {
                if (completedTasks == null)
                    completedTasks = new List<int>();
                return completedTasks;
            }
        }

        public Dictionary<int, int> ReadKilledMonsters(string killMonsters)
        {
            KilledMonsters.Clear();
            string[] splitSets = killMonsters.Split(';');
            foreach (string set in splitSets)
            {
                if (string.IsNullOrEmpty(set))
                    continue;
                string[] splitData = set.Split(':');
                if (splitData.Length != 2)
                    continue;
                KilledMonsters[int.Parse(splitData[0])] = int.Parse(splitData[1]);
            }
            return KilledMonsters;
        }

        public string WriteKilledMonsters()
        {
            using (Utf16ValueStringBuilder stringBuilder = ZString.CreateStringBuilder(true))
            {
                foreach (KeyValuePair<int, int> keyValue in KilledMonsters)
                {
                    stringBuilder.Append(keyValue.Key);
                    stringBuilder.Append(':');
                    stringBuilder.Append(keyValue.Value);
                    stringBuilder.Append(';');
                }
                return stringBuilder.ToString();
            }
        }

        public List<int> ReadCompletedTasks(string completedTasks)
        {
            CompletedTasks.Clear();
            string[] splitTexts = completedTasks.Split(';');
            foreach (string text in splitTexts)
            {
                if (string.IsNullOrEmpty(text))
                    continue;
                CompletedTasks.Add(int.Parse(text));
            }
            return CompletedTasks;
        }

        public string WriteCompletedTasks()
        {
            using (Utf16ValueStringBuilder stringBuilder = ZString.CreateStringBuilder(true))
            {
                foreach (int completedTask in CompletedTasks)
                {
                    stringBuilder.Append(completedTask);
                    stringBuilder.Append(';');
                }
                return stringBuilder.ToString();
            }
        }
    }
}

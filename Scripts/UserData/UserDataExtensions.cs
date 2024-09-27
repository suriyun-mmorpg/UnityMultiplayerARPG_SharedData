using Cysharp.Text;
using System.Collections.Generic;

namespace MultiplayerARPG
{
    public static partial class UserDataExtensions
    {
        public static List<UnlockableContent> ReadUnlockableContents(this string unlockableContentsString)
        {
            List<UnlockableContent> unlockableContents = new List<UnlockableContent>();
            string[] splitSets = unlockableContentsString.Split(';');
            foreach (string set in splitSets)
            {
                if (string.IsNullOrEmpty(set))
                    continue;
                string[] splitData = set.Split(':');
                if (splitData.Length != 4)
                    continue;
                unlockableContents.Add(new UnlockableContent()
                {
                    type = (UnlockableContentType)byte.Parse(splitData[0]),
                    dataId = int.Parse(splitData[1]),
                    progression = int.Parse(splitData[2]),
                    unlocked = bool.Parse(splitData[3]),
                });
            }
            return unlockableContents;
        }

        public static string WriteUnlockableContents(this List<UnlockableContent> unlockableContents)
        {
            if (unlockableContents == null || unlockableContents.Count == 0)
                return string.Empty;

            using (Utf16ValueStringBuilder stringBuilder = ZString.CreateStringBuilder(false))
            {
                foreach (UnlockableContent unlockableContent in unlockableContents)
                {
                    stringBuilder.Append((byte)unlockableContent.type);
                    stringBuilder.Append(':');
                    stringBuilder.Append(unlockableContent.dataId);
                    stringBuilder.Append(':');
                    stringBuilder.Append(unlockableContent.progression);
                    stringBuilder.Append(':');
                    stringBuilder.Append(unlockableContent.unlocked);
                    stringBuilder.Append(';');
                }
                return stringBuilder.ToString();
            }
        }
    }
}

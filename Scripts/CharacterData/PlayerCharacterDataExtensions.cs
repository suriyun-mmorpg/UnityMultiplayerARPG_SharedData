namespace MultiplayerARPG
{
    public static partial class PlayerCharacterDataExtensions
    {
        public static System.Type ClassType { get; private set; }

        static PlayerCharacterDataExtensions()
        {
            ClassType = typeof(PlayerCharacterDataExtensions);
        }

        public static T CloneTo<T>(this IPlayerCharacterData from, T to,
            bool withEquipWeapons = true,
            bool withAttributes = true,
            bool withSkills = true,
            bool withSkillUsages = true,
            bool withBuffs = true,
            bool withEquipItems = true,
            bool withNonEquipItems = true,
            bool withSummons = true,
            bool withHotkeys = true,
            bool withQuests = true,
            bool withCurrencies = true,
            bool withServerCustomData = true,
            bool withPrivateCustomData = true,
            bool withPublicCustomData = true,
            bool withCurrentLocationData = true,
            bool generateNewIdForRelatesData = false) where T : IPlayerCharacterData
        {
            to.Id = from.Id;
            to.DataId = from.DataId;
            to.EntityId = from.EntityId;
            to.UserId = from.UserId;
            to.FactionId = from.FactionId;
            to.CharacterName = from.CharacterName;
            to.Level = from.Level;
            to.Exp = from.Exp;
            to.CurrentHp = from.CurrentHp;
            to.CurrentMp = from.CurrentMp;
            to.CurrentStamina = from.CurrentStamina;
            to.CurrentFood = from.CurrentFood;
            to.CurrentWater = from.CurrentWater;
            to.StatPoint = from.StatPoint;
            to.SkillPoint = from.SkillPoint;
            to.Gold = from.Gold;
            to.UserGold = from.UserGold;
            to.UserCash = from.UserCash;
            to.PartyId = from.PartyId;
            to.GuildId = from.GuildId;
            to.GuildRole = from.GuildRole;
            to.SharedGuildExp = from.SharedGuildExp;
            to.EquipWeaponSet = from.EquipWeaponSet;
            if (withCurrentLocationData)
            {
                to.CurrentMapName = from.CurrentMapName;
                to.CurrentPosition = from.CurrentPosition;
                to.CurrentRotation = from.CurrentRotation;
            }
            to.RespawnMapName = from.RespawnMapName;
            to.RespawnPosition = from.RespawnPosition;
            to.MountDataId = from.MountDataId;
            to.IconDataId = from.IconDataId;
            to.FrameDataId = from.FrameDataId;
            to.TitleDataId = from.TitleDataId;
            to.LastDeadTime = from.LastDeadTime;
            to.UnmuteTime = from.UnmuteTime;
            to.LastUpdate = from.LastUpdate;
            to.IsPkOn = from.IsPkOn;
            to.LastPkOnTime = from.LastPkOnTime;
            to.PkPoint = from.PkPoint;
            to.ConsecutivePkKills = from.ConsecutivePkKills;
            to.HighestPkPoint = from.HighestPkPoint;
            to.HighestConsecutivePkKills = from.HighestConsecutivePkKills;
            if (withEquipWeapons)
                to.SelectableWeaponSets = from.SelectableWeaponSets.Clone(generateNewIdForRelatesData);
            if (withAttributes)
                to.Attributes = from.Attributes.Clone();
            if (withSkills)
                to.Skills = from.Skills.Clone();
            if (withSkillUsages)
                to.SkillUsages = from.SkillUsages.Clone();
            if (withBuffs)
                to.Buffs = from.Buffs.Clone(generateNewIdForRelatesData);
            if (withEquipItems)
                to.EquipItems = from.EquipItems.Clone(generateNewIdForRelatesData);
            if (withNonEquipItems)
                to.NonEquipItems = from.NonEquipItems.Clone(generateNewIdForRelatesData);
            if (withSummons)
                to.Summons = from.Summons.Clone(generateNewIdForRelatesData);
            if (withHotkeys)
                to.Hotkeys = from.Hotkeys.Clone();
            if (withQuests)
                to.Quests = from.Quests.Clone();
            if (withCurrencies)
                to.Currencies = from.Currencies.Clone();
            if (withServerCustomData)
            {
                to.ServerBools = from.ServerBools.Clone();
                to.ServerInts = from.ServerInts.Clone();
                to.ServerFloats = from.ServerFloats.Clone();
            }
            if (withPrivateCustomData)
            {
                to.PrivateBools = from.PrivateBools.Clone();
                to.PrivateInts = from.PrivateInts.Clone();
                to.PrivateFloats = from.PrivateFloats.Clone();
            }
            if (withPublicCustomData)
            {
                to.PublicBools = from.PublicBools.Clone();
                to.PublicInts = from.PublicInts.Clone();
                to.PublicFloats = from.PublicFloats.Clone();
            }
            DevExtUtils.InvokeStaticDevExtMethods(ClassType, "CloneTo", from, to);
            return to;
        }

        public static int IndexOfHotkey(this IPlayerCharacterData data, string hotkeyId)
        {
            return data.Hotkeys.IndexOf(hotkeyId);
        }

        public static int IndexOfQuest(this IPlayerCharacterData data, int dataId)
        {
            return data.Quests.IndexOf(dataId);
        }

        public static int IndexOfCurrency(this IPlayerCharacterData data, int dataId)
        {
            return data.Currencies.IndexOf(dataId);
        }

        public static int IndexOfServerBoolean(this IPlayerCharacterData data, int hashedKey)
        {
            return data.ServerBools.IndexOf(hashedKey);
        }

        public static int IndexOfServerInt32(this IPlayerCharacterData data, int hashedKey)
        {
            return data.ServerInts.IndexOf(hashedKey);
        }

        public static int IndexOfServerFloat32(this IPlayerCharacterData data, int hashedKey)
        {
            return data.ServerFloats.IndexOf(hashedKey);
        }

        public static int IndexOfPrivateBoolean(this IPlayerCharacterData data, int hashedKey)
        {
            return data.PrivateBools.IndexOf(hashedKey);
        }

        public static int IndexOfPrivateInt32(this IPlayerCharacterData data, int hashedKey)
        {
            return data.PrivateInts.IndexOf(hashedKey);
        }

        public static int IndexOfPrivateFloat32(this IPlayerCharacterData data, int hashedKey)
        {
            return data.PrivateFloats.IndexOf(hashedKey);
        }

        public static int IndexOfPublicBoolean(this IPlayerCharacterData data, int hashedKey)
        {
            return data.PublicBools.IndexOf(hashedKey);
        }

        public static int IndexOfPublicInt32(this IPlayerCharacterData data, int hashedKey)
        {
            return data.PublicInts.IndexOf(hashedKey);
        }

        public static int IndexOfPublicFloat32(this IPlayerCharacterData data, int hashedKey)
        {
            return data.PublicFloats.IndexOf(hashedKey);
        }

        public static bool GetServerBoolean(this IPlayerCharacterData data, int hashedKey, bool defaultValue = false)
        {
            return data.ServerBools.GetValue(hashedKey, defaultValue);
        }

        public static void SetServerBoolean(this IPlayerCharacterData data, int hashedKey, bool value)
        {
            data.ServerBools.SetValue(hashedKey, value);
        }

        public static int GetServerInt32(this IPlayerCharacterData data, int hashedKey, int defaultValue = 0)
        {
            return data.ServerInts.GetValue(hashedKey, defaultValue);
        }

        public static void SetServerInt32(this IPlayerCharacterData data, int hashedKey, int value)
        {
            data.ServerInts.SetValue(hashedKey, value);
        }

        public static float GetServerFloat32(this IPlayerCharacterData data, int hashedKey, float defaultValue = 0f)
        {
            return data.ServerFloats.GetValue(hashedKey, defaultValue);
        }

        public static void SetServerFloat32(this IPlayerCharacterData data, int hashedKey, float value)
        {
            data.ServerFloats.SetValue(hashedKey, value);
        }

        public static bool GetPrivateBoolean(this IPlayerCharacterData data, int hashedKey, bool defaultValue = false)
        {
            return data.PrivateBools.GetValue(hashedKey, defaultValue);
        }

        public static void SetPrivateBoolean(this IPlayerCharacterData data, int hashedKey, bool value)
        {
            data.PrivateBools.SetValue(hashedKey, value);
        }

        public static int GetPrivateInt32(this IPlayerCharacterData data, int hashedKey, int defaultValue = 0)
        {
            return data.PrivateInts.GetValue(hashedKey, defaultValue);
        }

        public static void SetPrivateInt32(this IPlayerCharacterData data, int hashedKey, int value)
        {
            data.PrivateInts.SetValue(hashedKey, value);
        }

        public static float GetPrivateFloat32(this IPlayerCharacterData data, int hashedKey, float defaultValue = 0f)
        {
            return data.PrivateFloats.GetValue(hashedKey, defaultValue);
        }

        public static void SetPrivateFloat32(this IPlayerCharacterData data, int hashedKey, float value)
        {
            data.PrivateFloats.SetValue(hashedKey, value);
        }

        public static bool GetPublicBoolean(this IPlayerCharacterData data, int hashedKey, bool defaultValue = false)
        {
            return data.PublicBools.GetValue(hashedKey, defaultValue);
        }

        public static void SetPublicBoolean(this IPlayerCharacterData data, int hashedKey, bool value)
        {
            data.PublicBools.SetValue(hashedKey, value);
        }

        public static int GetPublicInt32(this IPlayerCharacterData data, int hashedKey, int defaultValue = 0)
        {
            return data.PublicInts.GetValue(hashedKey, defaultValue);
        }

        public static void SetPublicInt32(this IPlayerCharacterData data, int hashedKey, int value)
        {
            data.PublicInts.SetValue(hashedKey, value);
        }

        public static float GetPublicFloat32(this IPlayerCharacterData data, int hashedKey, float defaultValue = 0f)
        {
            return data.PublicFloats.GetValue(hashedKey, defaultValue);
        }

        public static void SetPublicFloat32(this IPlayerCharacterData data, int hashedKey, float value)
        {
            data.PublicFloats.SetValue(hashedKey, value);
        }
    }
}

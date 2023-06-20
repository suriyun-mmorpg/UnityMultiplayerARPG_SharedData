using LiteNetLib.Utils;
using System.Collections.Generic;

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
            bool withPublicCustomData = true) where T : IPlayerCharacterData
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
            to.CurrentMapName = from.CurrentMapName;
            to.CurrentPosition = from.CurrentPosition;
            to.CurrentRotation = from.CurrentRotation;
            to.RespawnMapName = from.RespawnMapName;
            to.RespawnPosition = from.RespawnPosition;
            to.MountDataId = from.MountDataId;
            to.IconDataId = from.IconDataId;
            to.FrameDataId = from.FrameDataId;
            to.TitleDataId = from.TitleDataId;
            to.LastDeadTime = from.LastDeadTime;
            to.UnmuteTime = from.UnmuteTime;
            to.LastUpdate = from.LastUpdate;
            if (withEquipWeapons)
                to.SelectableWeaponSets = from.SelectableWeaponSets.Clone();
            if (withAttributes)
                to.Attributes = from.Attributes.Clone();
            if (withSkills)
                to.Skills = from.Skills.Clone();
            if (withSkillUsages)
                to.SkillUsages = from.SkillUsages.Clone();
            if (withBuffs)
                to.Buffs = from.Buffs.Clone();
            if (withEquipItems)
                to.EquipItems = from.EquipItems.Clone();
            if (withNonEquipItems)
                to.NonEquipItems = from.NonEquipItems.Clone();
            if (withSummons)
                to.Summons = from.Summons.Clone();
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
    }
}

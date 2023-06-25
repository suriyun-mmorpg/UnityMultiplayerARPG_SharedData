using LiteNetLib.Utils;

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

        public static void SerializeCharacterData<T>(this T characterData, NetDataWriter writer,
            bool withTransforms = true,
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
            writer.Put(characterData.Id);
            writer.PutPackedInt(characterData.DataId);
            writer.PutPackedInt(characterData.EntityId);
            writer.Put(characterData.UserId);
            writer.PutPackedInt(characterData.FactionId);
            writer.Put(characterData.CharacterName);
            writer.PutPackedInt(characterData.Level);
            writer.PutPackedInt(characterData.Exp);
            writer.PutPackedInt(characterData.CurrentHp);
            writer.PutPackedInt(characterData.CurrentMp);
            writer.PutPackedInt(characterData.CurrentStamina);
            writer.PutPackedInt(characterData.CurrentFood);
            writer.PutPackedInt(characterData.CurrentWater);
            writer.Put(characterData.StatPoint);
            writer.Put(characterData.SkillPoint);
            writer.PutPackedInt(characterData.Gold);
            writer.PutPackedInt(characterData.UserGold);
            writer.PutPackedInt(characterData.UserCash);
            writer.PutPackedInt(characterData.PartyId);
            writer.PutPackedInt(characterData.GuildId);
            writer.Put(characterData.GuildRole);
            writer.PutPackedInt(characterData.SharedGuildExp);
            writer.Put(characterData.CurrentMapName);
            if (withTransforms)
            {
                writer.Put(characterData.CurrentPosition.x);
                writer.Put(characterData.CurrentPosition.y);
                writer.Put(characterData.CurrentPosition.z);
                writer.Put(characterData.CurrentRotation.x);
                writer.Put(characterData.CurrentRotation.y);
                writer.Put(characterData.CurrentRotation.z);
            }
            writer.Put(characterData.RespawnMapName);
            if (withTransforms)
            {
                writer.Put(characterData.RespawnPosition.x);
                writer.Put(characterData.RespawnPosition.y);
                writer.Put(characterData.RespawnPosition.z);
            }
            writer.PutPackedInt(characterData.MountDataId);
            writer.PutPackedInt(characterData.IconDataId);
            writer.PutPackedInt(characterData.FrameDataId);
            writer.PutPackedInt(characterData.TitleDataId);
            writer.PutPackedLong(characterData.LastDeadTime);
            writer.PutPackedLong(characterData.UnmuteTime);
            writer.PutPackedLong(characterData.LastUpdate);
            // Attributes
            if (withAttributes)
            {
                writer.PutPackedInt(characterData.Attributes.Count);
                foreach (CharacterAttribute entry in characterData.Attributes)
                {
                    writer.Put(entry);
                }
            }
            // Buffs
            if (withBuffs)
            {
                writer.PutPackedInt(characterData.Buffs.Count);
                foreach (CharacterBuff entry in characterData.Buffs)
                {
                    writer.Put(entry);
                }
            }
            // Skills
            if (withSkills)
            {
                writer.PutPackedInt(characterData.Skills.Count);
                foreach (CharacterSkill entry in characterData.Skills)
                {
                    writer.Put(entry);
                }
            }
            // Skill Usages
            if (withSkillUsages)
            {
                writer.PutPackedInt(characterData.SkillUsages.Count);
                foreach (CharacterSkillUsage entry in characterData.SkillUsages)
                {
                    writer.Put(entry);
                }
            }
            // Summons
            if (withSummons)
            {
                writer.PutPackedInt(characterData.Summons.Count);
                foreach (CharacterSummon entry in characterData.Summons)
                {
                    writer.Put(entry);
                }
            }
            // Equip Items
            if (withEquipItems)
            {
                writer.PutPackedInt(characterData.EquipItems.Count);
                foreach (CharacterItem entry in characterData.EquipItems)
                {
                    writer.Put(entry);
                }
            }
            // Non Equip Items
            if (withNonEquipItems)
            {
                writer.PutPackedInt(characterData.NonEquipItems.Count);
                foreach (CharacterItem entry in characterData.NonEquipItems)
                {
                    writer.Put(entry);
                }
            }
            // Hotkeys
            if (withHotkeys)
            {
                writer.PutPackedInt(characterData.Hotkeys.Count);
                foreach (CharacterHotkey entry in characterData.Hotkeys)
                {
                    writer.Put(entry);
                }
            }
            // Quests
            if (withQuests)
            {
                writer.PutPackedInt(characterData.Quests.Count);
                foreach (CharacterQuest entry in characterData.Quests)
                {
                    writer.Put(entry);
                }
            }
            // Currencies
            if (withCurrencies)
            {
                writer.PutPackedInt(characterData.Currencies.Count);
                foreach (CharacterCurrency entry in characterData.Currencies)
                {
                    writer.Put(entry);
                }
            }
            // Server custom data
            if (withServerCustomData)
            {
                writer.PutPackedInt(characterData.ServerBools.Count);
                foreach (CharacterDataBoolean entry in characterData.ServerBools)
                {
                    writer.Put(entry);
                }
                writer.PutPackedInt(characterData.ServerInts.Count);
                foreach (CharacterDataInt32 entry in characterData.ServerInts)
                {
                    writer.Put(entry);
                }
                writer.PutPackedInt(characterData.ServerFloats.Count);
                foreach (CharacterDataFloat32 entry in characterData.ServerFloats)
                {
                    writer.Put(entry);
                }
            }
            // Private custom data
            if (withPrivateCustomData)
            {
                writer.PutPackedInt(characterData.PrivateBools.Count);
                foreach (CharacterDataBoolean entry in characterData.PrivateBools)
                {
                    writer.Put(entry);
                }
                writer.PutPackedInt(characterData.PrivateInts.Count);
                foreach (CharacterDataInt32 entry in characterData.PrivateInts)
                {
                    writer.Put(entry);
                }
                writer.PutPackedInt(characterData.PrivateFloats.Count);
                foreach (CharacterDataFloat32 entry in characterData.PrivateFloats)
                {
                    writer.Put(entry);
                }
            }
            // Public custom data
            if (withPublicCustomData)
            {
                writer.PutPackedInt(characterData.PublicBools.Count);
                foreach (CharacterDataBoolean entry in characterData.PublicBools)
                {
                    writer.Put(entry);
                }
                writer.PutPackedInt(characterData.PublicInts.Count);
                foreach (CharacterDataInt32 entry in characterData.PublicInts)
                {
                    writer.Put(entry);
                }
                writer.PutPackedInt(characterData.PublicFloats.Count);
                foreach (CharacterDataFloat32 entry in characterData.PublicFloats)
                {
                    writer.Put(entry);
                }
            }
            // Equip weapon set
            writer.Put(characterData.EquipWeaponSet);
            // Selectable weapon sets
            if (withEquipWeapons)
            {
                writer.PutPackedInt(characterData.SelectableWeaponSets.Count);
                foreach (EquipWeapons entry in characterData.SelectableWeaponSets)
                {
                    writer.Put(entry);
                }
            }
            DevExtUtils.InvokeStaticDevExtMethods(ClassType, "SerializeCharacterData", characterData, writer);
        }

        public static PlayerCharacterData DeserializeCharacterData(this NetDataReader reader)
        {
            return new PlayerCharacterData().DeserializeCharacterData(reader);
        }

        public static void DeserializeCharacterData(this NetDataReader reader, ref PlayerCharacterData characterData)
        {
            characterData = reader.DeserializeCharacterData();
        }

        public static T DeserializeCharacterData<T>(this T characterData, NetDataReader reader,
            bool withTransforms = true,
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
            characterData.Id = reader.GetString();
            characterData.DataId = reader.GetPackedInt();
            characterData.EntityId = reader.GetPackedInt();
            characterData.UserId = reader.GetString();
            characterData.FactionId = reader.GetPackedInt();
            characterData.CharacterName = reader.GetString();
            characterData.Level = reader.GetPackedInt();
            characterData.Exp = reader.GetPackedInt();
            characterData.CurrentHp = reader.GetPackedInt();
            characterData.CurrentMp = reader.GetPackedInt();
            characterData.CurrentStamina = reader.GetPackedInt();
            characterData.CurrentFood = reader.GetPackedInt();
            characterData.CurrentWater = reader.GetPackedInt();
            characterData.StatPoint = reader.GetFloat();
            characterData.SkillPoint = reader.GetFloat();
            characterData.Gold = reader.GetPackedInt();
            characterData.UserGold = reader.GetPackedInt();
            characterData.UserCash = reader.GetPackedInt();
            characterData.PartyId = reader.GetPackedInt();
            characterData.GuildId = reader.GetPackedInt();
            characterData.GuildRole = reader.GetByte();
            characterData.SharedGuildExp = reader.GetPackedInt();
            characterData.CurrentMapName = reader.GetString();
            if (withTransforms)
            {
                characterData.CurrentPosition = new Vec3(reader.GetFloat(), reader.GetFloat(), reader.GetFloat());
                characterData.CurrentRotation = new Vec3(reader.GetFloat(), reader.GetFloat(), reader.GetFloat());
            }
            characterData.RespawnMapName = reader.GetString();
            if (withTransforms)
            {
                characterData.RespawnPosition = new Vec3(reader.GetFloat(), reader.GetFloat(), reader.GetFloat());
            }
            characterData.MountDataId = reader.GetPackedInt();
            characterData.IconDataId = reader.GetPackedInt();
            characterData.FrameDataId = reader.GetPackedInt();
            characterData.TitleDataId = reader.GetPackedInt();
            characterData.LastDeadTime = reader.GetPackedLong();
            characterData.UnmuteTime = reader.GetPackedLong();
            characterData.LastUpdate = reader.GetPackedLong();
            int count;
            // Attributes
            if (withAttributes)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.Attributes.Add(reader.Get(() => new CharacterAttribute()));
                }
            }
            // Buffs
            if (withBuffs)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.Buffs.Add(reader.Get(() => new CharacterBuff()));
                }
            }
            // Skills
            if (withSkills)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.Skills.Add(reader.Get(() => new CharacterSkill()));
                }
            }
            // Skill Usages
            if (withSkillUsages)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.SkillUsages.Add(reader.Get(() => new CharacterSkillUsage()));
                }
            }
            // Summons
            if (withSummons)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.Summons.Add(reader.Get(() => new CharacterSummon()));
                }
            }
            // Equip Items
            if (withEquipItems)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.EquipItems.Add(reader.Get(() => new CharacterItem()));
                }
            }
            // Non Equip Items
            if (withNonEquipItems)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.NonEquipItems.Add(reader.Get(() => new CharacterItem()));
                }
            }
            // Hotkeys
            if (withHotkeys)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.Hotkeys.Add(reader.Get(() => new CharacterHotkey()));
                }
            }
            // Quests
            if (withQuests)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.Quests.Add(reader.Get(() => new CharacterQuest()));
                }
            }
            // Currencies
            if (withCurrencies)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.Currencies.Add(reader.Get(() => new CharacterCurrency()));
                }
            }
            // Server custom data
            if (withServerCustomData)
            {
                count = reader.GetPackedInt();
                foreach (CharacterDataBoolean entry in characterData.ServerBools)
                {
                    characterData.ServerBools.Add(reader.Get<CharacterDataBoolean>());
                }
                count = reader.GetPackedInt();
                foreach (CharacterDataInt32 entry in characterData.ServerInts)
                {
                    characterData.ServerInts.Add(reader.Get<CharacterDataInt32>());
                }
                count = reader.GetPackedInt();
                foreach (CharacterDataFloat32 entry in characterData.ServerFloats)
                {
                    characterData.ServerFloats.Add(reader.Get<CharacterDataFloat32>());
                }
            }
            // Private custom data
            if (withPrivateCustomData)
            {
                count = reader.GetPackedInt();
                foreach (CharacterDataBoolean entry in characterData.PrivateBools)
                {
                    characterData.PrivateBools.Add(reader.Get<CharacterDataBoolean>());
                }
                count = reader.GetPackedInt();
                foreach (CharacterDataInt32 entry in characterData.PrivateInts)
                {
                    characterData.PrivateInts.Add(reader.Get<CharacterDataInt32>());
                }
                count = reader.GetPackedInt();
                foreach (CharacterDataFloat32 entry in characterData.PrivateFloats)
                {
                    characterData.PrivateFloats.Add(reader.Get<CharacterDataFloat32>());
                }
            }
            // Public custom data
            if (withPublicCustomData)
            {
                count = reader.GetPackedInt();
                foreach (CharacterDataBoolean entry in characterData.PublicBools)
                {
                    characterData.PublicBools.Add(reader.Get<CharacterDataBoolean>());
                }
                count = reader.GetPackedInt();
                foreach (CharacterDataInt32 entry in characterData.PublicInts)
                {
                    characterData.PublicInts.Add(reader.Get<CharacterDataInt32>());
                }
                count = reader.GetPackedInt();
                foreach (CharacterDataFloat32 entry in characterData.PublicFloats)
                {
                    characterData.PublicFloats.Add(reader.Get<CharacterDataFloat32>());
                }
            }
            // Equip weapon set
            characterData.EquipWeaponSet = reader.GetByte();
            // Selectable weapon sets
            if (withEquipWeapons)
            {
                count = reader.GetPackedInt();
                for (int i = 0; i < count; ++i)
                {
                    characterData.SelectableWeaponSets.Add(reader.Get(() => new EquipWeapons()));
                }
            }
            DevExtUtils.InvokeStaticDevExtMethods(ClassType, "DeserializeCharacterData", characterData, reader);
            return characterData;
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

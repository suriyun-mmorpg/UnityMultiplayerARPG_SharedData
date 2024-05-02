using System.Collections.Generic;

namespace MultiplayerARPG
{
    public static partial class CharacterDataExtensions
    {
        public static System.Type ClassType { get; private set; }

        static CharacterDataExtensions()
        {
            ClassType = typeof(CharacterDataExtensions);
        }

        public static int IndexOfAttribute(this ICharacterData data, int dataId)
        {
            return data.Attributes.IndexOf(dataId);
        }

        public static int IndexOfBuff(this ICharacterData data, BuffType type, int dataId)
        {
            return data.Buffs.IndexOf(type, dataId);
        }

        public static List<int> IndexesOfBuff(this ICharacterData data, BuffType type, int dataId)
        {
            return data.Buffs.IndexesOf(type, dataId);
        }

        public static int IndexOfEquipItem(this ICharacterData data, int dataId)
        {
            return data.EquipItems.IndexOf(dataId);
        }

        public static int IndexOfEquipItem(this ICharacterData data, string id)
        {
            return data.EquipItems.IndexOf(id);
        }

        public static int IndexOfNonEquipItem(this ICharacterData data, int dataId)
        {
            return data.NonEquipItems.IndexOf(dataId);
        }

        public static int IndexOfNonEquipItem(this ICharacterData data, string id)
        {
            return data.NonEquipItems.IndexOf(id);
        }

        public static int IndexOfSkill(this ICharacterData data, int dataId)
        {
            return data.Skills.IndexOf(dataId);
        }

        public static int IndexOfSkillUsage(this ICharacterData data, SkillUsageType type, int dataId)
        {
            return data.SkillUsages.IndexOf(type, dataId);
        }

        public static int IndexOfSummon(this ICharacterData data, uint objectId)
        {
            return data.Summons.IndexOf(objectId);
        }

        public static int IndexOfSummon(this ICharacterData data, SummonType type)
        {
            return data.Summons.IndexOf(type);
        }

        public static int IndexOfSummon(this ICharacterData data, SummonType type, int dataId)
        {
            return data.Summons.IndexOf(type, dataId);
        }

        public static void FillWeaponSetsIfNeeded(this ICharacterData data, byte equipWeaponSet)
        {
#if UNITY_2017_1_OR_NEWER
            if (data is IGameEntity gameEntity && gameEntity.Entity.Manager != null && !gameEntity.Entity.IsServer)
            {
                Logging.LogWarning("[FillWeaponSetsIfNeeded] Client can't fill weapon sets");
                return;
            }
#endif
            while (data.SelectableWeaponSets.Count <= equipWeaponSet)
            {
                data.SelectableWeaponSets.Add(new EquipWeapons());
            }
        }
    }
}

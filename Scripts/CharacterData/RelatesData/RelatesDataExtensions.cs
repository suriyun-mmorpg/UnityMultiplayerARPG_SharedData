using System.Collections.Generic;

namespace MultiplayerARPG
{
    public static partial class RelatesDataExtensions
    {
        public static List<EquipWeapons> Clone(this IList<EquipWeapons> src)
        {
            List<EquipWeapons> result = new List<EquipWeapons>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(new EquipWeapons()
                {
                    rightHand = src[i].rightHand.Clone(),
                    leftHand = src[i].leftHand.Clone(),
                });
            }
            return result;
        }

        public static List<CharacterAttribute> Clone(this IList<CharacterAttribute> src)
        {
            List<CharacterAttribute> result = new List<CharacterAttribute>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterBuff> Clone(this IList<CharacterBuff> src)
        {
            List<CharacterBuff> result = new List<CharacterBuff>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterItem> Clone(this IList<CharacterItem> src)
        {
            List<CharacterItem> result = new List<CharacterItem>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterSkill> Clone(this IList<CharacterSkill> src)
        {
            List<CharacterSkill> result = new List<CharacterSkill>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterSkillUsage> Clone(this IList<CharacterSkillUsage> src)
        {
            List<CharacterSkillUsage> result = new List<CharacterSkillUsage>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterSummon> Clone(this IList<CharacterSummon> src)
        {
            List<CharacterSummon> result = new List<CharacterSummon>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterHotkey> Clone(this IList<CharacterHotkey> src)
        {
            List<CharacterHotkey> result = new List<CharacterHotkey>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterQuest> Clone(this IList<CharacterQuest> src)
        {
            List<CharacterQuest> result = new List<CharacterQuest>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterCurrency> Clone(this IList<CharacterCurrency> src)
        {
            List<CharacterCurrency> result = new List<CharacterCurrency>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterDataBoolean> Clone(this IList<CharacterDataBoolean> src)
        {
            List<CharacterDataBoolean> result = new List<CharacterDataBoolean>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterDataInt32> Clone(this IList<CharacterDataInt32> src)
        {
            List<CharacterDataInt32> result = new List<CharacterDataInt32>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }

        public static List<CharacterDataFloat32> Clone(this IList<CharacterDataFloat32> src)
        {
            List<CharacterDataFloat32> result = new List<CharacterDataFloat32>();
            for (int i = 0; i < src.Count; ++i)
            {
                result.Add(src[i].Clone());
            }
            return result;
        }
    }
}
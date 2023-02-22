﻿using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class GuildData : SocialGroupData
    {
        public const byte LeaderRole = 0;

        public string guildName;
        public int level;
        public int exp;
        public int skillPoint;
        public string guildMessage;
        public string guildMessage2;
        public int gold;
        public int score;
        public string options;
        public bool autoAcceptRequests;
        public int rank;

        private bool isCached;
        private List<GuildRoleData> roles;
        private Dictionary<string, byte> memberRoles;
        private Dictionary<int, int> skillLevels;

        public byte LowestMemberRole
        {
            get
            {
                if (roles == null || roles.Count < 2)
                    return 1;
                return (byte)(roles.Count - 1);
            }
        }

        public GuildData()
            : base()
        {
            level = 1;
            exp = 0;
            skillPoint = 0;
            guildMessage = string.Empty;
            guildMessage2 = string.Empty;
            score = 0;
            gold = 0;
            options = string.Empty;
            autoAcceptRequests = false;
            rank = 0;
            memberRoles = new Dictionary<string, byte>();
            skillLevels = new Dictionary<int, int>();
        }

        public GuildData(int id)
            : this()
        {
            this.id = id;
        }

        public GuildData(int id, string guildName, string leaderId, GuildRoleData[] roles)
            : this(id, leaderId)
        {
            this.guildName = guildName;
            this.roles = new List<GuildRoleData>(roles);
        }

        public GuildData(int id, string guildName, string leaderId)
            : this(id, guildName, leaderId, SystemSetting.GuildMemberRoles)
        {

        }

        public GuildData(int id, string leaderId)
            : this(id)
        {
            this.leaderId = leaderId;
            AddMember(new SocialCharacterData() { id = leaderId });
        }

        public GuildData(int id, string guildName, SocialCharacterData leaderCharacterEntity)
            : this(id, guildName, leaderCharacterEntity.id)
        {
            AddMember(leaderCharacterEntity);
        }

        public void AddMember(SocialCharacterData memberData, byte guildRole)
        {
            base.AddMember(memberData);
            SetMemberRole(memberData.id, guildRole);
        }

        public void UpdateMember(SocialCharacterData memberData, byte guildRole)
        {
            base.UpdateMember(memberData);
            SetMemberRole(memberData.id, guildRole);
        }

        public override void AddMember(SocialCharacterData memberData)
        {
            base.AddMember(memberData);
            SetMemberRole(memberData.id, IsLeader(memberData.id) ? LeaderRole : LowestMemberRole);
        }

        public override bool RemoveMember(string characterId)
        {
            memberRoles.Remove(characterId);
            return base.RemoveMember(characterId);
        }

        public override void ClearMembers()
        {
            memberRoles.Clear();
            base.ClearMembers();
        }

        public override void SetLeader(string characterId)
        {
            if (members.ContainsKey(characterId))
            {
                memberRoles[leaderId] = LowestMemberRole;
                leaderId = characterId;
                memberRoles[leaderId] = LeaderRole;
            }
        }

        public bool TryGetMemberRole(string characterId, out byte role)
        {
            return memberRoles.TryGetValue(characterId, out role);
        }

        public void SetMemberRole(string characterId, byte guildRole)
        {
            if (members.ContainsKey(characterId))
            {
                if (!IsRoleAvailable(guildRole))
                    guildRole = IsLeader(characterId) ? LeaderRole : LowestMemberRole;
                // Validate role
                if (guildRole == LeaderRole && !IsLeader(characterId))
                    memberRoles[characterId] = LowestMemberRole;
                else
                    memberRoles[characterId] = guildRole;
            }
        }

        public bool IsRoleAvailable(byte guildRole)
        {
            return roles != null && guildRole >= 0 && guildRole < roles.Count;
        }

        public List<GuildRoleData> GetRoles()
        {
            return roles;
        }

        public GuildRoleData GetRole(byte guildRole)
        {
            if (!IsRoleAvailable(guildRole))
            {
                if (guildRole == LeaderRole)
                    return new GuildRoleData() { roleName = "Master", canInvite = true, canKick = true };
                else
                    return new GuildRoleData() { roleName = "Member", canInvite = false, canKick = false };
            }
            return roles[guildRole];
        }

        public void SetRole(byte guildRole, GuildRoleData role)
        {
            if (guildRole >= 0 && guildRole < roles.Count)
                roles[guildRole] = role;
        }

        public byte GetMemberRole(string characterId)
        {
            byte result;
            if (memberRoles.ContainsKey(characterId))
            {
                result = memberRoles[characterId];
                // Validate member role
                if (result == LeaderRole && !IsLeader(characterId))
                    result = memberRoles[characterId] = LowestMemberRole;
            }
            else
            {
                result = IsLeader(characterId) ? LeaderRole : LowestMemberRole;
            }
            return result;
        }

        public IEnumerable<KeyValuePair<int, int>> GetSkillLevels()
        {
            return skillLevels;
        }

        public int GetSkillLevel(int dataId)
        {
            if (skillLevels.ContainsKey(dataId))
                return skillLevels[dataId];
            return 0;
        }

        public void AddSkillLevel(int dataId)
        {
            int level = skillLevels.ContainsKey(dataId) ? skillLevels[dataId] : 0;
            level += 1;
            skillPoint -= 1;
            skillLevels[dataId] = level;
            isCached = false;
        }

        public void SetSkillLevel(int dataId, int level)
        {
            skillLevels[dataId] = level;
            isCached = false;
        }
    }
}

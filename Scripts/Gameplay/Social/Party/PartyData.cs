﻿namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class PartyData : SocialGroupData
    {
        public bool shareExp;
        public bool shareItem;

        public PartyData()
            : base()
        {
            shareExp = false;
            shareItem = false;
        }

        public PartyData(int id, bool shareExp, bool shareItem, string leaderId)
            : this()
        {
            this.id = id;
            this.leaderId = leaderId;
            this.shareExp = shareExp;
            this.shareItem = shareItem;
            AddMember(new SocialCharacterData() { id = leaderId });
        }

        public PartyData(int id, bool shareExp, bool shareItem, SocialCharacterData leaderCharacter)
            : this(id, shareExp, shareItem, leaderCharacter.id)
        {
            AddMember(leaderCharacter);
        }

        public void Setting(bool shareExp, bool shareItem)
        {
            this.shareExp = shareExp;
            this.shareItem = shareItem;
        }
    }
}

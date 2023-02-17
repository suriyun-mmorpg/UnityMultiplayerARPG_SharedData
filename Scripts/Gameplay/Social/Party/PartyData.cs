﻿namespace MultiplayerARPG
{
    public partial class PartyData : SocialGroupData
    {
        public bool shareExp;
        public bool shareItem;

        public PartyData()
            : base()
        {

        }

        public PartyData(int id)
            : base(id)
        {

        }

        public PartyData(int id, string leaderId)
            : base(id, leaderId)
        {

        }

        public PartyData(int id, bool shareExp, bool shareItem, string leaderId)
            : this(id, leaderId)
        {
            this.shareExp = shareExp;
            this.shareItem = shareItem;
        }
    }
}

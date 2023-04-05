namespace MultiplayerARPG
{
    [System.Serializable]
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

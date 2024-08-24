using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class Mail
    {
        public string Id { get; set; }
        public string EventId { get; set; }
        public string SenderId { get; set; }
        public string SenderName { get; set; }
        public string ReceiverId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Gold { get; set; }
        public int Cash { get; set; }
        public List<CharacterCurrency> Currencies { get; } = new List<CharacterCurrency>();
        public List<CharacterItem> Items { get; } = new List<CharacterItem>();
        public bool IsRead { get; set; }
        public long ReadTimestamp { get; set; }
        public bool IsClaim { get; set; }
        public long ClaimTimestamp { get; set; }
        public bool IsDelete { get; set; }
        public long DeleteTimestamp { get; set; }
        public long SentTimestamp { get; set; }

        public bool HaveItemsToClaim()
        {
            return Gold != 0 || Cash != 0 || Currencies.Count > 0 || Items.Count > 0;
        }

        public List<CharacterCurrency> ReadCurrencies(string currenciesString)
        {
            Currencies.Clear();
            Currencies.AddRange(currenciesString.ReadCurrencies());
            return Currencies;
        }

        public string WriteCurrencies()
        {
            return Currencies.WriteCurrencies();
        }

        public List<CharacterItem> ReadItems(string itemsString)
        {
            Items.Clear();
            Items.AddRange(itemsString.ReadItems());
            return Items;
        }

        public string WriteItems()
        {
            return Items.WriteItems();
        }
    }
}

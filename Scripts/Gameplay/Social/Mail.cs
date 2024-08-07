﻿using System.Collections.Generic;
using System.Globalization;
using Cysharp.Text;

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

        public List<CharacterCurrency> ReadCurrencies(string currencies)
        {
            Currencies.Clear();
            string[] splitSets = currencies.Split(';');
            foreach (string set in splitSets)
            {
                if (string.IsNullOrEmpty(set))
                    continue;
                string[] splitData = set.Split(':');
                if (splitData.Length != 2)
                    continue;
                Currencies.Add(new CharacterCurrency()
                {
                    dataId = int.Parse(splitData[0]),
                    amount = int.Parse(splitData[1]),
                });
            }
            return Currencies;
        }

        public string WriteCurrencies()
        {
            string result = string.Empty;
            foreach (CharacterCurrency currency in Currencies)
            {
                result += $"{currency.dataId}:{currency.amount};";
            }
            return result;
        }

        public List<CharacterItem> ReadItems(string items)
        {
            Items.Clear();
            string[] splitSets = items.Split(';');
            foreach (string set in splitSets)
            {
                if (string.IsNullOrEmpty(set))
                    continue;
                string[] splitData = set.Split(':');

                int dataId;
                if (splitData.Length < 1 || !int.TryParse(splitData[0], out dataId))
                    continue;

                int amount;
                if (splitData.Length < 2 || !int.TryParse(splitData[1], out amount))
                    amount = 1;

                int level;
                if (splitData.Length < 3 || !int.TryParse(splitData[2], out level))
                    level = 1;

                float durability;
                if (splitData.Length < 4 || !float.TryParse(splitData[3].Replace(',', '.'), out durability))
                    durability = 0f;

                int exp;
                if (splitData.Length < 5 || !int.TryParse(splitData[4], out exp))
                    exp = 0;

                float lockRemainsDuration;
                if (splitData.Length < 6 || !float.TryParse(splitData[5].Replace(',', '.'), out lockRemainsDuration))
                    lockRemainsDuration = 0f;

                long expireTime;
                if (splitData.Length < 7 || !long.TryParse(splitData[6], out expireTime))
                    expireTime = 0;

                int randomSeed;
                if (splitData.Length < 8 || !int.TryParse(splitData[7], out randomSeed))
                    randomSeed = 0;

                string sockets;
                if (splitData.Length < 9)
                    sockets = "";
                else
                    sockets = splitData[8];

                CharacterItem characterItem = new CharacterItem();
                characterItem.id = GenericUtils.GetUniqueId();
                characterItem.dataId = dataId;
                characterItem.level = level;
                characterItem.amount = amount;
                characterItem.durability = durability;
                characterItem.exp = exp;
                characterItem.lockRemainsDuration = lockRemainsDuration;
                characterItem.expireTime = expireTime;
                characterItem.randomSeed = randomSeed;
                characterItem.ReadSockets(sockets, '|');
                Items.Add(characterItem);
            }
            return Items;
        }

        public string WriteItems()
        {
            using (Utf16ValueStringBuilder stringBuilder = ZString.CreateStringBuilder(false))
            {
                foreach (CharacterItem item in Items)
                {
                    if (item.IsEmptySlot()) continue;
                    stringBuilder.Append(item.dataId);
                    stringBuilder.Append(':');
                    stringBuilder.Append(item.amount);
                    stringBuilder.Append(':');
                    stringBuilder.Append(item.level);
                    stringBuilder.Append(':');
                    stringBuilder.Append(item.durability.ToString("N2", CultureInfo.InvariantCulture.NumberFormat));
                    stringBuilder.Append(':');
                    stringBuilder.Append(item.exp);
                    stringBuilder.Append(':');
                    stringBuilder.Append(item.lockRemainsDuration.ToString("N2", CultureInfo.InvariantCulture.NumberFormat));
                    stringBuilder.Append(':');
                    stringBuilder.Append(item.expireTime);
                    stringBuilder.Append(':');
                    stringBuilder.Append(item.randomSeed);
                    stringBuilder.Append(':');
                    stringBuilder.Append(item.WriteSockets('|'));
                    stringBuilder.Append(';');
                }
                return stringBuilder.ToString();
            }
        }
    }
}

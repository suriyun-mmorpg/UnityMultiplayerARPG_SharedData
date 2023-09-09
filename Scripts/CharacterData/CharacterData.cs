using NotifiableCollection;
using System.Collections.Generic;

namespace MultiplayerARPG
{
    [System.Serializable]
    public partial class CharacterData : ICharacterData
    {
        private int _dataId;
        private int _entityId;
        private int _level;
        private byte _equipWeaponSet;
        private NotifiableList<EquipWeapons> _selectableEquipWeapons;
        private NotifiableList<CharacterAttribute> _attributes;
        private NotifiableList<CharacterSkill> _skills;
        private List<CharacterSkillUsage> _skillUsages;
        private NotifiableList<CharacterBuff> _buffs;
        private NotifiableList<CharacterItem> _equipItems;
        private NotifiableList<CharacterItem> _nonEquipItems;
        private NotifiableList<CharacterSummon> _summons;
        private int _titleDataId;

        ~CharacterData()
        {
#if !NET && !NETCOREAPP
            this.RemoveCaches();
#endif
        }

        public string Id { get; set; }
        public int DataId
        {
            get { return _dataId; }
            set
            {
                _dataId = value;
#if !NET && !NETCOREAPP
                this.MarkToMakeCaches();
#endif
            }
        }
        public int EntityId
        {
            get { return _entityId; }
            set
            {
                _entityId = value;
#if !NET && !NETCOREAPP
                this.MarkToMakeCaches();
#endif
            }
        }
        public string CharacterName { get; set; }
        public string Title
        {
            get { return CharacterName; }
            set { CharacterName = value; }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
#if !NET && !NETCOREAPP
                this.MarkToMakeCaches();
#endif
            }
        }
        public int Exp { get; set; }
        public int CurrentHp { get; set; }
        public int CurrentMp { get; set; }
        public int CurrentStamina { get; set; }
        public int CurrentFood { get; set; }
        public int CurrentWater { get; set; }
        public int IconDataId { get; set; }
        public int FrameDataId { get; set; }
        public int TitleDataId
        {
            get { return _titleDataId; }
            set
            {
                _titleDataId = value;
#if !NET && !NETCOREAPP
                this.MarkToMakeCaches();
#endif
            }
        }

        public EquipWeapons EquipWeapons
        {
            get
            {
                if (EquipWeaponSet < SelectableWeaponSets.Count)
                    return SelectableWeaponSets[EquipWeaponSet];
                return new EquipWeapons();
            }
            set
            {
#if !NET && !NETCOREAPP
                this.FillWeaponSetsIfNeeded(EquipWeaponSet);
#endif
                SelectableWeaponSets[EquipWeaponSet] = value;
            }
        }

        public byte EquipWeaponSet
        {
            get { return _equipWeaponSet; }
            set
            {
                _equipWeaponSet = value;
#if !NET && !NETCOREAPP
                this.MarkToMakeCaches();
#endif
            }
        }

        public IList<EquipWeapons> SelectableWeaponSets
        {
            get
            {
                if (_selectableEquipWeapons == null)
                {
                    _selectableEquipWeapons = new NotifiableList<EquipWeapons>();
                    _selectableEquipWeapons.ListChanged += List_ListChanged;
                }
                return _selectableEquipWeapons;
            }
            set
            {
                if (_selectableEquipWeapons == null)
                {
                    _selectableEquipWeapons = new NotifiableList<EquipWeapons>();
                    _selectableEquipWeapons.ListChanged += List_ListChanged;
                }
                _selectableEquipWeapons.Clear();
                foreach (EquipWeapons entry in value)
                    _selectableEquipWeapons.Add(entry);
            }
        }

        public IList<CharacterAttribute> Attributes
        {
            get
            {
                if (_attributes == null)
                {
                    _attributes = new NotifiableList<CharacterAttribute>();
                    _attributes.ListChanged += List_ListChanged;
                }
                return _attributes;
            }
            set
            {
                if (_attributes == null)
                {
                    _attributes = new NotifiableList<CharacterAttribute>();
                    _attributes.ListChanged += List_ListChanged;
                }
                _attributes.Clear();
                foreach (CharacterAttribute entry in value)
                    _attributes.Add(entry);
            }
        }

        public IList<CharacterSkill> Skills
        {
            get
            {
                if (_skills == null)
                {
                    _skills = new NotifiableList<CharacterSkill>();
                    _skills.ListChanged += List_ListChanged;
                }
                return _skills;
            }
            set
            {
                if (_skills == null)
                {
                    _skills = new NotifiableList<CharacterSkill>();
                    _skills.ListChanged += List_ListChanged;
                }
                _skills.Clear();
                foreach (CharacterSkill entry in value)
                    _skills.Add(entry);
            }
        }

        public IList<CharacterSkillUsage> SkillUsages
        {
            get
            {
                if (_skillUsages == null)
                    _skillUsages = new List<CharacterSkillUsage>();
                return _skillUsages;
            }
            set
            {
                if (_skillUsages == null)
                    _skillUsages = new List<CharacterSkillUsage>();
                _skillUsages.Clear();
                foreach (CharacterSkillUsage entry in value)
                    _skillUsages.Add(entry);
            }
        }

        public IList<CharacterBuff> Buffs
        {
            get
            {
                if (_buffs == null)
                {
                    _buffs = new NotifiableList<CharacterBuff>();
                    _buffs.ListChanged += List_ListChanged;
                }
                return _buffs;
            }
            set
            {
                if (_buffs == null)
                {
                    _buffs = new NotifiableList<CharacterBuff>();
                    _buffs.ListChanged += List_ListChanged;
                }
                _buffs.Clear();
                foreach (CharacterBuff entry in value)
                    _buffs.Add(entry);
            }
        }

        public IList<CharacterItem> EquipItems
        {
            get
            {
                if (_equipItems == null)
                {
                    _equipItems = new NotifiableList<CharacterItem>();
                    _equipItems.ListChanged += List_ListChanged;
                }
                return _equipItems;
            }
            set
            {
                if (_equipItems == null)
                {
                    _equipItems = new NotifiableList<CharacterItem>();
                    _equipItems.ListChanged += List_ListChanged;
                }
                _equipItems.Clear();
                foreach (CharacterItem entry in value)
                    _equipItems.Add(entry);
            }
        }

        public IList<CharacterItem> NonEquipItems
        {
            get
            {
                if (_nonEquipItems == null)
                {
                    _nonEquipItems = new NotifiableList<CharacterItem>();
                    _nonEquipItems.ListChanged += List_ListChanged;
                }
                return _nonEquipItems;
            }
            set
            {
                if (_nonEquipItems == null)
                {
                    _nonEquipItems = new NotifiableList<CharacterItem>();
                    _nonEquipItems.ListChanged += List_ListChanged;
                }
                _nonEquipItems.Clear();
                foreach (CharacterItem entry in value)
                    _nonEquipItems.Add(entry);
            }
        }

        public IList<CharacterSummon> Summons
        {
            get
            {
                if (_summons == null)
                {
                    _summons = new NotifiableList<CharacterSummon>();
                    _summons.ListChanged += List_ListChanged;
                }
                return _summons;
            }
            set
            {
                if (_summons == null)
                {
                    _summons = new NotifiableList<CharacterSummon>();
                    _summons.ListChanged += List_ListChanged;
                }
                _summons.Clear();
                foreach (CharacterSummon entry in value)
                    _summons.Add(entry);
            }
        }

        private void List_ListChanged(object sender, NotifiableListAction action, int index)
        {
#if !NET && !NETCOREAPP
                this.MarkToMakeCaches();
#endif
        }
    }
}

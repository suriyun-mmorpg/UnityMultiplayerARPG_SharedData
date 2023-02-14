namespace MultiplayerARPG
{
    public enum HotkeyType : byte
    {
        None,
        Skill,
        Item,
    }

    public partial class CharacterHotkey
    {
        public static readonly CharacterHotkey Empty = new CharacterHotkey();
        public string hotkeyId;
        public HotkeyType type;
        public string relateId;
    }
}

namespace MultiplayerARPG
{
    [System.Flags]
    public enum CharacterItemSocketsSyncStates : uint
    {
        None = 0U,

        Socket1 = 1U << 0,
        Socket2 = 1U << 1,
        Socket3 = 1U << 2,
        Socket4 = 1U << 3,
        Socket5 = 1U << 4,
        Socket6 = 1U << 5,
        Socket7 = 1U << 6,
        Socket8 = 1U << 7,

        Socket9 = 1U << 8,
        Socket10 = 1U << 9,
        Socket11 = 1U << 10,
        Socket12 = 1U << 11,
        Socket13 = 1U << 12,
        Socket14 = 1U << 13,
        Socket15 = 1U << 14,
        Socket16 = 1U << 15,

        Socket17 = 1U << 16,
        Socket18 = 1U << 17,
        Socket19 = 1U << 18,
        Socket20 = 1U << 19,
        Socket21 = 1U << 20,
        Socket22 = 1U << 21,
        Socket23 = 1U << 22,
        Socket24 = 1U << 23,
        Socket25 = 1U << 24,
        Socket26 = 1U << 25,
        Socket27 = 1U << 26,
        Socket28 = 1U << 27,
        Socket29 = 1U << 28,
        Socket30 = 1U << 29,
        Socket31 = 1U << 30,
        Socket32 = 1U << 31,

        All = uint.MaxValue,
    }

    public static class CharacterItemSocketsSyncStatesExtensions
    {
        public static bool Has(this CharacterItemSocketsSyncStates self, CharacterItemSocketsSyncStates flag)
        {
            return (self & flag) == flag;
        }
    }
}

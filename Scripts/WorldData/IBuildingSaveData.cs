namespace MultiplayerARPG
{
    public partial interface IBuildingSaveData
    {
        string Id { get; set; }
        string ParentId { get; set; }
        int EntityId { get; set; }
        int CurrentHp { get; set; }
        float RemainsLifeTime { get; set; }
        bool IsLocked { get; set; }
        string LockPassword { get; set; }
        float PositionX { get; set; }
        float PositionY { get; set; }
        float PositionZ { get; set; }
        float RotationX { get; set; }
        float RotationY { get; set; }
        float RotationZ { get; set; }
        string CreatorId { get; set; }
        string CreatorName { get; set; }
        string ExtraData { get; set; }
    }
}

class Track
{
    public string Name { get; }
    public int Length { get; }
    public string SurfaceType { get; }
    public string[] Hazards { get; }
    public bool IsUnlocked { get; set; }
    public Track(string name, int length, string surfaceType, string[] hazards, bool isUnlocked = false)
    {
        Name = name;
        Length = length;
        SurfaceType = surfaceType;
        Hazards = hazards;
        IsUnlocked = isUnlocked;
    }
}
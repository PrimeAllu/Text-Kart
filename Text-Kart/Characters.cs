class Character
{
    public string Name { get; }
    public bool IsUnlocked { get; set; }
    public Character(string name, bool isUnlocked = false)
    {
        Name = name;
        IsUnlocked = isUnlocked;
    }
}
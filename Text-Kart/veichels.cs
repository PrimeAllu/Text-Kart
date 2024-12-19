class Vehicle
{
    public string Model { get; }
    public int Speed { get; set; }
    public int Durability { get; set; }
    public string Color { get; set; }
    public bool IsUnlocked { get; set; }
    public Vehicle(string model, int speed, int durability, string color, bool isUnlocked = false)
    {
        Model = model;
        Speed = speed;
        Durability = durability;
        Color = color;
        IsUnlocked = isUnlocked;
    }
}
namespace PlebQuest2.Items;

internal record SolidMaterial(string Name, int Hardness, int Flexibitlity) : Material(Name)
{
    public static readonly SolidMaterial Rubber = new("Rubber", 5, 75);
    public static readonly SolidMaterial Wood = new("Wood", 20, 10);
    public static readonly SolidMaterial Iron = new("Iron", 50, 2);
}

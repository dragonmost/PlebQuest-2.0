namespace PlebQuest2.Items;

internal record LiquidMaterial(string Name, int Viscosity) : Material(Name)
{
    public static readonly LiquidMaterial Water = new("Water", 10);
}

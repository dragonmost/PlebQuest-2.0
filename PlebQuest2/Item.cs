internal record Item(string Name, ItemType Type, int Damage)
{
    public Stats BaseStats { get; init; }
    public Stats Scaling { get; init; }
}

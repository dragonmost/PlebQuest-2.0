internal record Item(string Name, ItemType Type, int Damage = 0)
{
    public Stats BaseStats { get; init; }
    public Stats Scaling { get; init; }
}

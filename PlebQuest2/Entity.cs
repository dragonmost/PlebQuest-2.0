internal record Entity(string Name, Stats Stats)
{
    private const int BaseHealth = 100;

    public int Level { get; init; }

    public Equipment Equipment { get; init; } = new();

    public int MaxHealth => (int)GetTotalStats().Constitution + BaseHealth;

    public int GetDamage(Item? item)
    {
        if (item is null)
        {
            return 1;
        }

        Stats itemDamageStats = GetTotalStats() * item.Scaling;

        return (int)(itemDamageStats.Total - itemDamageStats.Constitution) + item.Damage;
    }

    public Stats GetTotalStats()
    {
        return Equipment.GetTotalStats() + Stats;
    }
}

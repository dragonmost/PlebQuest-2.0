internal record Entity(string Name, Stats Stats)
{
    private const int BaseHealth = 100;

    public int Level { get; init; }

    public EntityEquipment Equipment { get; init; } = new();

    public Inventory Inventory { get; init; } = new();

    public int MaxHealth => (int)GetTotalStats().Constitution + BaseHealth;

    public int GetDamage(Item? item)
    {
        if (item is not Weapon weapon)
        {
            return 1;
        }

        Stats itemDamageStats = GetTotalStats() * weapon.StatsScaling;

        return (int)(itemDamageStats.Total - itemDamageStats.Constitution) + weapon.Damage;
    }

    public Stats GetTotalStats()
    {
        return Equipment.GetTotalStats() + Stats;
    }
}

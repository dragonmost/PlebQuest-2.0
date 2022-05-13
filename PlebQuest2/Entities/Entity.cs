using PlebQuest2.Items;

namespace PlebQuest2.Entities;

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
        Stats totalStats = Equipment.GetAllEquipmentSlots()
            .Select(s => s.Item)
            .OfType<Equipment>()
            .Select(i => i.Stats)
            .Aggregate(new Stats(), (a, b) => a + b);

        return totalStats + Stats;
    }
}

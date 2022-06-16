using PlebQuest2.Items;

namespace PlebQuest2.Entities;

internal record Traits(string Name, int Level, int MaxHealth);

internal record Entity(Traits Traits, Stats Stats)
{
    public EntityEquipment Equipment { get; init; } = new();

    public Inventory Inventory { get; init; } = new();

    public int GetDamage(Item? item)
    {
        if (item is not Weapon weapon)
        {
            return 1;
        }

        Stats itemDamageStats = GetTotalStats() * weapon.StatsScaling;

        return (int)(itemDamageStats.GetTotal() - itemDamageStats.Constitution) + weapon.Damage;
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

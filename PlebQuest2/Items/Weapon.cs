using PlebQuest2.Entities;

namespace PlebQuest2.Items;

internal record Weapon(string Name, SolidMaterial Material, int Damage) : Equipment(Name, Material)
{
    public Stats StatsScaling { get; init; }
}

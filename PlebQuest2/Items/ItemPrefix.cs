using PlebQuest2.Entities;

namespace PlebQuest2.Items;

internal record ItemPrefix(string Name, Stats Stats) : ItemAffix(Name, Stats)
{
    public static readonly ItemPrefix Supreme = new("Supreme", new Stats { Charisma = 9001 });
    public static readonly ItemPrefix Blunt = new("Blunt", new Stats { Strength = -3 });
    public static readonly ItemPrefix Sharp = new("Sharp", new Stats { Strength = 3 });
}

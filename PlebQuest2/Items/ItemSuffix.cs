using PlebQuest2.Entities;

namespace PlebQuest2.Items;

internal record ItemSuffix(string Name, Stats Stats) : ItemAffix(Name, Stats)
{
    public static readonly ItemSuffix OfBaba = new("of Baba", new Stats { Strength = 10 });
    public static readonly ItemSuffix OfMorningGlory = new("of Morning Glory", new Stats { Intelligence = -1, Constitution = 4 });
    public static readonly ItemSuffix OfYourMom = new("of Your Mom", new Stats { Charisma = 10 });
}

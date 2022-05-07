internal abstract record ItemAffix(string Name, Stats Stats);

internal record ItemSuffix(string Name, Stats Stats) : ItemAffix(Name, Stats)
{
    public static readonly ItemSuffix OfBaba = new("of Baba", new Stats { Strength = 10 });
    public static readonly ItemSuffix OfMorningGlory = new("of Morning Glory", new Stats { Intelligence = -1, Constitution = 4 });
}
internal record ItemPrefix(string Name, Stats Stats) : ItemAffix(Name, Stats)
{
    public static readonly ItemPrefix Supreme = new("Supreme", new Stats { Charisma = 9001 });
}

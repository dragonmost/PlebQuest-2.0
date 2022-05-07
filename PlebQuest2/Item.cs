internal record Item(string Name)
{
    public Stats Stats { get; init; }
}

internal record Weapon(string Name, int Damage) : Item(Name)
{
    public Stats StatsScaling { get; init; }
}

internal abstract record Equipment(string Name) : Item(Name);
internal record ArmorPiece(string Name) : Equipment(Name);
internal record Boot(string Name) : Equipment(Name);
internal record Glove(string Name) : Equipment(Name);
internal record Pants(string Name) : Equipment(Name);
internal record Helmet(string Name) : Equipment(Name);
internal record Ring(string Name) : Equipment(Name);
internal record Amulet(string Name) : Equipment(Name);
internal record Bracelet(string Name) : Equipment(Name);
internal record Earring(string Name) : Equipment(Name);

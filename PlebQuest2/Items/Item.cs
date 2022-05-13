using PlebQuest2.Entities;

namespace PlebQuest2.Items;

internal record Item(string Name)
{
    public virtual string DisplayName => Name;
}

internal abstract record Equipment(string Name, SolidMaterial Material) : Item(Name)
{
    public Stats Stats { get; init; }
    public ItemPrefix? Prefix { get; init; }
    public ItemSuffix? Suffix { get; init; }

    public override string DisplayName
    {
        get
        {
            string result = base.DisplayName;

            if (Prefix is not null)
            {
                result = $"{Prefix.Name} {result}";
            }

            if (Suffix is not null)
            {
                result = $"{result} {Suffix.Name}";
            }

            return result;
        }
    }
}

internal record ChestPiece(string Name, SolidMaterial Material) : Equipment(Name, Material);
internal record Boot(string Name, SolidMaterial Material) : Equipment(Name, Material);
internal record Glove(string Name, SolidMaterial Material) : Equipment(Name, Material);
internal record Pants(string Name, SolidMaterial Material) : Equipment(Name, Material);
internal record Helmet(string Name, SolidMaterial Material) : Equipment(Name, Material);
internal record Ring(string Name, SolidMaterial Material) : Equipment(Name, Material);
internal record Amulet(string Name, SolidMaterial Material) : Equipment(Name, Material);
internal record Bracelet(string Name, SolidMaterial Material) : Equipment(Name, Material);
internal record Earring(string Name, SolidMaterial Material) : Equipment(Name, Material);

internal record Weapon(string Name, SolidMaterial Material, int Damage) : Equipment(Name, Material)
{
    public Stats StatsScaling { get; init; }
}

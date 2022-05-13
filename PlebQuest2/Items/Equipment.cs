using PlebQuest2.Entities;

namespace PlebQuest2.Items;

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

            result = $"{Material.Name} {result}";

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

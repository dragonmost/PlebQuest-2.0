namespace PlebQuest2.Items;

internal record Item(string Name)
{
    public virtual string DisplayName => Name;
}

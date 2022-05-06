internal class SwordFactory
{
    public Item CreateSword(string name, int damage, Stats baseStats = default) => new Item(name, ItemType.Sword, damage)
    {
        BaseStats = baseStats,
        Scaling = new Stats
        {
            Strength = 1,
            Dexterity = 0.7
        }
    };
}

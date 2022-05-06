internal class SwordFactory
{
    public Item CreateSword(string name, int damage) => new Item(name, ItemType.Sword, damage)
    {
        Scaling = new Stats
        {
            Strength = 1,
            Dexterity = 0.7
        }
    };
}

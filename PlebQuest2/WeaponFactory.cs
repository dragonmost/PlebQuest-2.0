internal class WeaponFactory
{
    public Item CreateWeapon(string name, int damage, Stats baseStats = default) => new Item(name, ItemType.Weapon, damage)
    {
        BaseStats = baseStats,
        Scaling = new Stats
        {
            Strength = 1,
            Dexterity = 0.7
        }
    };
}

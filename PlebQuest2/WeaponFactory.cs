internal class WeaponFactory
{
    public Weapon CreateWeapon(string name, SolidMaterial material, int damage) => new Weapon(name, damage)
    {
        Stats = new Stats
        {
            Strength = material.Hardness
        },
        StatsScaling = new Stats
        {
            Strength = 1,
            Dexterity = 0.7
        }
    };
}

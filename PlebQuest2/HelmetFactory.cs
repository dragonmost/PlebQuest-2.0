//TODO (sbaker): Don't be a douche

internal class HelmetFactory
{
    public Item CreateHelmet(string name, Stats baseStats = default) => new(name, ItemType.Helmet)
    {
        BaseStats = baseStats,
        Scaling = new Stats()
        {
            Constitution = 0.5
        }
    };
}

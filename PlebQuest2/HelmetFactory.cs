//TODO (sbaker): Don't be a douche

internal class HelmetFactory
{
    public Helmet CreateHelmet(string name, Stats baseStats = default) => new(name)
    {
        Stats = baseStats
    };
}

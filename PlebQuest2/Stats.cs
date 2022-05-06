internal record struct Stats(double Strength, double Dexterity, double Intelligence, double Charisma, double Constitution, double Wisdom)
{
    public double Total => Strength + Dexterity + Intelligence + Charisma + Constitution + Wisdom;

    public static Stats operator *(Stats a, Stats b) => new(
        a.Strength * b.Strength,
        a.Dexterity * b.Dexterity,
        a.Intelligence * b.Intelligence,
        a.Charisma * b.Charisma,
        a.Constitution * b.Constitution,
        a.Wisdom * b.Wisdom);

    public static Stats operator +(Stats a, Stats b) => new(
        a.Strength + b.Strength,
        a.Dexterity + b.Dexterity,
        a.Intelligence + b.Intelligence,
        a.Charisma + b.Charisma,
        a.Constitution + b.Constitution,
        a.Wisdom + b.Wisdom);
}

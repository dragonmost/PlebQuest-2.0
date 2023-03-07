namespace PlebQuest2.Entities;

internal class Character : Entity
{
    public long Experience { get; set; }

    public override int Level => (int)(Experience / 10); //TODO: replace with actual calculation
    public override int MaxHealth => Level * 2 + 10; //TODO: replace with actual calculation

    public string FirstName { get; }
    public string? MiddleName { get; }
    public string LastName { get; }

    public Character(string firstName, string? middleName, string lastName, Stats stats)
        : base(stats)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
}

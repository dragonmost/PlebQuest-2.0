SwordFactory swordFactory = new();

Entity samuel = new("Samuel")
{
    Stats = new Stats(10, -1, 3, 91, 20, 30)
};

Entity michel = new("Michel")
{
    Stats = new Stats(25, 2, 1, 90, 50, 20)
};

Item swordOfBaba = swordFactory.CreateSword("Sword of Baba", 10) with
{
    BaseStats = new Stats
    {
        Dexterity = 1,
    }
};

samuel.Equipment.RightHand.TryEquip(swordOfBaba);

Fight fight = new(samuel, michel);

while(!fight.Done)
{
    Console.WriteLine(fight.Step());
}

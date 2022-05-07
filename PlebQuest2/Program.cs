WeaponFactory swordFactory = new();
HelmetFactory helmetFactory = new();

Item morningWood = swordFactory.CreateWeapon("Morning Wood", 25);
Item supremeBoot = helmetFactory.CreateHelmet("Supreme Boot", new Stats { Charisma = 9001 });
Item helmetOfMorningGlory = helmetFactory.CreateHelmet("Helmet of Morning Glory", new Stats { Intelligence = -1, Constitution = 4 });
Item swordOfBaba = swordFactory.CreateWeapon("Sword of Baba", 10, new Stats { Dexterity = 3 });
Item kaysOrangeBowl = new Item("Kay's Orange Bowl", ItemType.Object);

Entity samuel = new("Samuel", new Stats(10, -1, 3, 91, 20, 30));
samuel.Equipment.RightHand.TryEquip(swordOfBaba);
samuel.Equipment.Helmet.TryEquip(supremeBoot);
samuel.Inventory.Add(kaysOrangeBowl);

Entity michel = new("Michel", new Stats(25, 2, 1, 90, 50, 20));
michel.Equipment.RightHand.TryEquip(morningWood);
michel.Equipment.Helmet.TryEquip(helmetOfMorningGlory);

Fight fight = new(samuel, michel);

while (!fight.Done)
{
    Console.WriteLine(fight.Step());
}

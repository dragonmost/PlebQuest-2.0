Weapon ironSword = new("Sword", SolidMaterial.Iron, 10);
Weapon morningWood = new("Wood", SolidMaterial.Wood, 10);
Weapon swordOfBaba = ironSword with { Suffix = ItemSuffix.OfBaba };
Helmet supremeBoot = new("Boot", SolidMaterial.Rubber) { Prefix = ItemPrefix.Supreme };
Helmet helmetOfMorningGlory = new("Helmet", SolidMaterial.Iron) { Suffix = ItemSuffix.OfMorningGlory };
Item kaysOrangeBowl = new("Kay's Orange Bowl");

Entity samuel = new("Samuel", new Stats(10, -1, 3, 91, 20, 30));
samuel.Equipment.RightHand.Item = ironSword with { Suffix = ItemSuffix.OfBaba };
samuel.Equipment.Helmet.Item = supremeBoot;
samuel.Inventory.Add(kaysOrangeBowl);


Entity michel = new("Michel", new Stats(25, 2, 1, 90, 50, 20));
michel.Equipment.RightHand.Item = morningWood;
michel.Equipment.Helmet.Item = helmetOfMorningGlory;

Fight fight = new(samuel, michel);

while (!fight.Done)
{
    Console.WriteLine(fight.Step());
}

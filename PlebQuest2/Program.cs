WeaponFactory swordFactory = new();
HelmetFactory helmetFactory = new();

Weapon morningWood = swordFactory.CreateWeapon("Morning Wood", SolidMaterial.Wood, 10);
Helmet supremeBoot = helmetFactory.CreateHelmet("Supreme Boot", new Stats { Charisma = 9001 });
Helmet helmetOfMorningGlory = helmetFactory.CreateHelmet("Helmet of Morning Glory", new Stats { Intelligence = -1, Constitution = 4 });
Weapon swordOfBaba = swordFactory.CreateWeapon("Sword of Baba", SolidMaterial.Iron, 20);
Item kaysOrangeBowl = new Item("Kay's Orange Bowl");

Entity samuel = new("Samuel", new Stats(10, -1, 3, 91, 20, 30));
samuel.Equipment.RightHand.Item = swordOfBaba;
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

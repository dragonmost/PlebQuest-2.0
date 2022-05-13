using PlebQuest2.Entities;
using PlebQuest2.Fights;
using PlebQuest2.Items;

while (Console.ReadLine() != "exit")
{
    Console.WriteLine(GetRandomWeapon().DisplayName);
}

Weapon GetRandomWeapon()
{
    return GenerateWeapons().ToArray().GetRandom();
}

IEnumerable<Weapon> GenerateWeapons()
{
    ItemPrefix?[] prefixes = RecordEnumUtil.GetAll<ItemPrefix>().Append(null).ToArray();
    ItemSuffix?[] suffixes = RecordEnumUtil.GetAll<ItemSuffix>().Append(null).ToArray();
    SolidMaterial[] materials = RecordEnumUtil.GetAll<SolidMaterial>();
    string[] weaponTypes = new[]
    {
        "Sword",
        "Dagger",
        "Bow"
    };

    foreach ((ItemPrefix prefix, ItemSuffix suffix, SolidMaterial material, string weapontype) in prefixes.Combine(suffixes, materials, weaponTypes))
    {
        yield return new Weapon(weapontype, material, material.Hardness * 2)
        {
            Prefix = prefix,
            Suffix = suffix
        };
    }
}

void SimulateFight()
{
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

    FightSimulation fight = new(samuel, michel);

    while (!fight.Done)
    {
        Console.WriteLine(fight.Step());
    }
}

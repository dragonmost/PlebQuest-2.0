using PlebQuest2.Entities;
using PlebQuest2.Items;

namespace PlebQuest2;

internal class Game
{
    public Character Character { get; }

    public Game()
    {
        //TODO: replace with player load
        Character = new Character("Bob", "The Player", "Gratton", new Stats
        {
            Charisma = Random.Shared.Next(0, 5),
            Constitution = Random.Shared.Next(0, 5),
            Dexterity = Random.Shared.Next(0, 5),
            Intelligence = Random.Shared.Next(0, 5),
            Strength = Random.Shared.Next(0, 5),
            Wisdom = Random.Shared.Next(0, 5),
        })
        {
            Experience = 30
        };

        Character.Inventory.Add(new Weapon("Sword", SolidMaterial.Iron, 20) { Prefix = ItemPrefix.Blunt });
        Character.Inventory.Add(new Boot("Boot", SolidMaterial.Rubber) { Prefix = ItemPrefix.Supreme });
    }
}

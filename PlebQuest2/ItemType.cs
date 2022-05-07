[Flags]
internal enum ItemType
{
    None = 0,
    Weapon = 1,
    Armor = 2,
    Boot = 4,
    Glove = 8,
    Pants = 16,
    Helmet = 32,
    Ring = 64,
    Amulet = 128,
    Bracelet = 256,
    Earring = 512,
    Object = 1024,
    All = Weapon | Armor | Boot | Glove | Pants | Helmet | Ring | Amulet | Bracelet | Earring
}

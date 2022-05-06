[Flags]
internal enum ItemType
{
    None = 0,
    Sword = 1,
    Armor = 2,
    Boot = 4,
    Glove = 8,
    Pants = 16,
    Helmet = 32,
    Ring = 64,
    Amulet = 128,
    Bracelet = 256,
    Earring = 512,
    All = Sword | Armor | Boot | Glove | Pants | Helmet | Ring | Amulet | Bracelet | Earring
}

using System.Drawing;
using Terminal.Gui;
using Attribute = Terminal.Gui.Attribute;
using Color = System.Drawing.Color;

internal class ImageView : View
{
    private readonly Bitmap image;

    public ImageView(string path)
    {
        image = new Bitmap(path);
    }

    public override void OnDrawContent(Rect viewport)
    {
        base.OnDrawContent(viewport);

        (string, ConsoleColor)[][] lines = GrayscaleImageToASCII(image, viewport.Width, viewport.Height).ToArray();

        Clear();

        for (int i = 0; i < lines.Length; i++)
        {
            Move(0, i);

            foreach ((string Text, ConsoleColor Color) in lines[i])
            {
                Driver.AddStr(Text);
                Attribute current = Driver.GetAttribute();
                Driver.SetAttribute(Driver.MakeAttribute((Terminal.Gui.Color)Color, current.Background));
            }
        }
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (!disposing)
        {
            return;
        }

        image.Dispose();
    }

    public IEnumerable<(string, ConsoleColor)[]> GrayscaleImageToASCII(Bitmap image, int width, int height)
    {
        float scale = Math.Min(width / (float)image.Width, height / (float)image.Height * 2);
        var finalWidth = (int)(image.Width * scale);
        var finalHeight = (int)(image.Height * scale) / 2;
        var finalX = (width - finalWidth) / 2;
        var finalY = (height - finalHeight) / 2;

        using Bitmap bitmap = new(width, height);
        using Graphics graphics = Graphics.FromImage(bitmap);

        graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, bitmap.Width, bitmap.Height));
        graphics.DrawImage(image, new Rectangle(finalX, finalY, finalWidth, finalHeight));

        static ConsoleColor ToConsoleColor(Color c)
        {
            int index = ((c.R + c.G + c.B) / 3 > 128) ? 8 : 0; // Bright bit
            index |= (c.R > 64) ? 4 : 0; // Red bit
            index |= (c.G > 64) ? 2 : 0; // Green bit
            index |= (c.B > 64) ? 1 : 0; // Blue bit
            return (ConsoleColor)index;
        }

        for (int y = 0; y < bitmap.Height; y++)
        {
            List<(string, ConsoleColor)> chars = new();

            for (int x = 0; x < bitmap.Width; x++)
            {
                Color col = bitmap.GetPixel(x, y);
                int rValue = (col.R + col.G + col.B) / 3;
                string display = rValue switch
                {
                    >= 230 => " ",
                    >= 200 => ".",
                    >= 180 => "*",
                    >= 160 => ":",
                    >= 130 => "o",
                    >= 100 => "&",
                    >= 70 => "8",
                    >= 50 => "#",
                    _ => "@",
                };


                chars.Add((display, ToConsoleColor(col)));
            }

            yield return chars.ToArray();
        }
    }
}



//while (Console.ReadLine() != "exit")
//{
//    Console.WriteLine(GetRandomWeapon().DisplayName);
//}

//Weapon GetRandomWeapon()
//{
//    return GenerateWeapons().ToArray().GetRandom();
//}

//IEnumerable<Weapon> GenerateWeapons()
//{
//    ItemPrefix?[] prefixes = RecordEnumUtil.GetAll<ItemPrefix>().Append(null).ToArray();
//    ItemSuffix?[] suffixes = RecordEnumUtil.GetAll<ItemSuffix>().Append(null).ToArray();
//    SolidMaterial[] materials = RecordEnumUtil.GetAll<SolidMaterial>();
//    string[] weaponTypes = new[]
//    {
//        "Sword",
//        "Dagger",
//        "Bow"
//    };

//    foreach ((ItemPrefix prefix, ItemSuffix suffix, SolidMaterial material, string weapontype) in prefixes.Combine(suffixes, materials, weaponTypes))
//    {
//        yield return new Weapon(weapontype, material, material.Hardness * 2)
//        {
//            Prefix = prefix,
//            Suffix = suffix
//        };
//    }
//}

//void SimulateFight()
//{
//    Weapon ironSword = new("Sword", SolidMaterial.Iron, 10);
//    Weapon morningWood = new("Wood", SolidMaterial.Wood, 10);
//    Weapon swordOfBaba = ironSword with { Suffix = ItemSuffix.OfBaba };
//    Helmet supremeBoot = new("Boot", SolidMaterial.Rubber) { Prefix = ItemPrefix.Supreme };
//    Helmet helmetOfMorningGlory = new("Helmet", SolidMaterial.Iron) { Suffix = ItemSuffix.OfMorningGlory };
//    Item kaysOrangeBowl = new("Kay's Orange Bowl");

//    Entity samuel = new("Samuel", new Stats(10, -1, 3, 91, 20, 30));
//    samuel.Equipment.RightHand.Item = ironSword with { Suffix = ItemSuffix.OfBaba };
//    samuel.Equipment.Helmet.Item = supremeBoot;
//    samuel.Inventory.Add(kaysOrangeBowl);

//    Entity michel = new("Michel", new Stats(25, 2, 1, 90, 50, 20));
//    michel.Equipment.RightHand.Item = morningWood;
//    michel.Equipment.Helmet.Item = helmetOfMorningGlory;

//    FightSimulation fight = new(samuel, michel);

//    while (!fight.Done)
//    {
//        Console.WriteLine(fight.Step());
//    }
//}

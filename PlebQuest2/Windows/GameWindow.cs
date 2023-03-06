using Terminal.Gui;

namespace PlebQuest2.Windows;

internal class GameWindow : Window
{
    public GameWindow(Game game)
    {
        Border = new();

        var characterSheet = new CharacterSheetView(game.Character)
        {
            Width = Dim.Percent(25)
        };

        var inventoryView = new InventoryView(game.Character.Inventory)
        {
            X = Pos.Right(characterSheet)
        };

        Add(characterSheet, inventoryView);
    }
}

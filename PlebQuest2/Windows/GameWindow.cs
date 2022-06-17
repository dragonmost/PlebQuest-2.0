using PlebQuest2.Entities;
using PlebQuest2.Items;
using PlebQuest2.ViewModels;
using PlebQuest2.Views;
using System.ComponentModel;
using Terminal.Gui;

namespace PlebQuest2.Windows;

internal class GameWindow : Window
{
    private ItemViewModel itemViewModel;

    public GameWindow(Game game)
        : base("Pleb Quest 2")
    {
        itemViewModel = new ItemViewModel(game.Character.Inventory.First().Item);

        var characterSheet = AddCharacterSheet(game.Character);
        Add(characterSheet);

        var inventoryTableView = AddInventory(game.Character, characterSheet);
        Add(inventoryTableView);
    }

    private FrameView AddCharacterSheet(Character character)
    {
        var characterSheet = new FrameView("Character Sheet")
        {
            Width = Dim.Percent(25),
            Height = Dim.Fill(),
        };

        var traitsTableView = new TableView(TableUtils.CreateModelTable(new { character.FirstName, character.LastName, character.Level }))
        {
            Width = Dim.Fill(),
            Height = 6,
            FullRowSelect = true,
            SelectedRow = -1,
            CanFocus = false,
            Style = new()
            {
                ShowVerticalCellLines = false,
            }
        };

        var statsTableView = new TableView(TableUtils.CreateModelTable(character.Stats, "Stat"))
        {
            Y = Pos.Bottom(traitsTableView),
            Width = Dim.Fill(),
            Height = 9,
            FullRowSelect = true,
            CanFocus = false,
            Style = new()
            {
                ShowVerticalCellLines = false,
            }
        };

        var progressBarview = new FrameView("Experience")
        {
            Y = Pos.Bottom(statsTableView),
            Width = Dim.Fill(),
            Height = 3
        };
        var experienceProgressBar = new ProgressBar()
        {
            Fraction = character.Experience / 100f,
            ProgressBarStyle = ProgressBarStyle.MarqueeBlocks,
            Width = Dim.Fill(),
            ColorScheme = new ColorScheme
            {
                Normal = new(Color.Magenta, Color.Gray)
            }
        };
        progressBarview.Add(experienceProgressBar);

        characterSheet.Add(traitsTableView);
        characterSheet.Add(statsTableView);
        characterSheet.Add(progressBarview);

        return characterSheet;
    }

    private FrameView AddInventory(Entity player, FrameView characterSheet)
    {
        var inventoryView = new FrameView("Inventory")
        {
            X = Pos.Right(characterSheet),
            Width = Dim.Fill(),
            Height = Dim.Fill()
        };

        var selectedInventoryItemView = new ItemInfoView(itemViewModel)
        {
            Width = Dim.Fill(),
            Height = 3
        };
        inventoryView.Add(selectedInventoryItemView);

        var inventoryTable = TableUtils.CreateModelTable(player.Inventory, t => t.Item.DisplayName, t => t.Count, "Item", "Count");
        var inventoryTableView = new TableView(inventoryTable)
        {
            Y = Pos.Bottom(selectedInventoryItemView),
            Width = Dim.Fill(),
            Height = Dim.Fill(),
            FullRowSelect = true,
            Style = new()
            {
                ShowVerticalCellLines = false
            }
        };
        inventoryTableView.CellActivated += e =>
        {
            if (e.Table.Rows[e.Row] is DataRow<ItemStack> itemRow && itemRow.Value is ItemStack stack)
            {
                //MessageBox.Query(Frame.Width / 2, Frame.Height / 2, "Item View", stack.Item.ToString(), "Ok");

                itemViewModel.UpdateItemName(stack.Item.DisplayName);
            }
        };
        inventoryView.Add(inventoryTableView);

        return inventoryView;
    }
}

class ItemViewModel : IItemViewModel
{
    public string Name
    {
        get;
        set;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public ItemViewModel(Item item)
    {
        Name = item.DisplayName;
    }

    public void UpdateItemName(string name)
    {
        Name = name;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
    }
}

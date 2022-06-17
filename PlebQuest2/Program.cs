﻿using PlebQuest2.Entities;
using PlebQuest2.Items;
using Terminal.Gui;

Game game = new();

Application.Init();

var window = new Window("Pleb Quest 2");

var characterSheet = AddCharacterSheet(game.Character);
window.Add(characterSheet);

var inventoryTableView = AddInventory(game.Character, window, characterSheet);
window.Add(inventoryTableView);

Application.Top.Add(window);
Application.Run();
Application.Shutdown();

static FrameView AddCharacterSheet(Character character)
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

    var experienceProgressBar = new ProgressBar()
    {
        Y = Pos.Bottom(statsTableView),
        Width = Dim.Fill(),
        Height = 1,
        Fraction = character.Experience / 100f,
        ProgressBarStyle = ProgressBarStyle.Continuous
    };

    characterSheet.Add(traitsTableView);
    characterSheet.Add(statsTableView);
    characterSheet.Add(experienceProgressBar);

    return characterSheet;
}

static TableView AddInventory(Entity player, Window window, FrameView characterSheet)
{
    var inventoryTable = TableUtils.CreateModelTable(player.Inventory, t => t.Item.DisplayName, t => t.Count, "Item", "Count");
    var inventoryTableView = new TableView(inventoryTable)
    {
        X = Pos.Right(characterSheet),
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
            MessageBox.Query(window.Frame.Width / 2, window.Frame.Height / 2, "Item View", stack.Item.ToString(), "Ok");
        }
    };

    return inventoryTableView;
}
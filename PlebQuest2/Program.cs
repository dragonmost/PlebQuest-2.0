using PlebQuest2.Entities;
using PlebQuest2.Items;
using System.Data;
using Terminal.Gui;

var player = new Entity(new("Bob The Player", 2, 200), new Stats
{
    Charisma = Random.Shared.Next(0, 5),
    Constitution = Random.Shared.Next(0, 5),
    Dexterity = Random.Shared.Next(0, 5),
    Intelligence = Random.Shared.Next(0, 5),
    Strength = Random.Shared.Next(0, 5),
    Wisdom = Random.Shared.Next(0, 5),
});

player.Inventory.Add(new Weapon("Sword", SolidMaterial.Iron, 20) { Prefix = ItemPrefix.Blunt });
player.Inventory.Add(new Boot("Boot", SolidMaterial.Rubber) { Prefix = ItemPrefix.Supreme });

Application.Init();

var window = new Window("Pleb Quest 2")
{
    Width = Dim.Fill(),
    Height = Dim.Fill()
};

var traitsTableView = new TableView(CreateTable(player.Traits, "Trait"))
{
    Width = Dim.Fill(),
    Height = 6,
    FullRowSelect = true,
    Style = new()
    {
        ShowVerticalCellLines = false,
    }
};

var statsTableView = new TableView(CreateTable(player.Stats, "Stat"))
{
    Y = Pos.Bottom(traitsTableView),
    Width = Dim.Fill(),
    Height = 9,
    Style = new()
    {
        ShowVerticalCellLines = false,
    }
};

var characterSheet = new FrameView("Character Sheet")
{
    Width = Dim.Percent(25),
    Height = Dim.Fill(),
};
characterSheet.Add(traitsTableView);
characterSheet.Add(statsTableView);

var inventoryTable = CreateTableFromList(player.Inventory, t => t.Item.DisplayName, t => t.Count, "Item", "Count");
var inventoryTableView = new TableView(inventoryTable)
{
    X = Pos.Right(characterSheet),
    Width = Dim.Fill(),
    Height = Dim.Fill(),
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

window.Add(characterSheet);
window.Add(inventoryTableView);

Application.Top.Add(window);
Application.Run();
Application.Shutdown();

static DataTable CreateTable<TModel>(TModel model, string propertyName = "Name", string valueName = "Value") where TModel : notnull
{
    var table = new DataTable<TModel>();
    table.Columns.Add(propertyName);
    table.Columns.Add(valueName);

    foreach (var property in typeof(TModel).GetProperties())
    {
        table.AddRow(model, property.Name, property.GetValue(model));
    }

    return table;
}

static DataTable CreateTableFromList<TModel>(IEnumerable<TModel> models, Func<TModel, string> keySelector, Func<TModel, object> valueSelector, string propertyName = "Name", string valueName = "Value")
{
    var table = new DataTable<TModel>();
    table.Columns.Add(propertyName);
    table.Columns.Add(valueName);

    foreach (var model in models)
    {
        table.AddRow(model, keySelector(model), valueSelector(model));
    }

    return table;
}

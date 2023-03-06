using PlebQuest2.Items;
using PlebQuest2.Views;
using Terminal.Gui;

namespace PlebQuest2.Windows;

internal class InventoryView : ViewModelView<Inventory>
{
    public InventoryView(Inventory inventory)
        : base(inventory, "Inventory")
    {
        var selectedInventoryItemView = new ItemInfoView
        {
            Width = Dim.Fill(),
            Height = 3
        };

        Add(selectedInventoryItemView);

        var inventoryTable = TableUtils.CreateModelTable(inventory, t => t.Item.DisplayName, t => t.Count, "Item", "Count");
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
                selectedInventoryItemView.ViewModel.ItemName = stack.Item.DisplayName;
            }
        };

        Add(inventoryTableView);
    }
}

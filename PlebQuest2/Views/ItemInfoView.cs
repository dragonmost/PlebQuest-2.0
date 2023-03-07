using PlebQuest2.ViewModels;
using Terminal.Gui;

namespace PlebQuest2.Views;

internal class ItemInfoView : ViewModelView<ItemViewModel>
{
    private readonly TextField textField;

    public ItemInfoView() 
        : base(new())
    {
        textField = new()
        {
            Width = Dim.Fill(),
            Height = Dim.Fill()
        };

        Add(textField);

        textField.Bind(ViewModel, t => t.ItemName);
    }
}

using PlebQuest2.ViewModels;
using Terminal.Gui;

namespace PlebQuest2.Views;

internal class ItemInfoView : FrameView
{
    private readonly TextField textField;

    public ItemInfoView(IItemViewModel viewModel)
    {
        textField = new()
        {
            Width = Dim.Fill(),
            Height = Dim.Fill()
        };

        Add(textField);

        textField.Bind(viewModel, t => t.Name);
    }
}

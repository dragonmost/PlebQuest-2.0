using Terminal.Gui;

namespace PlebQuest2.Views;

internal abstract class ViewModelView<TViewModel> : FrameView
{
    public TViewModel ViewModel { get; }

    protected ViewModelView(TViewModel viewModel, string? title = default)
        : base(title ?? "")
    {
        Width = Dim.Fill();
        Height = Dim.Fill();

        ViewModel = viewModel;
    }
}
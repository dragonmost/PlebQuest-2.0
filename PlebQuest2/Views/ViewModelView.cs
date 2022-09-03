using System.ComponentModel;
using Terminal.Gui;

namespace PlebQuest2.Views;

internal abstract class ViewModelView<TViewModel> : FrameView
    where TViewModel : new()
{
    public TViewModel ViewModel { get; } = new();
}
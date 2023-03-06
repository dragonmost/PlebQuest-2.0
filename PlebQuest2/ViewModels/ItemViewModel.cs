using CommunityToolkit.Mvvm.ComponentModel;

namespace PlebQuest2.ViewModels;

internal partial class ItemViewModel : ObservableObject
{
    [ObservableProperty]
    private string? itemName;
}

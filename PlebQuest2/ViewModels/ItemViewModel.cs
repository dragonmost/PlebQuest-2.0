using CommunityToolkit.Mvvm.ComponentModel;
using PlebQuest2.Items;

namespace PlebQuest2.ViewModels;

internal partial class ItemViewModel : ObservableObject
{
    [ObservableProperty]
    private string? itemName;
}

using System.ComponentModel;

namespace PlebQuest2.ViewModels;

internal interface IItemViewModel : INotifyPropertyChanged
{
    string Name { get; }
}

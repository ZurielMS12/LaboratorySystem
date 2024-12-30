using System.Collections.ObjectModel;

namespace Core.MVVM.Patterns
{
    interface ISelectedItem<T>
    {
        ObservableCollection<T> ListItems { get; set; }
        T SelectedItem { get; set; }
    }
}

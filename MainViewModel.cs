using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication4_13
{
    internal partial class MainViewModel : ObservableObject
    {
        private readonly ClickerModel _model = new();
        public int Count => _model.Count;

        [RelayCommand]
        private void Click()
        {
            _model.Increment();
            OnPropertyChanged(nameof(Count));
        }
    }

}

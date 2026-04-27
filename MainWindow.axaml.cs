using Avalonia.Controls;

namespace AvaloniaApplication4_13._04
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
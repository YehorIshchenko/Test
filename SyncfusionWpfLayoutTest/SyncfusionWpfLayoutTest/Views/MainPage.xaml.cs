using System.Windows.Controls;

using SyncfusionWpfLayoutTest.ViewModels;

namespace SyncfusionWpfLayoutTest.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}

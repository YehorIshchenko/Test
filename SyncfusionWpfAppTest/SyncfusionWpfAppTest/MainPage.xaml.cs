using System.Windows;
using System.Windows.Controls;

using SyncfusionWpfAppTest.ViewModels;

namespace SyncfusionWpfAppTest.Views
{
    public partial class MainPage : Window
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}

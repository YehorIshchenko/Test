using System.Windows.Controls;

namespace SyncfusionWpfLayoutTest.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}

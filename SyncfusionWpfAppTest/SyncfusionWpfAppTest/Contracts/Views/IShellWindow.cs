using System.Windows.Controls;

namespace SyncfusionWpfAppTest.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}

using Microsoft.Toolkit.Uwp.UI.Controls;
using Windows.UI.Xaml.Controls;

namespace DemoBasePageBug
{
    public class TestPage : Page
    {
        private AppBar appbar;
        private InAppNotification note;

        public TestPage()
        {
            this.DefaultStyleKey = typeof(TestPage);
        }

        protected override void OnApplyTemplate()
        {
            appbar = GetTemplateChild("appbar") as AppBar;
            note = GetTemplateChild("note") as InAppNotification;
        }

        public void ShowNotification()
        {
            if (appbar != null)
                appbar.IsOpen = true;
            note?.Show();
        }
    }
}

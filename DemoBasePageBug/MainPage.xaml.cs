namespace DemoBasePageBug
{
    public sealed partial class MainPage : TestPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.ShowNotification();
        }
    }
}

namespace PharmacyWaitingRoom
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage is set to a NavigationPage to enable navigation
            MainPage = new NavigationPage(new MainPage());
        }
    }
}

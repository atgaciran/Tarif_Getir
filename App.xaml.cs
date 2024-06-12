
using TarifGetir.Views;

namespace TarifGetir
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new GirişYap();
            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }
}

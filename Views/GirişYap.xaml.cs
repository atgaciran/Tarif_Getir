using TarifGetir.Services; // UserService sınıfının olduğu namespace'i ekleyin
 // Preferences için gerekli

namespace TarifGetir.Views
{
    public partial class GirişYap : ContentPage
    {
        private UserService _userService;

        public GirişYap()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var username = UsernameEntry.Text;
            var password = PasswordEntry.Text;

            var user = await _userService.GetUserByUsernameAndPasswordAsync(username, password);

            if (user != null)
            {
                Preferences.Set("LoggedInUserId", user.Id);
                App.Current.MainPage = new AppShell();
            }
            else
            {
                await DisplayAlert("Error", "Invalid username or password.", "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new HesapOluştur();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            App.Current.MainPage = new SifreUnuttum();
        }
    }
}

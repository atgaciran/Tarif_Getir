using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using TarifGetir.Services;

namespace TarifGetir.ViewModels
{
    public partial class KisiselBilgilerViewModel : ObservableObject
    {
        private readonly UserService _userService;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string lastName;

        public KisiselBilgilerViewModel()
        {
            _userService = new UserService();
            LoadUserDetails();
        }

        private async void LoadUserDetails()
        {
            int userId = Preferences.Get("LoggedInUserId", -1); // Varsayılan değer -1
            if (userId != -1)
            {
                var user = await _userService.GetUserByIdAsync(userId);
                if (user != null)
                {
                    Username = user.Username;
                    Password = user.Password;
                    Name = user.Name;
                    LastName = user.LastName;
                }
            }
        }
    }
}

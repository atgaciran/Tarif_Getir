using SQLite;
using TarifGetir.Models;

namespace TarifGetir.Views;

public partial class SifreUnuttum : ContentPage
{
    private SQLiteAsyncConnection _database;
    public SifreUnuttum()
	{
		InitializeComponent();

        _database = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "TarifGetir.db3"));
        _database.CreateTableAsync<Kullanici>().Wait();

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Giri�Yap();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;
        string lastName = LastNameEntry.Text;
        string username = UserNameEntry.Text;
        string newPassword = NewPasswordEntry.Text; // NewPasswordEntry'nin kullan�c�n�n girdi�i yeni �ifre oldu�unu varsay�yoruz.

        bool result = await ChangePassword(name, lastName, username, newPassword);

        if (result)
        {
            await DisplayAlert("Ba�ar�l�", "�ifre ba�ar�yla de�i�tirildi.", "Tamam");
        }
        else
        {
            await DisplayAlert("Hata", "Kullan�c� bulunamad� veya �ifre de�i�tirilemedi.", "Tamam");
        }
    }

    public async Task<bool> ChangePassword(string firstName, string lastName, string username, string newPassword)
    {
        var user = await _database.Table<Kullanici>()
                                  .Where(u => u.Name == firstName && u.LastName == lastName && u.Username == username)
                                  .FirstOrDefaultAsync();

        if (user != null)
        {
            user.Password = newPassword; // �ifrenin do�ru bir �ekilde hash'lenmi� olmas� gerekti�ini unutmay�n.
            await _database.UpdateAsync(user);
            return true;
        }

        return false;
    }

    //private void Button_Clicked(object sender, EventArgs e)
    //{
    //    string name= NameEntry.Text;
    //    string lastName= LastNameEntry.Text;
    //    string username= UserNameEntry.Text;
    //    string password = GetPassword(name, lastName, username);

    //}
    //public async Task<bool> GetPassword(string firstName, string lastName, string username)
    //{
    //    var user = await _database.Table<Kullanici>()
    //                              .Where(u => u.Name == firstName && u.LastName == lastName && u.Username == username)
    //                              .FirstOrDefaultAsync();
    //}
}

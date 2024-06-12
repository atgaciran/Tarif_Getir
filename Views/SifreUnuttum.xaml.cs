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
        App.Current.MainPage = new GiriþYap();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;
        string lastName = LastNameEntry.Text;
        string username = UserNameEntry.Text;
        string newPassword = NewPasswordEntry.Text; // NewPasswordEntry'nin kullanýcýnýn girdiði yeni þifre olduðunu varsayýyoruz.

        bool result = await ChangePassword(name, lastName, username, newPassword);

        if (result)
        {
            await DisplayAlert("Baþarýlý", "Þifre baþarýyla deðiþtirildi.", "Tamam");
        }
        else
        {
            await DisplayAlert("Hata", "Kullanýcý bulunamadý veya þifre deðiþtirilemedi.", "Tamam");
        }
    }

    public async Task<bool> ChangePassword(string firstName, string lastName, string username, string newPassword)
    {
        var user = await _database.Table<Kullanici>()
                                  .Where(u => u.Name == firstName && u.LastName == lastName && u.Username == username)
                                  .FirstOrDefaultAsync();

        if (user != null)
        {
            user.Password = newPassword; // Þifrenin doðru bir þekilde hash'lenmiþ olmasý gerektiðini unutmayýn.
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

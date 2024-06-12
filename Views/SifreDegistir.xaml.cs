using SQLite;
using TarifGetir.Models;

namespace TarifGetir.Views;


public partial class ŞifreDeğiştir : ContentPage
{
    private SQLiteAsyncConnection _database;

	public ŞifreDeğiştir()
	{
		InitializeComponent();

        _database = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "TarifGetir.db3"));
        _database.CreateTableAsync<Kullanici>().Wait();

	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;
        string lastName = LastNameEntry.Text;
        string username = UserNameEntry.Text;
        string newPassword = NewPasswordEntry.Text;

        bool result = await ChangePassword(name, lastName, username, newPassword);

        if (result)
        {
            await DisplayAlert("Başarılı", "Şifre başarıyla değiştirildi.", "Tamam");
        }
        else
        {
            await DisplayAlert("Hata", "Kullanıcı bulunamadı veya şifre değiştirilemedi.", "Tamam");
        }
    }

    public async Task<bool> ChangePassword(string firstName, string lastName, string username, string newPassword)
    {
        var user = await _database.Table<Kullanici>()
                                  .Where(u => u.Name == firstName && u.LastName == lastName && u.Username == username)
                                  .FirstOrDefaultAsync();

        if (user != null)
        {
            user.Password = newPassword; // Şifrenin doğru bir şekilde hash'lenmiş olması gerektiğini unutmayın.
            await _database.UpdateAsync(user);
            return true;
        }

        return false;
    }



}
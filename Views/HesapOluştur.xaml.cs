using SQLite;
using TarifGetir.Models;

namespace TarifGetir.Views;

public partial class HesapOluştur : ContentPage
{
    private SQLiteAsyncConnection _database;
    public HesapOluştur()
    {
        InitializeComponent();
        _database = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "TarifGetir.db3"));
        _database.CreateTableAsync<Kullanici>().Wait();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var newUser = new Kullanici
        {
            Name = NameEntry.Text,
            LastName = LastNameEntry.Text,
            Username = UsernameEntry.Text,
            Password = PasswordEntry.Text
        };

        await _database.InsertAsync(newUser);
        await DisplayAlert("Success", "Registration successful!", "OK");
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new GirişYap();
    }
}

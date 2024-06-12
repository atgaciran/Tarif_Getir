using TarifGetir.Views;
using TarifGetir.ViewModels;

namespace TarifGetir.Views;

public partial class Tarifler : ContentPage
{
    public Tarifler()
    {
        InitializeComponent();
    }

    public async void Button_Clicked(object sender, EventArgs e)
    {
        if (sender is Button button && int.TryParse(button.CommandParameter.ToString(), out int value))
        {
            await Shell.Current.GoToAsync($"{nameof(YiyecekListesiPage)}?butondegeri={value}");
        }
    }
}

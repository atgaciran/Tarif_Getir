using TarifGetir.Views;

namespace TarifGetir.Views;

public partial class TarifGetir : ContentPage
{
    public TarifGetir()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TarifGetirYemek));
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TarifGetirTatli));
    }
}
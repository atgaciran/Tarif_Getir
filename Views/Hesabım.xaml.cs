using TarifGetir;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TarifGetir.Views;
using TarifGetir.ViewModels;

namespace TarifGetir.Views;

public partial class Hesabım : ContentPage
{
	public Hesabım()
	{
		InitializeComponent();
        BindingContext = new KisiselBilgilerViewModel();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(KisiselBilgiler));
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Favoriler));
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Ayarlar));
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {


        bool answer = await DisplayAlert("Oturumu Kapat", "Oturumu kapatmak istediğinize emin misiniz?", "Hayır", "Evet");

        if (answer == true)
        {
            return;
        }
        else
        {
            App.Current.MainPage = new GirişYap();
        }
    }
}

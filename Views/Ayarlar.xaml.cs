using TarifGetir.Views;

namespace TarifGetir;

public partial class Ayarlar : ContentPage
{
	public Ayarlar()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ÞifreDeðiþtir));
    }
}
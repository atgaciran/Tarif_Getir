using TarifGetir.ViewModels;

namespace TarifGetir.Views;

public partial class KisiselBilgiler : ContentPage
{
    private bool isHidden = false;

    public KisiselBilgiler()
    {
        InitializeComponent();
        BindingContext = new KisiselBilgilerViewModel();
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void showhide_Clicked(object sender, EventArgs e)
    {
        if (isHidden)
        {
            showhide.Source = "show.png";
            SifreLabel.IsVisible = false;
        }
        else
        {
            showhide.Source = "hide.png";
            SifreLabel.IsVisible = true;
        }
        isHidden = !isHidden;
    }
}

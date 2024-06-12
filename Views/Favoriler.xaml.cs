using TarifGetir.Models;
using TarifGetir.Services;
using TarifGetir.ViewModels;
using TarifGetir.Views;

namespace TarifGetir.Views;

public partial class Favoriler : ContentPage
{
    public Favoriler()
    {
        InitializeComponent();
        BindingContext = this;

        MessagingCenter.Subscribe<TarifDetay>(this, "UpdateFavorites", (sender) =>
        {
            OnPropertyChanged(nameof(FavoriYemekler));
        });
    }

    public List<Yiyecek> FavoriYemekler
    {
        get => YiyecekService.FavoriteRecipes;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnRecipeButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var selectedRecipe = button?.CommandParameter as Yiyecek;
        if (selectedRecipe != null)
        {
            var viewModel = new YiyecekDetayViewModel { Yiyecek = selectedRecipe };
            await Navigation.PushAsync(new TarifDetay(viewModel));
        }
    }
}

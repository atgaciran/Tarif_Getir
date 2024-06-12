using TarifGetir.Models;
using TarifGetir.Services;

namespace TarifGetir.Views;

public partial class TarifGetirDetay : ContentPage
{
    public Yiyecek SelectedRecipe { get; set; }

    public TarifGetirDetay(Yiyecek recipe)
    {
        InitializeComponent();
        SelectedRecipe = recipe;
        BindingContext = SelectedRecipe;
        UpdateFavoriteIcon();
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void FavoriyeEkleCikar(object sender, EventArgs e)
    {
        if (YiyecekService.IsFavorite(SelectedRecipe))
        {
            YiyecekService.RemoveFromFavorites(SelectedRecipe);
        }
        else
        {
            YiyecekService.AddToFavorites(SelectedRecipe);
        }
        UpdateFavoriteIcon();
        MessagingCenter.Send(this, "UpdateFavorites");
    }

    private void UpdateFavoriteIcon()
    {
        if (YiyecekService.IsFavorite(SelectedRecipe))
        {
            FavoriteButton.Source = "bookmark1.png";
        }
        else
        {
            FavoriteButton.Source = "bookmark.png";
        }
    }
}
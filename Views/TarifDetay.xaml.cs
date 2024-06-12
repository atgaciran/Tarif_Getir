using TarifGetir.Models;
using TarifGetir.Services;
using TarifGetir.ViewModels;

namespace TarifGetir.Views;

public partial class TarifDetay : ContentPage
{
    public TarifDetay(YiyecekDetayViewModel yiyecekDetayViewModel)
    {
        InitializeComponent();
        BindingContext = yiyecekDetayViewModel;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var viewModel = BindingContext as YiyecekDetayViewModel;
        if (viewModel != null)
        {
            var yiyecek = viewModel.Yiyecek;
            var bookmarkButton = this.FindByName<ImageButton>("bookmarkButton");
            bookmarkButton.Source = YiyecekService.IsFavorite(yiyecek) ? "bookmark1.png" : "bookmark.png";
        }
    }

    private void FavoriyeEkleCikar(object sender, EventArgs e)
    {
        var viewModel = BindingContext as YiyecekDetayViewModel;
        if (viewModel != null)
        {
            var yiyecek = viewModel.Yiyecek;
            var bookmarkButton = sender as ImageButton;
            if (YiyecekService.IsFavorite(yiyecek))
            {
                YiyecekService.RemoveFromFavorites(yiyecek);
                bookmarkButton.Source = "bookmark.png";
            }
            else
            {
                YiyecekService.AddToFavorites(yiyecek);
                bookmarkButton.Source = "bookmark1.png";
            }

            MessagingCenter.Send(this, "UpdateFavorites");
        }
    }
}

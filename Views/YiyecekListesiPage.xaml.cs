using TarifGetir.Services;
using TarifGetir.ViewModels;

namespace TarifGetir.Views;

[QueryProperty(nameof(butondegeri), "butondegeri")]
public partial class YiyecekListesiPage : ContentPage
{
    public int butondegeri { get; set; }
    private readonly YiyecekListelemeViewModel viewModel;

    public YiyecekListesiPage()
    {
        InitializeComponent();
        viewModel = new YiyecekListelemeViewModel(new YiyecekService());
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.LoadYiyecekler(butondegeri);
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}

using System;
using Microsoft.Maui.Controls;
using TarifGetir.Models;
using TarifGetir.Services;
using TarifGetir.ViewModels;
using System.Linq;
using System.Collections.Generic;

namespace TarifGetir.Views
{
    public partial class TarifGetirSonuc : ContentPage
    {
        private readonly YiyecekListelemeViewModel viewModel;
        public TarifGetirSonuc()
        {
            InitializeComponent();
            viewModel = new YiyecekListelemeViewModel(new YiyecekService());
            BindingContext = viewModel;
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        public void SetRecipes(List<Yiyecek> recipes)
        {
            RecipesCollectionView.ItemsSource = recipes;
        }

        private async void OnRecipeFrameTapped(object sender, EventArgs e)
        {
            var frame = sender as Frame;
            if (frame != null)
            {
                // Geçici olarak arka plan rengini deðiþtir
                var originalColor = frame.BackgroundColor;
                frame.BackgroundColor = Colors.LightGray;

                var selectedRecipe = frame.BindingContext as Yiyecek;
                if (selectedRecipe != null)
                {
                    var detaySayfasi = new TarifGetirDetay(selectedRecipe);
                    await Navigation.PushAsync(detaySayfasi);
                }

                // Arka plan rengini eski haline getir
                frame.BackgroundColor = originalColor;
            }
        }

    }
}

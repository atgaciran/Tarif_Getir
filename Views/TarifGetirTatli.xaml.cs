using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;
using TarifGetir.Models;
using TarifGetir.Services;

namespace TarifGetir.Views
{
    public partial class TarifGetirTatli : ContentPage
    {
        private List<string> selectedIngredients = new List<string>();

        private YiyecekService servis = new YiyecekService();

        public TarifGetirTatli()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        //private void OnCategoryClicked(object sender, EventArgs e)
        //{
        //    Button button = sender as Button;
        //    if (button != null)
        //    {
        //        StackLayout list = null;
        //        switch (button.Text)
        //        {
        //            case "Tatlı":
        //                list = DessertsList;
        //                break;
        //        }
        //        if (list != null)
        //        {
        //            list.IsVisible = !list.IsVisible;
        //        }
        //    }
        //}

        private void OnIngredientClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string ingredient = button.Text;
                if (selectedIngredients.Contains(ingredient))
                {
                    selectedIngredients.Remove(ingredient);
                    button.BackgroundColor = Color.FromArgb("#FFFFFF");
                }
                else
                {
                    selectedIngredients.Add(ingredient);
                    button.BackgroundColor = Color.FromArgb("#76cf76"); // Buton rengini yeşil yap
                }
                UpdateSelectedIngredientsLabel();
            }
        }

        private void UpdateSelectedIngredientsLabel()
        {
            SelectedIngredientsLabel.Text = string.Join(", ", selectedIngredients);
        }

        private async void OnSearchRecipesClicked(object sender, EventArgs e)
        {
            var yemek = servis.GetTatli();

            var matchingRecipes = yemek
                .Select(r => new
                {
                    r.Name,
                    r.Resim,
                    r.TarifMetni,
                    r.TarifMalzemeListesi,
                    r.MalzemeListesi,
                    MatchCount = r.MalzemeListesi.Count(i => selectedIngredients.Contains(i)),
                    MissingIngredients = r.MalzemeListesi.Except(selectedIngredients).ToList(),
                    TotalIngredients = r.MalzemeListesi.Count

                })
                .Where(r => r.TotalIngredients > 0 && r.MatchCount >= 1 )
                .Select(r => new Yiyecek
                {
                    Name = r.Name,
                    Resim = r.Resim,
                    TarifMetni = r.TarifMetni,
                    TarifMalzemeListesi = r.TarifMalzemeListesi,
                    MalzemeListesi= r.MalzemeListesi,
                    MatchCount = r.MatchCount,
                    MissingIngredients = r.MissingIngredients,
                    MatchingIngredients = r.MalzemeListesi.Except(r.MissingIngredients).ToList(),
                    TotalIngredients = r.TotalIngredients,
                    MatchPercentage = r.TotalIngredients > 0 ? (double)r.MatchCount / r.TotalIngredients * 100 : 0
                })
                .OrderByDescending(r => r.MatchPercentage)
                .ToList();

            if (matchingRecipes.Any())
            {
                var sonucSayfasi = new TarifGetirSonuc();
                sonucSayfasi.SetRecipes(matchingRecipes);
                await Navigation.PushAsync(sonucSayfasi);
            }
            else
            {
                await DisplayAlert("Uyarı", "Seçilen malzemelerle uygun tarif bulunamadı.", "Tamam");
            }
        }
    }
}

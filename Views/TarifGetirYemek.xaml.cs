using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;
using TarifGetir.Models;
using TarifGetir.Services;

namespace TarifGetir.Views
{
    public partial class TarifGetirYemek : ContentPage
    {

        

        private List<string> selectedIngredients = new List<string>();

        private YiyecekService servis = new YiyecekService();



        public TarifGetirYemek()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnCategoryClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                StackLayout list = null;
                switch (button.Text)
                {
                    case "Sebzeler":
                        list = VegetablesList;
                        break;
                    case "Süt Ürünleri":
                        list = DairyList;
                        break;
                    case "Buðday Ürünleri":
                        list = WheatList;
                        break;
                    case "Baklagiller":
                        list = LegumesList;
                        break;
                    case "Hayvansal Gýda":
                        list = AnimalProductsList;
                        break;
                    case "Ek Ürünler":
                        list = AdditionalProductsList;
                        break;
                }
                if (list != null)
                {
                    list.IsVisible = !list.IsVisible;
                }
            }
        }

        private void OnIngredientClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string ingredient = button.Text; 
                if (selectedIngredients.Contains(ingredient))
                {
                    selectedIngredients.Remove(ingredient);
                    button.BackgroundColor = Color.FromArgb("#FFFFFF"); // Buton rengini eski haline getir (beyaz)
                }
                else
                {
                    selectedIngredients.Add(ingredient);
                    button.BackgroundColor = Color.FromArgb("#76cf76"); // Buton rengini yeþil yap
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
            var anayemek= servis.GetAnaYemek();
            var corba = servis.GetCorba();
            var salata = servis.GetSalata();

            var yemek = anayemek.Concat(corba).Concat(salata);

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
                .Where(r => r.TotalIngredients > 0 && r.MatchCount >= 1)
                .Select(r => new Yiyecek
                {
                    Name = r.Name,
                    Resim = r.Resim,
                    TarifMetni = r.TarifMetni,
                    TarifMalzemeListesi = r.TarifMalzemeListesi,
                    MalzemeListesi = r.MalzemeListesi,
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
                await DisplayAlert("Uyarý", "Seçilen malzemelerle uygun tarif bulunamadý.", "Tamam");
            }
        }


    }
}

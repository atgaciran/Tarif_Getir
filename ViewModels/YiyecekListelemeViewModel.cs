using TarifGetir.Models;
using TarifGetir.Services;
using System.Collections.ObjectModel;
using TarifGetir.Views;
using CommunityToolkit.Mvvm.Input;

namespace TarifGetir.ViewModels
{
    public partial class YiyecekListelemeViewModel : BaseViewModel
    {
        private readonly YiyecekService yiyecekService;

        public ObservableCollection<Yiyecek> Yiyecekler { get; private set; } = new();

        public YiyecekListelemeViewModel(YiyecekService yiyecekService)
        {
            this.yiyecekService = yiyecekService;
        }

        public void LoadYiyecekler(int deger)
        {
            Yiyecekler.Clear();

            if (deger == 1)
            {
                Title = "Ana Yemekler";
                foreach (var item in yiyecekService.GetAnaYemek())
                {
                    Yiyecekler.Add(item);
                }
            }
            else if (deger == 2)
            {
                Title = "Çorbalar";
                foreach (var item in yiyecekService.GetCorba())
                {
                    Yiyecekler.Add(item);
                }
            }
            else if (deger == 3)
            {
                Title = "Salatalar";
                foreach (var item in yiyecekService.GetSalata())
                {
                    Yiyecekler.Add(item);
                }
            }
            else if (deger == 4)
            {
                Title = "Tatlılar";
                foreach (var item in yiyecekService.GetTatli())
                {
                    Yiyecekler.Add(item);
                }
            }
        }

        [ICommand]
        async Task GetYiyecekDetails(Yiyecek  yiyecek)
        {
            if (yiyecek == null) return;

            await Shell.Current.GoToAsync(nameof(TarifDetay), true, new Dictionary<string, object>
            {
                {nameof(Yiyecek), yiyecek}
            });

        }
    }
}
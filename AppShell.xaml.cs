
using TarifGetir.Views;


namespace TarifGetir
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(KisiselBilgiler), typeof(KisiselBilgiler));
            Routing.RegisterRoute(nameof(Ayarlar), typeof(Ayarlar));
            Routing.RegisterRoute(nameof(Favoriler), typeof(Favoriler));
            Routing.RegisterRoute(nameof(ŞifreDeğiştir), typeof(ŞifreDeğiştir));
            Routing.RegisterRoute(nameof(TarifGetirYemek), typeof(TarifGetirYemek));
            Routing.RegisterRoute(nameof(TarifGetirTatli), typeof(TarifGetirTatli));
            Routing.RegisterRoute(nameof(YiyecekListesiPage), typeof(YiyecekListesiPage));
            Routing.RegisterRoute(nameof(TarifDetay), typeof(TarifDetay));
            



        }



    }
}

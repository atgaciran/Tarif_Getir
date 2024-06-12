using CommunityToolkit.Mvvm.ComponentModel;

namespace TarifGetir.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotLoading))]
        bool isLoading;

        public bool IsNotLoading => !isLoading;
    }
}

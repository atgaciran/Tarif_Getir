using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarifGetir.Models;

namespace TarifGetir.ViewModels
{
    [QueryProperty(nameof(Yiyecek),"Yiyecek")]
    public partial class YiyecekDetayViewModel : BaseViewModel
    {
        [ObservableProperty]
        Yiyecek yiyecek;
    }
}

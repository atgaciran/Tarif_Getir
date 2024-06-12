using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarifGetir.Models
{
    public class Yiyecek
    {
        public int Id { get;  set; }
        public string? Name { get; set; }

        public string? TarifMetni { get; set; }

        public ImageSource? Resim { get; set; }

        public List<string>? MalzemeListesi { get; set; }

        public List<string>? TarifMalzemeListesi { get; set; }

        public int MatchCount { get; set; }
        public List<string>? MissingIngredients { get; set; }

        public List<string>? MatchingIngredients { get; set; }
        public int TotalIngredients { get; set; }
        public double MatchPercentage { get; set; }

    }
}

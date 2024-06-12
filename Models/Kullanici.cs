using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarifGetir.Models
{
    public class Kullanici
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

    }
    
}

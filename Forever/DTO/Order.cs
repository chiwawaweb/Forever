using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forever.DTO
{
    public class Order
    {
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public int NbBobines { get; set; }
    }
}

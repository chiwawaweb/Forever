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
        public string Vendeur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Gsm { get; set; }
        public int NbBobines { get; set; }
        public int NbCassettes { get; set; }
        public bool PersoDvdInternet { get; set; }
        public bool PersoDvdPapier { get; set; }
        public int NbUnitCond { get; set; }
        public int NbDiapos { get; set; }
        public int NbPhotos { get; set; }
        public int NbNegatifs { get; set; }
        public bool DvdStandard { get; set; }
        public bool DvdPersonnalise { get; set; }
        public int NbCopySupp { get; set; }
        public bool MontageAvi { get; set; }
        public bool CleUsb { get; set; }
        public bool Hdd { get; set; }
        public bool Link { get; set; }
        public DateTime DateRetour { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

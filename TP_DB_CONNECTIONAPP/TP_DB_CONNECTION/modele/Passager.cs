using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DB_CONNECTION.modele
{
    internal class Passager
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Statut { get; set; }

        public Passager()
        {
            
        }

        public Passager(string nom, string prenom, string adresse, string ville, string pays, string statut)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Ville = ville;
            Pays = pays;
            Statut = statut;
        }

    }
}

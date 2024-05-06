using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DB_CONNECTION.modele
{
    internal class ListeReservation
    {
        public List<Reservation> Listing { get; set; }

        public ListeReservation()
        {
            this.Listing = new List<Reservation>();

        }
        public void AjouterReservation(Reservation reservation) 
        {
            Listing.Add(reservation);
        }
    }
}

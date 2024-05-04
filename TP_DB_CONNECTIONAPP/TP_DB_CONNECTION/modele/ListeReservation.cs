using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DB_CONNECTION.modele
{
    internal class ListeReservation
    {
        public List<Reservation> listing { get; set; }

        public ListeReservation()
        {
            this.listing = new List<Reservation>();

        }
        public void AjouterPassager(Reservation reservation)
        {
            listing.Add(reservation);
        }
    }
}

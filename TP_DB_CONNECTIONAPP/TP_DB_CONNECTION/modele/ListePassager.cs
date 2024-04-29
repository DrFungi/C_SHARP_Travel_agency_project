using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DB_CONNECTION.modele
{
    internal class ListePassager
    {
        public List<Passager> listing { get; set; }

        public ListePassager()
        {
            this.listing = new List<Passager>();

        }
    }
}

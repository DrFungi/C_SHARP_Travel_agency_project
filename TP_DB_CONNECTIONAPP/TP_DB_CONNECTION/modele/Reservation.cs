namespace TP_DB_CONNECTION.modele
{
    internal class Reservation
    {
        public string CodePassager { get; set; }
        public string StatutReservation { get; set; }
        public string DateReservation { get; set; }

        public Reservation()
        {

        }

        public Reservation(string codePassager, string statutReservation, string dateReservation)
        {
            CodePassager = codePassager;
            StatutReservation = statutReservation;
            DateReservation = dateReservation;
        }

    }
}

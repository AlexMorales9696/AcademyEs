namespace EsSpedizioni
{
    public abstract class Spedizione
    {

        protected string Mittente { get; set; }
        protected string Destinatario { get; set; }
        protected double Valore { get; set; }
        protected string IdSpedizione { get; set; }


        public Spedizione(string mittente, string destinatario, string idspedizione, double valore)
        {
            Mittente = mittente;
            Destinatario = destinatario;
            IdSpedizione = idspedizione;
            Valore = valore;
        }


        public double GetValore(Spedizione s)
        {
            return s.Valore;
        }
        public abstract double PrintIngombro();

        public static bool Equals(Spedizione sped1, Spedizione sped2)
        {
            return sped1.IdSpedizione.Equals(sped2.IdSpedizione);
        }

        public string GetSpedizione()
        {
            return $"Mittente : {Mittente} | Destinatario :{Destinatario} | Valore :{Valore} | Ingombro: {PrintIngombro()} ";
        }
    }

}

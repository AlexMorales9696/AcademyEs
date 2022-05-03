namespace EsSpedizioni
{
   public  abstract class Spedizione
    {

        protected string Mittente { get; set; }
        protected string Destinatario { get; set; }
        protected double  Valore { get; set; }
        protected string IdSpedizione { get; set; }
       

        public Spedizione(string mittente,string destinatario,string idspedizione,double valore)
        {
            Mittente = mittente;
            Destinatario = destinatario;
            IdSpedizione = idspedizione;
            Valore = valore;



        }

      //  public  double  Valorew(int valore);
        public abstract double PrintIngombro();

        public Boolean Equals( Spedizione sped1, Spedizione sped2)
        {
            if (sped1.IdSpedizione.Equals(sped2.IdSpedizione))
                return true;
            else
                return false;
        }

        public string GetSpedizione()
        {
            return $"Mittente : {Mittente} | Destinatario :{Destinatario} | Valore :{Valore} | Ingombro: {PrintIngombro()} ";
        }
    }
       
    }

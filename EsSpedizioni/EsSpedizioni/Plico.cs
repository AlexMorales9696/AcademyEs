namespace EsSpedizioni
{
    public class Plico : Spedizione

    {
        private readonly double Altezza;
        private readonly double Lunghezza;
        public Plico(string mittente, string destinatario, string idspedizione, double valore, double altezza, double lunghezza) : base(mittente, destinatario, idspedizione, valore)
        {

            Altezza = altezza;
            Lunghezza = lunghezza;
        }

        public override double PrintIngombro() => Altezza * Lunghezza;

    }

}

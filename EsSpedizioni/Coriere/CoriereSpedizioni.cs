using EsSpedizioni;

namespace Coriere
{
    public class CoriereSpedizioni
    {
        private readonly string Nome;
        private readonly List<Spedizione> Spedizioni;


        public CoriereSpedizioni(string nome)
        {
            Nome = nome;
            Spedizioni = new List<Spedizione>();
        }


        public void AddSpedizione(Spedizione nuovaSpedizione)
        {

            Spedizioni.Add(nuovaSpedizione);
        }

        public double GetTotalIngombro()
        {
            double risutlato = 0;
            foreach (var item in Spedizioni)
                risutlato += item.PrintIngombro();
            return risutlato;
        }
        public string GetSpedizioni()
        {
            string risultato = $"Spedizioni affidate a : {Nome}{Environment.NewLine}";
            foreach (var item in Spedizioni)
                risultato = string.Concat(risultato, item.GetSpedizione(), Environment.NewLine);
            return risultato;
        }

        public void EliminaSPedizioniCorriere()
        {
            Spedizioni.Clear();
        }




    }
}


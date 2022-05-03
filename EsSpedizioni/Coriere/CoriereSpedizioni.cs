using EsSpedizioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Coriere
{
    internal class CoriereSpedizioni
    {
            public string Nome;
            private readonly List<Spedizione> Sped;
        
        
     public CoriereSpedizioni(string nome)
            {
                Nome = nome;
                Sped = new List<Spedizione>();
            }

        public void CancellaTutteSpedizioni()
        {
            
        }
        public void AddSpedizione(Spedizione nuovaSpedizione)
        {
                
                Sped.Add(nuovaSpedizione);
        }

        public double GetTotalIngombro()
            {
                double risutlato = 0;
                foreach (var item in Sped)
                    risutlato += item.PrintIngombro();
                return risutlato;
            }
            public string GetSpedizioni()
            {
                string risultato = $"Spedizioni affidate a : {Nome}{Environment.NewLine}";
                foreach (var item in Sped)
                    risultato = string.Concat(risultato, item.GetSpedizione(), Environment.NewLine);
                return risultato;
            }

        public void EliminaSPedizioniCorriere()
        {
            Sped.Clear();

         }
    }
}


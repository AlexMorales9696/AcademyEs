using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSpedizioni
{
    public  class Pacco : Spedizione
    {
        public readonly double Altezza;
        protected readonly double Lunghezza;
        protected readonly double Profondità;

        
        

        public Pacco(string mittente, string destinatario, string idspedizione, double  valore, double altezza, double lunghezza,double profondità) :base(mittente, destinatario, idspedizione, valore)
    {

            Altezza = altezza;
            Lunghezza = lunghezza;
            Profondità = profondità;
        }

        public override double PrintIngombro() => Altezza * Lunghezza * Profondità;
      
    }
}

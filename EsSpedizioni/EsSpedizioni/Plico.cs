using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsSpedizioni
{
    public  class Plico : Spedizione

    {
        private  double Altezza;
        private  double Lunghezza;
        public Plico(string mittente, string destinatario, string idspedizione, double valore,double altezza,double lunghezza) :base(mittente, destinatario,idspedizione,valore)
        {

            Altezza = altezza;
           Lunghezza= lunghezza;
        }

        public override double PrintIngombro() => Altezza * Lunghezza;
        
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pate_InfoTest
{
    public class Pate_Lavoratore : Pate_Candidato
    {
        uint pate_esperienze;
        public uint Pate_esperienze
        {
            set
            {
                if (value > 5)
                    throw new Exception("Esperienze massime 5");
                else
                    pate_esperienze = value;
            }
            get { return pate_esperienze; }
        }
        public Pate_Lavoratore()
        {
            pate_esperienze = 0;
        }
        public Pate_Lavoratore(uint esp)
        {
            pate_esperienze = 0;
            Pate_esperienze = esp;
        }
        public override int punteggio()
        {
            return (int)pate_esperienze * 20;
        }
        public override bool isIdoneo()
        {
            if(punteggio() >= 60)
                return true;
            return false;
        }
    }
}

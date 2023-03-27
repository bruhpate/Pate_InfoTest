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
        public override string ToString()
        {
            return $"Matricola: {Pate_matricola} Nome: {Pate_nome} Esperienze: {pate_esperienze}";
        }
        public override bool Equals(Pate_Candidato obj)
        {
            Pate_Lavoratore obje = obj as Pate_Lavoratore;
            if (base.Equals(obj) && this.pate_esperienze == obje.pate_esperienze)
                return true;
            else
                return false;
        }
        public override int CompareTo(Pate_Candidato obj)
        {
            if (obj == null)
                return 1;
            Pate_Lavoratore obje = obj as Pate_Lavoratore
            if (obje.punteggio() < this.punteggio())
                return 1;
            else if (obj.punteggio() > this.punteggio())
                return -1;
            return 0;
        }
    }
}

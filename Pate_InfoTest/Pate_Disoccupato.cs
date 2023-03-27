using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pate_InfoTest
{
    public class Pate_Disoccupato : Pate_Candidato
    {
        //inizio Task2
        private uint pate_voto;
        private bool pate_lode;
        public uint Pate_voto
        {
            set
            {
                if (value > 110)
                    throw new Exception("Voto superiore a 110");
                else
                    pate_voto = value;
                    if (value == 110)
                        Pate_lode = true;
                    else
                        Pate_lode = false;
            }
            get { return pate_voto; }
        }
        public bool Pate_lode
        {
            set
            {
                pate_lode = value;
            }
            get { return pate_lode; }
        }

        public Pate_Disoccupato()
        {
            pate_voto = 0;
            pate_lode = false;
        }
        public Pate_Disoccupato(uint voto)
        {
            Pate_voto = voto;
            Pate_lode = false;
        }
        public override int punteggio()
        { 
            if(pate_voto == 105)
            {
                pate_voto += 5;
            }
            int punt = (100 * (int)pate_voto) / 110;
            return punt
        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 72)
                return true;
            else
                return false;

        }
    }
}

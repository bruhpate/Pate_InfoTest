using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pate_InfoTest
{
    public abstract class Pate_Candidato
    {
        private int pate_matricola;
        private string pate_nome;
        public int Pate_matricola { get { return pate_matricola; } set { pate_matricola = value; } }
        public string Pate_nome { get { return pate_nome; } set { pate_nome = value; } }

        public Pate_Candidato()
        {
            pate_matricola = 0;
            pate_nome = null;
        }
        public Pate_Candidato(int matricola)
        {
            pate_matricola = matricola;
            pate_nome = null;
        }
        public Pate_Candidato(string nome)
        {
            pate_matricola = 0;
            pate_nome = nome;
        }
        public Pate_Candidato(int matricola, string nome)
        {
            pate_matricola = matricola;
            pate_nome = nome;
        }
        public virtual bool isIdoneo()
        {
            bool ret = false;
            return ret;
        }
        public virtual int punteggio()
        {
            int ret = 0;
            return ret;
        }
    }
}

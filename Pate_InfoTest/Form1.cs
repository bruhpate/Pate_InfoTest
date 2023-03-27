using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pate_InfoTest
{
    public partial class Form1 : Form
    {
        List<Pate_Candidato> Candidati;
        public Form1()
        {
            InitializeComponent();
            Candidati = new List<Pate_Candidato>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Aggiungi(Pate_Candidato c)
        {
            Candidati.Add(c);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void modifica(int d, Pate_Candidato c)
        {
            int i = 0;
            foreach(Pate_Candidato s in Candidati)
            {
                i++;
                if (s.Pate_matricola == d)
                {
                    Candidati[i] = c;
                }
            }
        }
        public void stampa()
        {
            listView1.Clear();
            foreach (Pate_Candidato c in Candidati)
            {
                listView1.Items.Add(c.ToString());
            }
        }
        public void elimina(int m)
        {
            foreach(Pate_Candidato c in Candidati)
            {
                if (c.Pate_matricola == m)
                    Candidati.Remove(c);
            }
        }
        public void idoneo()
        {
            for(int i = 0; i < Candidati.Count; i++)
            {
                listView1.Clear();
                if (Candidati[i].isIdoneo())
                {
                    listView1.Items.Add(Candidati[i].ToString());
                }
            }
        }
    }
}

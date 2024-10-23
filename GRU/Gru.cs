using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRU
{
    internal class Gru
    {
        private string numSeriale;
        private string produttore;
        private int pesoMax;
        private int pesoMin;
        private int altBraccio;

        public int AltBraccio
        {
            get { return altBraccio; }
            set { altBraccio = value; }
        }
        public int PesoMax
        {
            get { return pesoMax; }
        }

        public int AltMin
        {
            get { return AltMin; }
        }

        public int AltMax
        {
            get { return AltMax; }
        }

        public Gru(string numSeriale, string produttore, int pesoMax, int pesoMin, int altBraccio)
        {
            this.numSeriale = numSeriale;
            this.produttore = produttore;
            this.pesoMax = pesoMax; 
            this.pesoMin = pesoMin;
            this.altBraccio = altBraccio;
        }

        public void alza()
        {
            AltBraccio = AltBraccio + 10;    
        }

        public void abbassa()
        {
            AltBraccio = AltBraccio - 10;
        }


    }
}

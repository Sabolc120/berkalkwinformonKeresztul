using System;
using System.Collections.Generic;
using System.Text;

namespace beadando
{
    class Calculator
    {
        public string Nev;
        public double brutto;
        public double SZJA;
        public double TBA;
        public double netto;
        public Calculator(double brutto)
        {
            this.brutto = brutto;
        }
        public void Calculating()
        {
            this.SZJA = this.brutto * 0.15;
            this.TBA = this.brutto * 0.185;
            this.netto = this.brutto - this.brutto * 0.285;
        }
        public void twentyFiveCalculating()
        {
            this.SZJA = 0;
            this.TBA = this.brutto * 0.185;
            this.netto = this.brutto - this.TBA;
        }
    }
}

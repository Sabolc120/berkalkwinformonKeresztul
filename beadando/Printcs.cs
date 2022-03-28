using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace beadando
{
    class Printcs : Calculator
    {
        public Printcs(double brutto) : base(brutto)
        {
            this.brutto = brutto;
        }
        public void printIt()
        {
            StreamWriter iro = new StreamWriter("mentes.txt");
            iro.WriteLine("Munkavállaló neve: {0}",this.Nev);
            iro.WriteLine("Bérfejtő lap mentése a következő munkavállalónak: {0}",this.Nev);
            iro.WriteLine("Bruttó bér: {0}", this.brutto);
            iro.WriteLine("SZJA: {0}", this.SZJA);
            iro.WriteLine("TBA: {0}", this.TBA);
            iro.WriteLine("Netto: {0}", this.netto);
            iro.WriteLine("Dátum: {0}", DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            iro.Close();
        }
    }
}

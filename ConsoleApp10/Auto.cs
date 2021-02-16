using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10
{
    public class Auto : IComparable<Auto>
    {
        private String merkki;
        private int vuosimalli;

        public Auto(String merkki, int vuosimalli)
        {
            this.merkki = merkki;
            this.vuosimalli = vuosimalli;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("Merkki: " + merkki + "\tVuosimalli: " + vuosimalli);
        }

        public int CompareTo(Auto vertaileAuto)
        {
            if (vertaileAuto == null)
                return 1;
            else
                return this.vuosimalli.CompareTo(vertaileAuto.vuosimalli);
        }
    }
}
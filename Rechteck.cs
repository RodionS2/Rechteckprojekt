using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteckprojekt
{
    class Rechteck
    {
        private double breite;
        private double hoehe;

        public Rechteck(double breite, double hoehe)
        {
            this.Breite = breite;
            this.Hoehe = hoehe;
        }

        public Rechteck(double seitenlaenge)
        {
            this.Breite = seitenlaenge;
            this.Hoehe = seitenlaenge;
        }

        public double Breite
        {
            get { return this.breite; }
            set
            {
                if (value > 0)
                {
                    this.breite = value;
                }
                else
                {
                    throw new ArgumentException("Die Breite muss größer als 0 sein!");
                }
            }
        }

        public double Hoehe
        {
            get { return this.hoehe; }
            set
            {
                if (value > 0)
                {
                    this.hoehe = value;
                }
                else
                {
                    throw new ArgumentException("Die Höhe muss größer als 0 sein!");
                }
            }
        }

        public double Umfang
        {
            get { return 2 * (this.breite + this.hoehe); }
        }

        public double Flaeche
        {
            get { return this.breite * this.hoehe; }
        }

        public double Diagonale
        {
            get { return Math.Sqrt(Math.Pow(this.breite, 2) + Math.Pow(this.hoehe, 2)); }
        }

        public void Zoom(double faktor)
        {
            if (faktor > 0)
            {
                this.Breite *= faktor;
                this.Hoehe *= faktor;
            }
            else
            {
                throw new ArgumentException("Der Zoom-Faktor muss positiv sein!");
            }
        }

        public void Rechtsdrehung()
        {
            double tausch = this.hoehe;
            this.hoehe = this.breite;
            this.breite = tausch;
        }
    }
}

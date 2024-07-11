using System;

namespace Ispit.Proizvodi
{
    internal class Polaznik
    {
        public string ImePrezime { get; set; }

        public delegate void PredajIspit(Polaznik polaznik);

        public event PredajIspit IspitZavrsen;

        public void OdgovoriNaPitanja(DateTime vrijemePocetka)
        {
            Console.WriteLine($"Polaznik {ImePrezime} je počeo/la pisati ispit u {vrijemePocetka:dd.MM.yyyy HH:mm:ss}\n");
        }

        public void PredajOdgovoreNaPitanja()
        {
            Console.WriteLine($"Polaznik {ImePrezime} je predao/la ispit.");
            IspitZavrsen?.Invoke(this); 
        }
    }
}

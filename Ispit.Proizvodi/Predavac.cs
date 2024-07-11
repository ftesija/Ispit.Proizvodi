using System;
using static Ispit.Proizvodi.Program;

namespace Ispit.Proizvodi
{
    internal class Predavac
    {
        public event PocniPisatiIspit Ispit;

        public void ZvoniZvono()
        {
            DateTime datumVrijeme = DateTime.Now;
            Console.WriteLine($"BRRR! BRRR! Zvono je zazvonilo!\nIspit počinje u {datumVrijeme:dd.MM.yyyy HH:mm:ss}\n");
            Ispit?.Invoke(datumVrijeme);
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine($"Predavač je zaprimio riješen ispit od polaznika {polaznik.ImePrezime}.");
        }
    }
}

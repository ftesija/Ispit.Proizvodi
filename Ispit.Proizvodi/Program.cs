using System;

namespace Ispit.Proizvodi
{
    internal class Program
    {
        public delegate void PocniPisatiIspit(DateTime datumVrijeme);

        static void Main(string[] args)
        {
            Predavac predavac = new Predavac();
            Polaznik[] polaznik = new Polaznik[4];

            polaznik[0] = new Polaznik { ImePrezime = "Ivan Babić" };
            polaznik[1] = new Polaznik { ImePrezime = "Ana Tolj" };
            polaznik[2] = new Polaznik { ImePrezime = "Ivana Čalić" };
            polaznik[3] = new Polaznik { ImePrezime = "Luka Rosić" };

            foreach (Polaznik p in polaznik)
            {
                p.IspitZavrsen += predavac.IspitZaprimljen;
            }

            predavac.ZvoniZvono();

            for (int i = 0; i < polaznik.Length; i++)
            {
                DateTime vrijemePocetka = DateTime.Now;
                polaznik[i].OdgovoriNaPitanja(vrijemePocetka);

            }

            polaznik[2].PredajOdgovoreNaPitanja();

            Console.ReadKey();
        }
    }
}

using ArabaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaApp.Data
{
    public static class ArabaData
    {
        public static List<Araba> Arabalar { get; set; }

        static ArabaData()
        {
            Arabalar = new List<Araba>()
            {
                new Araba()
                {
                    Id = 1,
                    Marka = "Audi",
                    Model = "A 4",
                    Km = 98.65,
                    Vites = "Otomatik"
                },
                new Araba()
                {
                    Id = 2,
                    Marka = "Audi",
                    Model = "A 100",
                    Km = 112.90,
                    Vites = "Yari otomatik"
                },
                new Araba()
                {
                    Id = 3,
                    Marka = "Honda",
                    Model = "Accord",
                    Km = 68.65,
                    Vites = "Triptonik"
                }

            };

        }

    }
}

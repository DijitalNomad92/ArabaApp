using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaApp.Models
{
    public class Araba
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

        public double Km { get; set; }

        public string Vites { get; set; }

    }
}

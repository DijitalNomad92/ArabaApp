using ArabaApp.Data;
using ArabaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaApp.Services
{
    public class ArabaService
    {
        public List<Araba> Getir()
        {
            return ArabaData.Arabalar;
        }

        public Araba Getir(int id)
        {
            Araba araba = ArabaData.Arabalar.SingleOrDefault(araba => araba.Id == id);
            return araba;
        }

        public List<Araba> Getir(string marka, string model)
        {
            List<Araba> arabalar = ArabaData.Arabalar.Where(araba => araba.Marka == marka && araba.Model == model).ToList();
            return arabalar;
        }

        public Araba Getir(string vites)
        {

            Araba araba = ArabaData.Arabalar.SingleOrDefault(araba => araba.Vites == vites);
            return araba;
        }
    }

}

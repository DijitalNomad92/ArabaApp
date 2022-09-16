using ArabaApp.Models;
using ArabaApp.Services;

namespace ArabaApp
{
    public partial class Form1 : Form
    {
        ArabaService _service = new ArabaService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArabalariGetir();
        }

        private void ArabalariGetir()
        {
            dgvArabalar.DataSource = _service.Getir();
        }     
        private void bDetay_Click(object sender, EventArgs e)
        {
            ArabaDetayiniGetir(Convert.ToInt32(nudId.Value));
        }

        private void ArabaDetayiniGetir(int id)
        {
            try
            {
                Araba araba = _service.Getir(id);

                if (araba == null)
                {
                    MessageBox.Show("Araba bulunmadi!");
                    return;
                }
                string message = "";
                message = $" ID : {araba.Id}, MARKA : {araba.Marka}, MODEL : {araba.Model}, KM : {araba.Km}, VITES : {araba.Vites}";
                MessageBox.Show(message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void bFiltrele_Click(object sender, EventArgs e)
        {
            Filtele(tbMarka.Text.Trim(), tbModel.Text.Trim());
        }

        private void Filtele(string marka, string model)
        {
            dvfFiltrele.DataSource = _service.Getir(marka, model);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VitesDetayGetir(tbVites.Text.Trim());
        }

        private void VitesDetayGetir(string vites)
        {
            try
            {
                Araba araba = _service.Getir(vites);

                if (araba == null)
                {
                    MessageBox.Show("Araba bulunmadi!");
                    return;
                }

                string Mesaj = "";

                Mesaj = $" ID : {araba.Id}, MARKA : {araba.Marka}, MODEL : {araba.Model}, KM : {araba.Km}, VITES : {araba.Vites}";
                MessageBox.Show(Mesaj);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }
    }
}
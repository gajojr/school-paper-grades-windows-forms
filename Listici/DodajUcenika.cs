using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listici
{
    public partial class DodajUcenika : Form
    {
        public DodajUcenika()
        {
            InitializeComponent();
        }

        private void posalji_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string ime = imeUnos.Text;
            string prezime = prezimeUnos.Text;
            string email = emailUnos.Text;
            string telefon = telefonUnos.Text;
            string odeljenje = odeljenjeUnos.Text;

            List<int> ids = db.FindOdeljenjeAbdRazredniId(odeljenje);
            
            Ucenik ucenik = new Ucenik();
            ucenik.Ime = ime;
            ucenik.Prezime = prezime;
            ucenik.Email = email;
            ucenik.Telefon = telefon;
            ucenik.IdOdeljenja = ids[0];
            ucenik.IdRazrednog = ids[1];

            db.CreateUcenik(ucenik);

            poruka.Text = "Uspesno dodat novi ucenik";
        }

        private void ponisti_Click(object sender, EventArgs e)
        {
            imeUnos.Text = "";
            prezimeUnos.Text = "";
            emailUnos.Text = "";
            telefonUnos.Text = "";
            odeljenjeUnos.Text = "";

            poruka.Text = "Forma resetovana!";
        }
    }
}

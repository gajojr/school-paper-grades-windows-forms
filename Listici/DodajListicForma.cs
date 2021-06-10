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
    public partial class DodajListicForma : Form
    {
        public DodajListicForma()
        {
            InitializeComponent();
        }

        private void dodajListic_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            try
            {
                // o uceniku
                string ime = imeUcenika.Text;
                string prezime = prezimeUcenika.Text;

                // o staresini
                string imeRazrednog = razredni.Text.Split(' ')[0];
                string prezimeRazrednog = razredni.Text.Split(' ')[1];

                // trazimo id ucenika po imenu i prezimenu i po razrednom
                string idUcenika = db.GetUcenik(ime, prezime, imeRazrednog, prezimeRazrednog);

                Ocene ocene = new Ocene();
                ocene.IdUcenika = int.Parse(idUcenika);
                ocene.Srpski = srpskiOcene.Text;
                ocene.Matematika = matematikaOcene.Text;
                ocene.Programiranje = programiranjeOcene.Text;
                ocene.Web_programiranje = webOcene.Text;
                ocene.Baze_podataka = bazePodatakaOcene.Text;
                ocene.Tehnicka_dokumentacija = dokumentacijaOcene.Text;
                ocene.Engleski = engleskiOcene.Text;
                ocene.Android_programiranje = androidOcene.Text;
                ocene.Sociologija = sociologijaOcene.Text;

                db.NapraviListic(ocene);

                poruka.Text = "Listic dodat!";
            }
            catch
            {
                poruka.BackColor = Color.Red;
                poruka.ForeColor = Color.White;
                poruka.Text = "Greska pri unosu, listic nije dodat!";
            }
        }

        private void ponistiListic_Click(object sender, EventArgs e)
        {
            // isprazni sve inpute
            imeUcenika.Text = "";
            prezimeUcenika.Text = "";
            srpskiOcene.Text = "";
            matematikaOcene.Text = "";
            programiranjeOcene.Text = "";
            webOcene.Text = "";
            bazePodatakaOcene.Text = "";
            dokumentacijaOcene.Text = "";
            engleskiOcene.Text = "";
            androidOcene.Text = "";
            sociologijaOcene.Text = "";
            razredni.Text = "";

            poruka.Text = "Forma resetovana!";
        }
    }
}

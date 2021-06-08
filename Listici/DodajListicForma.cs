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

        private void button1_Click(object sender, EventArgs e)
        {
                DataAccess db = new DataAccess();
                // o uceniku
                string ime = imeUcenika.Text;
                string prezime = prezimeUcenika.Text;

                // trazimo id ucenika po imenu i prezimenu
                // ovde ne radi
                string idUcenika = db.GetUcenik(ime, prezime);

                Ocene ocene = new Ocene();
                //ocene.IdUcenika = idUcenika;
                ocene.Srpski = srpskiOcene.Text;
                ocene.Matematika = matematikaOcene.Text;
                ocene.Srpski = programiranjeOcene.Text;
                ocene.Srpski = webOcene.Text;
                ocene.Srpski = bazePodatakaOcene.Text;
                ocene.Srpski = dokumentacijaOcene.Text;
                ocene.Srpski = engleskiOcene.Text;
                ocene.Srpski = androidOcene.Text;
                ocene.Sociologija = sociologijaOcene.Text;

                // o staresini
                string imeRazrednog = razredni.Text.Split(' ')[0];
                string prezimeRazrednog = razredni.Text.Split(' ')[1];

                poruka.Text = "Podaci poslati!";

                
                db.NapraviListic(ocene);
        }

        private void button2_Click(object sender, EventArgs e)
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

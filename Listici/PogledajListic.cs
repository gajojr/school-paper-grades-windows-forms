using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Listici
{
    public partial class PogledajListic : Form
    {
        public PogledajListic()
        {
            InitializeComponent();
        }

        private void traziUcenika_Click(object sender, EventArgs e)
        {
            string ime = imeUnos.Text;
            string prezime = prezimeUnos.Text;
            string odeljenje = odeljenjeUnos.Text;

            DataAccess db = new DataAccess();
            int idOdeljenja = db.FindOdeljenjeId(odeljenje);
            int idUcenika = db.FindUcenikId(ime, prezime, idOdeljenja);
            Ocene ocene = db.FindOcene(idUcenika);

            srpskiOcene.Text = ocene.Srpski;
            matematikaOcene.Text = ocene.Matematika;
            programiranjeOcene.Text = ocene.Programiranje;
            webOcene.Text = ocene.Web_programiranje;
            bazeOcene.Text = ocene.Baze_podataka;
            dokumentacijaOcene.Text = ocene.Tehnicka_dokumentacija;
            engleskiOcene.Text = ocene.Engleski;
            androidOcene.Text = ocene.Android_programiranje;
            sociologijaOcene.Text = ocene.Sociologija;

            zakljucnaSrpski.Text = ZakljucnaOcena(ocene.Srpski).ToString();
            zakljucnaMatematika.Text = ZakljucnaOcena(ocene.Matematika).ToString();
            zakljucnaProgramiranje.Text = ZakljucnaOcena(ocene.Programiranje).ToString();
            zakljucnaWeb.Text = ZakljucnaOcena(ocene.Web_programiranje).ToString();
            zakljucnaBaze.Text = ZakljucnaOcena(ocene.Baze_podataka).ToString();
            zakljucnaDokumentacija.Text = ZakljucnaOcena(ocene.Tehnicka_dokumentacija).ToString();
            zakljucnaEngleski.Text = ZakljucnaOcena(ocene.Engleski).ToString();
            zakljucnaAndroid.Text = ZakljucnaOcena(ocene.Android_programiranje).ToString();
            zakljucnaSociologija.Text = ZakljucnaOcena(ocene.Sociologija).ToString();

            double krajnjiUspeh = uspeh(ZakljucnaOcena(ocene.Srpski), ZakljucnaOcena(ocene.Matematika), ZakljucnaOcena(ocene.Programiranje), ZakljucnaOcena(ocene.Web_programiranje), ZakljucnaOcena(ocene.Baze_podataka), ZakljucnaOcena(ocene.Tehnicka_dokumentacija), ZakljucnaOcena(ocene.Engleski), ZakljucnaOcena(ocene.Android_programiranje), ZakljucnaOcena(ocene.Sociologija));
            string imeIPrezimeRazrednog = db.FindRazredni(idOdeljenja);

            stanje.Text = "Ucenik je zavrsio razred sa prosekom: " + Math.Round(krajnjiUspeh, 2);
            razredni.Text = "Razredni staresina: " + imeIPrezimeRazrednog;
        }

        private double ZakljucnaOcena(string ocene)
        {
            // regex da izdvoji sve cifre
            string[] nizOcena = Regex.Split(ocene, @"\D+");
            List<double> vrednosti = new List<double>();
            foreach(string ocena in nizOcena)
            {
                try
                {
                    vrednosti.Add(double.Parse(ocena));
                }
                catch
                {

                }
            }

            double sumaOcena = vrednosti.Sum();

            return Math.Round(sumaOcena / vrednosti.Count);
        }

        private double uspeh(double srpski, double matematika, double programiranje, double web, double baze, double dokumentacija, double engleski, double android, double sociologija)
        {
            return (srpski + matematika + programiranje + web + baze + dokumentacija + engleski + android + sociologija) / 9;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Listici
{
    public class DataAccess
    {
        public string GetUcenik(string imeUcenika, string prezimeUcenika, string imeRazrednog, string prezimeRazrednog)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GajovaDB")))
            {
                List<Ucenik> ucenici = connection.Query<Ucenik>($"SELECT Ucenik.Id FROM Ucenik JOIN Razredni ON Ucenik.id_razrednog = Razredni.Id WHERE Razredni.ime = '{imeRazrednog}' AND Razredni.prezime = '{prezimeRazrednog}' AND Ucenik.ime = '{imeUcenika}' AND Ucenik.prezime = '{prezimeUcenika}';").ToList();

                return ucenici[0].Id.ToString();
            }
        }

        public void CreateUcenik(Ucenik ucenik)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GajovaDB")))
            {
                string sql = "INSERT INTO Ucenik (ime, prezime, email, telefon, id_odeljenja, id_razrednog) VALUES (@Ime, @Prezime, @Email, @Telefon, @IdOdeljenja, @IdRazrednog);";
                connection.Execute(sql, new
                {
                    Ime = ucenik.Ime,
                    Prezime = ucenik.Prezime,
                    Email = ucenik.Email,
                    Telefon = ucenik.Telefon,
                    IdOdeljenja = ucenik.IdOdeljenja,
                    IdRazrednog = ucenik.IdRazrednog
                });
            }
        }

        public List<int> FindOdeljenjeAbdRazredniId(string imeOdeljenja)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GajovaDB")))
            {
                List<Odeljenje> odeljenja = connection.Query<Odeljenje>($"SELECT * FROM Odeljenje WHERE ime = '{imeOdeljenja}'").ToList();
                List<Razredni> razredni = connection.Query<Razredni>($"SELECT * FROM Razredni WHERE id_odeljenja = '{odeljenja[0].Id}'").ToList();

                List<int> ids = new List<int>();
                ids.Add(odeljenja[0].Id);
                ids.Add(razredni[0].Id);

                return ids;
            }
        }

        public void NapraviListic(Ocene ocene)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GajovaDB")))
            {
                string sql = "INSERT INTO Ocene (IdUcenika, srpski, matematika, programiranje, web_programiranje, baze_podataka, tehnicka_dokumentacija, engleski, android_programiranje, sociologija) VALUES (@IdUcenika, @Srpski, @Matematika, @Programiranje, @Web_programiranje, @Baze_podataka, @Tehnicka_dokumentacija, @Engleski, @Android_programiranje, @Sociologija);";
                connection.Execute(sql, new
                {
                    IdUcenika = ocene.IdUcenika,
                    Srpski = ocene.Srpski,
                    Matematika = ocene.Matematika,
                    Programiranje = ocene.Programiranje,
                    Web_programiranje = ocene.Web_programiranje,
                    Baze_podataka = ocene.Baze_podataka,
                    Tehnicka_dokumentacija = ocene.Tehnicka_dokumentacija,
                    Engleski = ocene.Engleski,
                    Android_programiranje = ocene.Android_programiranje,
                    Sociologija = ocene.Sociologija
                });
            }
        }
    }
}

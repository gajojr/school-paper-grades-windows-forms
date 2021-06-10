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
                List<Ucenik> ucenici = connection.Query<Ucenik>($"SELECT * FROM Ucenik JOIN Razredni ON Ucenik.id_razrednog = Razredni.Id WHERE Razredni.ime = '{imeRazrednog}' AND Razredni.prezime = '{prezimeRazrednog}' AND Ucenik.ime = '{imeUcenika}' AND Ucenik.prezime = '{prezimeUcenika}';").ToList();

                return ucenici[0].Id.ToString();
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

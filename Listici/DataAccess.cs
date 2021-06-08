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
        /*public List<Odeljenje> GetOdeljenja()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GajovaDB")))
            {
                return connection.Query<Odeljenje>("SELECT * FROM Odeljenje").ToList();
            }
        }*/

        public string GetUcenik(string ime, string prezime)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GajovaDB")))
            {
                return connection.Query($"SELECT Id FROM Ucenik WHERE ime = {ime} AND prezime = {prezime}").ToString();
            }
        }

        public void NapraviListic(Ocene ocene)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GajovaDB")))
            {
                connection.Query($"INSERT INTO Ocene (IdUcenika, srpski, matematika, programiranje, web_programiranje, baze_podataka, tehnicka_dokumentacija, engleski, android_programiranje, sociologija) VALUES({ocene.IdUcenika}, {ocene.Srpski}, {ocene.Matematika}, {ocene.Programiranje}, {ocene.Web_programiranje}, {ocene.Baze_podataka}, {ocene.Tehnicka_dokumentacija}, {ocene.Engleski}, {ocene.Android_programiranje}, {ocene.Sociologija}); ");
            }
        }
    }
}

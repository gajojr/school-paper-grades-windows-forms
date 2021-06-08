using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Listici
{
    public class DataAccess
    {
        public List<Odeljenje> GetOdeljenja()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GajovaDB")))
            {
                return connection.Query<Odeljenje>("SELECT * FROM Odeljenje").ToList();
            }
        }
    }
}

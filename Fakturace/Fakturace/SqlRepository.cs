using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturace
{
    class SqlRepository
    {
        public string ConnectionString { get; set; }

        public SqlRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Zakaz> NactiZakaznik()
        {
            List<Zakaz> zakaznik = new List<Zakaz>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select * from Zakaznik", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zakaznik.Add(new Zakaz(Convert.ToInt32(dataReader["IdZakaznik"]),
                                                   dataReader["TypZak"].ToString(),
                                                   dataReader["Adresa"].ToString(),
                                                   dataReader["ICO"].ToString(),
                                                   dataReader["Email"].ToString(),
                                                   ))); 
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zakaznik;
        }
    }
}

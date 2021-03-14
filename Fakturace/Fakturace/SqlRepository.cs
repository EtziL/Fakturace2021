using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturace
{
    public class SqlRepository
    {
        public string ConnectionString { get; set; }

        public SqlRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Zakaz> NactiZakaznik(string sloupecTrideni, bool sestupne, string hledani)
        {
            List<Zakaz> zakaznik = new List<Zakaz>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(" ", sqlConnection))
                {
                    sqlCommand.CommandText = $"select * from Zakaznik where jmeno like @Hledani or prijmeni like @Hledani order by {sloupecTrideni}{(sestupne ? " desc" : "")}"; 
                    sqlCommand.Parameters.AddWithValue("Hledani", "%" + hledani + "%");
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zakaznik.Add(new Zakaz(Convert.ToInt32(dataReader["IdZakaznik"]),
                                                   dataReader["TypZak"].ToString(),
                                                   dataReader["Adresa"].ToString(),
                                                   Convert.ToInt32(dataReader["ICO"]),
                                                   dataReader["Email"].ToString(),
                                                   Convert.ToInt32(dataReader["Telefon"]),
                                                   dataReader["Jmeno"].ToString(),
                                                   dataReader["Prijmeni"].ToString())); 
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zakaznik;
        }
        public List<Zbz> NactiZbozi()
        {
            List<Zbz> zbozi = new List<Zbz>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select * from Zbozi", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zbozi.Add(new Zbz(Convert.ToInt32(dataReader["IdZbozi"]),
                                                   dataReader["Nazev"].ToString(),
                                                   Convert.ToInt32(dataReader["CenaBezDPH"]),
                                                   Convert.ToBoolean(dataReader["NaSklade"])));




                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zbozi;
        }
        public void UlozZbozi(Zbz zbz)
        {
            if (zbz.Id == 0)
            {
                //není v databázi ->  budeme ho vytvářet
                using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("", sqlconnection))
                    {
                        sqlCommand.CommandText = "insert into Zbozi (Nazev, CenaBezDPH, NaSklade) values(@Nazev, @CenaBezDPH, @NaSklade)";
                        sqlCommand.Parameters.AddWithValue("Nazev", zbz.Nazev);
                        sqlCommand.Parameters.AddWithValue("CenaBezDPH", zbz.CenaBezDPH);
                        sqlCommand.Parameters.AddWithValue("NaSklade", zbz.NaSklade);
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlconnection.Close();
                    }
                }
            }
            else
            {
                //update
                using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("", sqlconnection))
                    {
                        sqlCommand.CommandText = $"update Zbozi set Nazev=@Nazev, CenaBezDPH=@CenaBezDPH, NaSklade=@NaSklade where IdZbozi={zbz.Id}";
                        sqlCommand.Parameters.AddWithValue("Nazev", zbz.Nazev);
                        sqlCommand.Parameters.AddWithValue("CenaBezDPH", zbz.CenaBezDPH);
                        sqlCommand.Parameters.AddWithValue("NaSklade", zbz.NaSklade);
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlconnection.Close();
                    }
                }
            }
        }
    }
}

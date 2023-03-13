using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System;
using System.Globalization;

namespace DI.Code
{
    class DataInitialiser
    {
        public static string GetConString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static readonly string _connectionString = GetConString();
        public static void DataStartup()
        {
            ClearDB(); 
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                string cmdTextHarti = "Insert into Harti (NumeHarta,FisierHarta) values (@NumeHarta,@FisierHarta)";
                string cmdTextMasurari = "Insert into Masurare (IdHarta,PozitieX,PozitieY,ValoareMasurare,DataMasurare) values (@IdHarta,@PozitieX,@PozitieY,@ValoareMasurare,@DataMasurare)";

                string filePathHarti = "OJTI_2022_C#_Resurse//harti.txt";
                string filePathMasurari = "OJTI_2022_C#_Resurse//masurari.txt";

                using (StreamReader reader = new StreamReader(filePathHarti))
                {
                    while(reader.Peek() >= 0)
                    {
                        var line = reader.ReadLine().Split('#');
                        using (SqlCommand cmd = new SqlCommand(cmdTextHarti, con))
                        {
                            cmd.Parameters.AddWithValue("NumeHarta", line[0]);
                            cmd.Parameters.AddWithValue("FisierHarta", line[1]);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    
                }

                using (StreamReader reader = new StreamReader(filePathMasurari))
                {
                    while (reader.Peek() >= 0)
                    {
                        var line = reader.ReadLine().Split('#');
                        int idHarta = 0;
                        using(SqlCommand cmd = new SqlCommand("Select IdHarta from Harti where NumeHarta = @NumeHarta", con))
                        {
                            cmd.Parameters.AddWithValue("NumeHarta", line[0]);

                            using(SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                rdr.Read();
                                idHarta = (int)rdr[0];
                            }
                        }

                        
                        
                        using (SqlCommand cmd = new SqlCommand(cmdTextMasurari, con))
                        {
                            cmd.Parameters.AddWithValue("IdHarta", idHarta);
                            cmd.Parameters.AddWithValue("PozitieX", line[1]);
                            cmd.Parameters.AddWithValue("PozitieY", line[2]);
                            cmd.Parameters.AddWithValue("ValoareMasurare", line[3]);
                            DateTime date = DateTime.ParseExact(line[4].Trim(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                            cmd.Parameters.AddWithValue("DataMasurare", date);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        private static void ClearDB()
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string cmdText = "Delete from Harti";
                EndQuery(con, cmdText);
                cmdText = "Delete from Masurare";
                EndQuery(con, cmdText);
                cmdText = "Delete from Utilizatori";
                EndQuery(con, cmdText);
            }
        }
        private static void EndQuery(SqlConnection con, string cmdText)
        {
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
using System.Data.SqlClient;
using DI.Code;

namespace DB.Code
{
    public class DataBinder
    {
        public static string BindData(string imageName)
        {
           string imagePath = "";
           using(SqlConnection con = new SqlConnection(DataInitialiser._connectionString))
            {
                con.Open();
                string cmdText = "Select FisierHarta from Harti where NumeHarta = @NumeHarta ";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("NumeHarta", imageName);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            imagePath = (string)reader["FisierHarta"];
                        }
                    }
                }
            }
            return imagePath;
        }
    }
}
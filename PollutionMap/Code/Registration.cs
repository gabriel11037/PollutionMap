using MDL.User;
using System.Data.SqlClient;
using DI.Code;
using System;
using System.Net.Mail;

namespace RG.Code
{
    class Registration
    {
        public static void RegisterUser(UserModel user)
        {
            using (SqlConnection con = new SqlConnection(DataInitialiser._connectionString))
            {
                con.Open();
                string cmdText = "Insert into Utilizatori (NumeUtilizator,Parola,EmailUtilizator,UltimaUtilizare) values (@NumeUtilizator,@Parola,@EmailUtilizator,@UltimaUtilizare)";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("NumeUtilizator", user.Nume);
                    cmd.Parameters.AddWithValue("Parola", user.Parola);
                    cmd.Parameters.AddWithValue("EmailUtilizator", user.Email);
                    cmd.Parameters.AddWithValue("UltimaUtilizare", user.UltimaUtilizare);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static UserModel CheckUser(string NumeUtilizator)
        {
            UserModel user = new UserModel();
            using (SqlConnection con = new SqlConnection(DataInitialiser._connectionString))
            {
                con.Open();
                string cmdText = "Select NumeUtilizator,Parola,EmailUtilizator from Utilizatori where NumeUtilizator = @NumeUtilizator";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("NumeUtilizator", NumeUtilizator);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserModel
                            {
                                Nume = (string)reader["NumeUtilizator"],
                                Parola = (string)reader["Parola"],
                                Email = (string)reader["EmailUtilizator"],
                                UltimaUtilizare = DateTime.Now
                            };
                        }
                    }
                }
            }
            return user;
        }

        public static bool ValidEmail(string email)
        {
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
    }
}
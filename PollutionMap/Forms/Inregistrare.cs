using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RG.Code;
using MDL.User;

namespace PollutionMap.Forms
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void AbortBTNCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }

        private void SaveBTNCreate_Click(object sender, EventArgs e)
        {
            if(numeTBCreate.Text != string.Empty && parolaTBCreate.Text != string.Empty && passCheckTBCreate.Text != string.Empty && emailTBCreate.Text != string.Empty)
            {
                if(numeTBCreate.Text.Length > 4 && parolaTBCreate.Text.Length > 6)
                {
                    if(parolaTBCreate.Text == passCheckTBCreate.Text)
                    {
                        if(Registration.ValidEmail(emailTBCreate.Text)== true)
                        {
                            UserModel user = new UserModel
                            {
                                Nume = numeTBCreate.Text,
                                Parola = parolaTBCreate.Text,
                                Email = emailTBCreate.Text,
                                UltimaUtilizare = DateTime.Now
                            };

                            try
                            {
                                Registration.RegisterUser(user);
                                user = Registration.CheckUser(numeTBCreate.Text);
                                if(user.Nume == numeTBCreate.Text)
                                {
                                    MessageBox.Show("Userul " + numeTBCreate.Text + " a fost adaugat cu succes!");
                                }

                                this.Close();
                                this.Visible = false;
                            }
                            catch(Exception exc)
                            {
                                MessageBox.Show("Eroare la inregistrare user: " + exc.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introdu un email valid!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introdu parola corecta!");
                    }
                }
                else
                {
                    MessageBox.Show("Numele trebuie sa aiba mai mult de 4 caractere, iar parola mai mult de 6!");
                }
            }
            else
            {
                MessageBox.Show("Completeaza toate campurile!");
            }
        }
    }
}

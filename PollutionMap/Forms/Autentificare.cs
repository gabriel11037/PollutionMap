using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DI.Code;
using PollutionMap.Forms;
using RG.Code;
using MDL.User;

namespace PollutionMap
{
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
            Load += new EventHandler(Autentificare_Load);
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {
            DataInitialiser.DataStartup();
        }

        private void LogareAuthBTN_Click(object sender, EventArgs e)
        {
            UserModel user = Registration.CheckUser(NumeAuthTB.Text);
            
            if(user.Parola  == ParolaAuthTB.Text)
            {
                Registration.AddDate();
                this.Close();
                this.Visible = false;
                var page = new Vizualizare()
                {
                    User = user
                };
                page.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("A aparut o eroare la autentificare.");
            }
        }

        private void ContNouAuthBTN_Click(object sender, EventArgs e)
        {
            var page = new Inregistrare();
            page.Show();
        }
    }
}

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
            var page = new Vizualizare();
            page.Show();
        }

        private void ContNouAuthBTN_Click(object sender, EventArgs e)
        {

        }
    }
}

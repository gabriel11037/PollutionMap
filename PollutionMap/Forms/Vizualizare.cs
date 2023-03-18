using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDL.User;
using DB.Code;

namespace PollutionMap.Forms
{
    public partial class Vizualizare : Form
    {
        
        public Vizualizare()
        {
            InitializeComponent();
        }
        public UserModel User { get; set; }
        private void Vizualizare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Harti1' table. You can move, or remove it, as needed.
            this.harti1TableAdapter.Fill(this.dataSet11.Harti1);
            // TODO: This line of code loads data into the 'dataSet1.Harti' table. You can move, or remove it, as needed.
            this.hartiTableAdapter.Fill(this.dataSet1.Harti);
            
        }

        string imagePath = "";
        string imageName = "";

        private void CBharti_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageName = CBharti.Text;
            imagePath = DataBinder.BindData(imageName);
            PBharti.Image = Image.FromFile(imagePath);
        }
    }
}

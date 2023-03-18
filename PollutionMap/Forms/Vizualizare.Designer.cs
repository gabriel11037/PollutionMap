
namespace PollutionMap.Forms
{
    partial class Vizualizare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vizualizare));
            this.vizualizareHarti = new System.Windows.Forms.TabControl();
            this.TABharti = new System.Windows.Forms.TabPage();
            this.BTNaplica = new System.Windows.Forms.Button();
            this.BTNreset = new System.Windows.Forms.Button();
            this.CBfiltru = new System.Windows.Forms.ComboBox();
            this.DTPcalendar = new System.Windows.Forms.DateTimePicker();
            this.CBharti = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PBharti = new System.Windows.Forms.PictureBox();
            this.TABtrasee = new System.Windows.Forms.TabPage();
            this.dataSet1 = new PollutionMap.DataSet1();
            this.hartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hartiTableAdapter = new PollutionMap.DataSet1TableAdapters.HartiTableAdapter();
            this.dataSet11 = new PollutionMap.DataSet1();
            this.harti1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.harti1TableAdapter = new PollutionMap.DataSet1TableAdapters.Harti1TableAdapter();
            this.vizualizareHarti.SuspendLayout();
            this.TABharti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBharti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harti1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vizualizareHarti
            // 
            this.vizualizareHarti.Controls.Add(this.TABharti);
            this.vizualizareHarti.Controls.Add(this.TABtrasee);
            this.vizualizareHarti.Location = new System.Drawing.Point(12, 12);
            this.vizualizareHarti.Name = "vizualizareHarti";
            this.vizualizareHarti.SelectedIndex = 0;
            this.vizualizareHarti.Size = new System.Drawing.Size(1083, 537);
            this.vizualizareHarti.TabIndex = 0;
            // 
            // TABharti
            // 
            this.TABharti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TABharti.BackgroundImage")));
            this.TABharti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TABharti.Controls.Add(this.BTNaplica);
            this.TABharti.Controls.Add(this.BTNreset);
            this.TABharti.Controls.Add(this.CBfiltru);
            this.TABharti.Controls.Add(this.DTPcalendar);
            this.TABharti.Controls.Add(this.CBharti);
            this.TABharti.Controls.Add(this.label4);
            this.TABharti.Controls.Add(this.label3);
            this.TABharti.Controls.Add(this.label2);
            this.TABharti.Controls.Add(this.label1);
            this.TABharti.Controls.Add(this.PBharti);
            this.TABharti.Location = new System.Drawing.Point(4, 29);
            this.TABharti.Name = "TABharti";
            this.TABharti.Padding = new System.Windows.Forms.Padding(3);
            this.TABharti.Size = new System.Drawing.Size(1075, 504);
            this.TABharti.TabIndex = 1;
            this.TABharti.Text = "Harti";
            this.TABharti.UseVisualStyleBackColor = true;
            // 
            // BTNaplica
            // 
            this.BTNaplica.Location = new System.Drawing.Point(30, 427);
            this.BTNaplica.Name = "BTNaplica";
            this.BTNaplica.Size = new System.Drawing.Size(193, 58);
            this.BTNaplica.TabIndex = 9;
            this.BTNaplica.Text = "Aplica Filtru";
            this.BTNaplica.UseVisualStyleBackColor = true;
            // 
            // BTNreset
            // 
            this.BTNreset.Location = new System.Drawing.Point(229, 427);
            this.BTNreset.Name = "BTNreset";
            this.BTNreset.Size = new System.Drawing.Size(197, 58);
            this.BTNreset.TabIndex = 8;
            this.BTNreset.Text = "Reseteaza Filtru";
            this.BTNreset.UseVisualStyleBackColor = true;
            // 
            // CBfiltru
            // 
            this.CBfiltru.FormattingEnabled = true;
            this.CBfiltru.Items.AddRange(new object[] {
            "Fara Filtru",
            "Valoare < 20",
            "20 <= Valoare <= 40",
            "Valoare > 40"});
            this.CBfiltru.Location = new System.Drawing.Point(26, 254);
            this.CBfiltru.Name = "CBfiltru";
            this.CBfiltru.Size = new System.Drawing.Size(216, 28);
            this.CBfiltru.TabIndex = 7;
            // 
            // DTPcalendar
            // 
            this.DTPcalendar.Location = new System.Drawing.Point(26, 174);
            this.DTPcalendar.Name = "DTPcalendar";
            this.DTPcalendar.Size = new System.Drawing.Size(300, 26);
            this.DTPcalendar.TabIndex = 6;
            // 
            // CBharti
            // 
            this.CBharti.DataSource = this.hartiBindingSource;
            this.CBharti.DisplayMember = "NumeHarta";
            this.CBharti.FormattingEnabled = true;
            this.CBharti.Location = new System.Drawing.Point(26, 105);
            this.CBharti.Name = "CBharti";
            this.CBharti.Size = new System.Drawing.Size(400, 28);
            this.CBharti.TabIndex = 5;
            this.CBharti.SelectedIndexChanged += new System.EventHandler(this.CBharti_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Filtru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilizator:";
            // 
            // PBharti
            // 
            this.PBharti.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBharti.InitialImage")));
            this.PBharti.Location = new System.Drawing.Point(451, 6);
            this.PBharti.Name = "PBharti";
            this.PBharti.Size = new System.Drawing.Size(618, 479);
            this.PBharti.TabIndex = 0;
            this.PBharti.TabStop = false;
            // 
            // TABtrasee
            // 
            this.TABtrasee.Location = new System.Drawing.Point(4, 29);
            this.TABtrasee.Name = "TABtrasee";
            this.TABtrasee.Padding = new System.Windows.Forms.Padding(3);
            this.TABtrasee.Size = new System.Drawing.Size(1075, 504);
            this.TABtrasee.TabIndex = 2;
            this.TABtrasee.Text = "Trasee";
            this.TABtrasee.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hartiBindingSource
            // 
            this.hartiBindingSource.DataMember = "Harti";
            this.hartiBindingSource.DataSource = this.dataSet1;
            // 
            // hartiTableAdapter
            // 
            this.hartiTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // harti1BindingSource
            // 
            this.harti1BindingSource.DataMember = "Harti1";
            this.harti1BindingSource.DataSource = this.dataSet11;
            // 
            // harti1TableAdapter
            // 
            this.harti1TableAdapter.ClearBeforeFill = true;
            // 
            // Vizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 551);
            this.Controls.Add(this.vizualizareHarti);
            this.Name = "Vizualizare";
            this.Text = "Vizualizare";
            this.Load += new System.EventHandler(this.Vizualizare_Load);
            this.vizualizareHarti.ResumeLayout(false);
            this.TABharti.ResumeLayout(false);
            this.TABharti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBharti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harti1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl vizualizareHarti;
        private System.Windows.Forms.TabPage TABharti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBharti;
        public System.Windows.Forms.ComboBox CBharti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CBfiltru;
        public System.Windows.Forms.DateTimePicker DTPcalendar;
        private System.Windows.Forms.TabPage TABtrasee;
        private System.Windows.Forms.Button BTNaplica;
        private System.Windows.Forms.Button BTNreset;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource hartiBindingSource;
        private DataSet1TableAdapters.HartiTableAdapter hartiTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource harti1BindingSource;
        private DataSet1TableAdapters.Harti1TableAdapter harti1TableAdapter;
    }
}
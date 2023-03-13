
namespace PollutionMap
{
    partial class Autentificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentificare));
            this.label1 = new System.Windows.Forms.Label();
            this.NumeAuthTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ParolaAuthTB = new System.Windows.Forms.TextBox();
            this.LogareAuthBTN = new System.Windows.Forms.Button();
            this.ContNouAuthBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // NumeAuthTB
            // 
            this.NumeAuthTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumeAuthTB.Location = new System.Drawing.Point(42, 107);
            this.NumeAuthTB.Name = "NumeAuthTB";
            this.NumeAuthTB.Size = new System.Drawing.Size(223, 26);
            this.NumeAuthTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // ParolaAuthTB
            // 
            this.ParolaAuthTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParolaAuthTB.Location = new System.Drawing.Point(42, 196);
            this.ParolaAuthTB.Name = "ParolaAuthTB";
            this.ParolaAuthTB.PasswordChar = '*';
            this.ParolaAuthTB.Size = new System.Drawing.Size(223, 26);
            this.ParolaAuthTB.TabIndex = 3;
            // 
            // LogareAuthBTN
            // 
            this.LogareAuthBTN.Location = new System.Drawing.Point(42, 324);
            this.LogareAuthBTN.Name = "LogareAuthBTN";
            this.LogareAuthBTN.Size = new System.Drawing.Size(110, 39);
            this.LogareAuthBTN.TabIndex = 4;
            this.LogareAuthBTN.Text = "Logare";
            this.LogareAuthBTN.UseVisualStyleBackColor = true;
            this.LogareAuthBTN.Click += new System.EventHandler(this.LogareAuthBTN_Click);
            // 
            // ContNouAuthBTN
            // 
            this.ContNouAuthBTN.Location = new System.Drawing.Point(159, 324);
            this.ContNouAuthBTN.Name = "ContNouAuthBTN";
            this.ContNouAuthBTN.Size = new System.Drawing.Size(106, 38);
            this.ContNouAuthBTN.TabIndex = 5;
            this.ContNouAuthBTN.Text = "Cont Nou";
            this.ContNouAuthBTN.UseVisualStyleBackColor = true;
            this.ContNouAuthBTN.Click += new System.EventHandler(this.ContNouAuthBTN_Click);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(640, 441);
            this.Controls.Add(this.ContNouAuthBTN);
            this.Controls.Add(this.LogareAuthBTN);
            this.Controls.Add(this.ParolaAuthTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeAuthTB);
            this.Controls.Add(this.label1);
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeAuthTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParolaAuthTB;
        private System.Windows.Forms.Button LogareAuthBTN;
        private System.Windows.Forms.Button ContNouAuthBTN;
    }
}


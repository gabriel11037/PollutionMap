
namespace PollutionMap.Forms
{
    partial class Inregistrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inregistrare));
            this.label1 = new System.Windows.Forms.Label();
            this.numeTBCreate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTBCreate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parolaTBCreate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passCheckTBCreate = new System.Windows.Forms.TextBox();
            this.SaveBTNCreate = new System.Windows.Forms.Button();
            this.AbortBTNCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume de utilizator:";
            // 
            // numeTBCreate
            // 
            this.numeTBCreate.Location = new System.Drawing.Point(84, 90);
            this.numeTBCreate.Name = "numeTBCreate";
            this.numeTBCreate.Size = new System.Drawing.Size(259, 26);
            this.numeTBCreate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // emailTBCreate
            // 
            this.emailTBCreate.Location = new System.Drawing.Point(84, 295);
            this.emailTBCreate.Name = "emailTBCreate";
            this.emailTBCreate.Size = new System.Drawing.Size(259, 26);
            this.emailTBCreate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola:";
            // 
            // parolaTBCreate
            // 
            this.parolaTBCreate.Location = new System.Drawing.Point(84, 156);
            this.parolaTBCreate.Name = "parolaTBCreate";
            this.parolaTBCreate.PasswordChar = '*';
            this.parolaTBCreate.Size = new System.Drawing.Size(259, 26);
            this.parolaTBCreate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Verificare Parola:";
            // 
            // passCheckTBCreate
            // 
            this.passCheckTBCreate.Location = new System.Drawing.Point(84, 226);
            this.passCheckTBCreate.Name = "passCheckTBCreate";
            this.passCheckTBCreate.PasswordChar = '*';
            this.passCheckTBCreate.Size = new System.Drawing.Size(259, 26);
            this.passCheckTBCreate.TabIndex = 7;
            // 
            // SaveBTNCreate
            // 
            this.SaveBTNCreate.BackColor = System.Drawing.Color.Azure;
            this.SaveBTNCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBTNCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTNCreate.Location = new System.Drawing.Point(453, 369);
            this.SaveBTNCreate.Name = "SaveBTNCreate";
            this.SaveBTNCreate.Size = new System.Drawing.Size(261, 53);
            this.SaveBTNCreate.TabIndex = 8;
            this.SaveBTNCreate.Text = "Salvare";
            this.SaveBTNCreate.UseVisualStyleBackColor = false;
            this.SaveBTNCreate.Click += new System.EventHandler(this.SaveBTNCreate_Click);
            // 
            // AbortBTNCreate
            // 
            this.AbortBTNCreate.BackColor = System.Drawing.Color.Azure;
            this.AbortBTNCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AbortBTNCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AbortBTNCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbortBTNCreate.Location = new System.Drawing.Point(75, 369);
            this.AbortBTNCreate.Name = "AbortBTNCreate";
            this.AbortBTNCreate.Size = new System.Drawing.Size(268, 53);
            this.AbortBTNCreate.TabIndex = 9;
            this.AbortBTNCreate.Text = "Renunta";
            this.AbortBTNCreate.UseVisualStyleBackColor = false;
            this.AbortBTNCreate.Click += new System.EventHandler(this.AbortBTNCreate_Click);
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.AbortBTNCreate);
            this.Controls.Add(this.SaveBTNCreate);
            this.Controls.Add(this.passCheckTBCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parolaTBCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTBCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeTBCreate);
            this.Controls.Add(this.label1);
            this.Name = "Inregistrare";
            this.Text = "Inregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeTBCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTBCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parolaTBCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passCheckTBCreate;
        private System.Windows.Forms.Button SaveBTNCreate;
        private System.Windows.Forms.Button AbortBTNCreate;
    }
}
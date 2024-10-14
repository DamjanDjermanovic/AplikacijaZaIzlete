namespace TVPAplikacijaZaIzlete.Forme
{
    partial class FormPrijava
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.White;
            this.btnPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.Salmon;
            this.btnPrijava.Location = new System.Drawing.Point(200, 0);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(200, 60);
            this.btnPrijava.TabIndex = 3;
            this.btnPrijava.Text = "PRIJAVA";
            this.btnPrijava.UseVisualStyleBackColor = false;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.Salmon;
            this.btnRegistracija.FlatAppearance.BorderSize = 0;
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.ForeColor = System.Drawing.Color.White;
            this.btnRegistracija.Location = new System.Drawing.Point(0, 0);
            this.btnRegistracija.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(200, 60);
            this.btnRegistracija.TabIndex = 2;
            this.btnRegistracija.Text = "REGISTRACIJA";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(8, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(8, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Korisnicko ime";
            // 
            // tbLozinka
            // 
            this.tbLozinka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLozinka.ForeColor = System.Drawing.Color.Black;
            this.tbLozinka.Location = new System.Drawing.Point(12, 329);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(380, 30);
            this.tbLozinka.TabIndex = 11;
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKorisnickoIme.ForeColor = System.Drawing.Color.Black;
            this.tbKorisnickoIme.Location = new System.Drawing.Point(12, 225);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(380, 30);
            this.tbKorisnickoIme.TabIndex = 10;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmin.ForeColor = System.Drawing.Color.Salmon;
            this.cbAdmin.Location = new System.Drawing.Point(109, 416);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(179, 26);
            this.cbAdmin.TabIndex = 15;
            this.cbAdmin.Text = "Pristupi kao admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.Salmon;
            this.btnPotvrdi.FlatAppearance.BorderSize = 0;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(100, 500);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(0);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(200, 60);
            this.btnPotvrdi.TabIndex = 16;
            this.btnPotvrdi.Text = "POTVRDI";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.btnRegistracija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}
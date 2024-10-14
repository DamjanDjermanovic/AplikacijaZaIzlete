namespace TVPAplikacijaZaIzlete.Forme
{
    partial class FormKorisnik
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
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.dgvRezervacijeDestinacije = new System.Windows.Forms.DataGridView();
            this.Rezervacije = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnOtkaziRezervaciju = new System.Windows.Forms.Button();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacijeDestinacije)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.ForeColor = System.Drawing.Color.Salmon;
            this.lblImePrezime.Location = new System.Drawing.Point(12, 9);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(345, 29);
            this.lblImePrezime.TabIndex = 9;
            this.lblImePrezime.Text = "Plejsholder za ime i prezime";
            // 
            // dgvRezervacijeDestinacije
            // 
            this.dgvRezervacijeDestinacije.AllowUserToAddRows = false;
            this.dgvRezervacijeDestinacije.AllowUserToDeleteRows = false;
            this.dgvRezervacijeDestinacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacijeDestinacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacijeDestinacije.Location = new System.Drawing.Point(17, 85);
            this.dgvRezervacijeDestinacije.Name = "dgvRezervacijeDestinacije";
            this.dgvRezervacijeDestinacije.ReadOnly = true;
            this.dgvRezervacijeDestinacije.RowHeadersWidth = 51;
            this.dgvRezervacijeDestinacije.RowTemplate.Height = 24;
            this.dgvRezervacijeDestinacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacijeDestinacije.Size = new System.Drawing.Size(1153, 207);
            this.dgvRezervacijeDestinacije.TabIndex = 10;
            // 
            // Rezervacije
            // 
            this.Rezervacije.AutoSize = true;
            this.Rezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rezervacije.ForeColor = System.Drawing.Color.Salmon;
            this.Rezervacije.Location = new System.Drawing.Point(12, 53);
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.Size = new System.Drawing.Size(150, 29);
            this.Rezervacije.TabIndex = 11;
            this.Rezervacije.Text = "Rezervacije";
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Salmon;
            this.btnIzadji.FlatAppearance.BorderSize = 0;
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.White;
            this.btnIzadji.Location = new System.Drawing.Point(1125, 9);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(45, 45);
            this.btnIzadji.TabIndex = 26;
            this.btnIzadji.Text = "X";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnOtkaziRezervaciju
            // 
            this.btnOtkaziRezervaciju.BackColor = System.Drawing.Color.Salmon;
            this.btnOtkaziRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnOtkaziRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkaziRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkaziRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnOtkaziRezervaciju.Location = new System.Drawing.Point(610, 307);
            this.btnOtkaziRezervaciju.Margin = new System.Windows.Forms.Padding(0);
            this.btnOtkaziRezervaciju.Name = "btnOtkaziRezervaciju";
            this.btnOtkaziRezervaciju.Size = new System.Drawing.Size(560, 60);
            this.btnOtkaziRezervaciju.TabIndex = 27;
            this.btnOtkaziRezervaciju.Text = "OTKAZI SELEKTOVANU DESTINACIJU";
            this.btnOtkaziRezervaciju.UseVisualStyleBackColor = false;
            this.btnOtkaziRezervaciju.Click += new System.EventHandler(this.btnOtkaziRezervaciju_Click);
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.Salmon;
            this.btnDodajRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(17, 307);
            this.btnDodajRezervaciju.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(560, 60);
            this.btnDodajRezervaciju.TabIndex = 28;
            this.btnDodajRezervaciju.Text = "DODAJ NOVU REZERVACIJU";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(316, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(560, 60);
            this.button1.TabIndex = 29;
            this.button1.Text = "OTVORI ISTORIJU REZERVACIJA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.btnOtkaziRezervaciju);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.Rezervacije);
            this.Controls.Add(this.dgvRezervacijeDestinacije);
            this.Controls.Add(this.lblImePrezime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnicki meni";
            this.Load += new System.EventHandler(this.FormKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacijeDestinacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.DataGridView dgvRezervacijeDestinacije;
        private System.Windows.Forms.Label Rezervacije;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnOtkaziRezervaciju;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Button button1;
    }
}
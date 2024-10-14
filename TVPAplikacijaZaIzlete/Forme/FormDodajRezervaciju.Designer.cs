namespace TVPAplikacijaZaIzlete.Forme
{
    partial class FormDodajRezervaciju
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
            this.label10 = new System.Windows.Forms.Label();
            this.tbBrojRezervisanihMesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.dgvDestinacije = new System.Windows.Forms.DataGridView();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Salmon;
            this.label10.Location = new System.Drawing.Point(66, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "Broj rezervisanih mesta";
            // 
            // tbBrojRezervisanihMesta
            // 
            this.tbBrojRezervisanihMesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBrojRezervisanihMesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojRezervisanihMesta.ForeColor = System.Drawing.Color.Black;
            this.tbBrojRezervisanihMesta.Location = new System.Drawing.Point(70, 542);
            this.tbBrojRezervisanihMesta.Name = "tbBrojRezervisanihMesta";
            this.tbBrojRezervisanihMesta.Size = new System.Drawing.Size(376, 30);
            this.tbBrojRezervisanihMesta.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "Dodaj rezervaciju";
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.Salmon;
            this.btnDodajRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(568, 517);
            this.btnDodajRezervaciju.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(329, 60);
            this.btnDodajRezervaciju.TabIndex = 40;
            this.btnDodajRezervaciju.Text = "POTVRDI";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 58);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(954, 197);
            this.dgvKorisnici.TabIndex = 41;
            // 
            // dgvDestinacije
            // 
            this.dgvDestinacije.AllowUserToAddRows = false;
            this.dgvDestinacije.AllowUserToDeleteRows = false;
            this.dgvDestinacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestinacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinacije.Location = new System.Drawing.Point(12, 293);
            this.dgvDestinacije.Name = "dgvDestinacije";
            this.dgvDestinacije.ReadOnly = true;
            this.dgvDestinacije.RowHeadersWidth = 51;
            this.dgvDestinacije.RowTemplate.Height = 24;
            this.dgvDestinacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinacije.Size = new System.Drawing.Size(954, 197);
            this.dgvDestinacije.TabIndex = 41;
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Salmon;
            this.btnIzadji.FlatAppearance.BorderSize = 0;
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.White;
            this.btnIzadji.Location = new System.Drawing.Point(921, 9);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(45, 45);
            this.btnIzadji.TabIndex = 42;
            this.btnIzadji.Text = "X";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // FormDodajRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 600);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvDestinacije);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbBrojRezervisanihMesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDodajRezervaciju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDodajRezervaciju";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBrojRezervisanihMesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.DataGridView dgvDestinacije;
        private System.Windows.Forms.Button btnIzadji;
    }
}
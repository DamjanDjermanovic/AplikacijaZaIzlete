namespace TVPAplikacijaZaIzlete.Forme
{
    partial class FormAdmin
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.dgvDestinacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnIzbrisiKorisnika = new System.Windows.Forms.Button();
            this.btnIzbrisiDestinaciju = new System.Windows.Forms.Button();
            this.btnDodajDestinaciju = new System.Windows.Forms.Button();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.btnIzbrisiRezervaciju = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToResizeColumns = false;
            this.dgvKorisnici.AllowUserToResizeRows = false;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.BackgroundColor = System.Drawing.Color.White;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(370, 12);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(800, 270);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellEndEdit);
            // 
            // dgvDestinacije
            // 
            this.dgvDestinacije.AllowUserToResizeColumns = false;
            this.dgvDestinacije.AllowUserToResizeRows = false;
            this.dgvDestinacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestinacije.BackgroundColor = System.Drawing.Color.White;
            this.dgvDestinacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinacije.Location = new System.Drawing.Point(370, 303);
            this.dgvDestinacije.Name = "dgvDestinacije";
            this.dgvDestinacije.RowHeadersWidth = 51;
            this.dgvDestinacije.RowTemplate.Height = 24;
            this.dgvDestinacije.Size = new System.Drawing.Size(800, 270);
            this.dgvDestinacije.TabIndex = 1;
            this.dgvDestinacije.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinacije_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Upravljanje korisnicima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(12, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Upravljanje destinacijama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(12, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Upravljanje rezervacijama";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToResizeColumns = false;
            this.dgvRezervacije.AllowUserToResizeRows = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacije.BackgroundColor = System.Drawing.Color.White;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(370, 596);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.Size = new System.Drawing.Size(800, 270);
            this.dgvRezervacije.TabIndex = 2;
            this.dgvRezervacije.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellEndEdit);
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.BackColor = System.Drawing.Color.Salmon;
            this.btnDodajKorisnika.FlatAppearance.BorderSize = 0;
            this.btnDodajKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKorisnika.ForeColor = System.Drawing.Color.White;
            this.btnDodajKorisnika.Location = new System.Drawing.Point(17, 56);
            this.btnDodajKorisnika.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(329, 60);
            this.btnDodajKorisnika.TabIndex = 19;
            this.btnDodajKorisnika.Text = "DODAJ KORISNIKA";
            this.btnDodajKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // btnIzbrisiKorisnika
            // 
            this.btnIzbrisiKorisnika.BackColor = System.Drawing.Color.Salmon;
            this.btnIzbrisiKorisnika.FlatAppearance.BorderSize = 0;
            this.btnIzbrisiKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiKorisnika.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiKorisnika.Location = new System.Drawing.Point(17, 167);
            this.btnIzbrisiKorisnika.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzbrisiKorisnika.Name = "btnIzbrisiKorisnika";
            this.btnIzbrisiKorisnika.Size = new System.Drawing.Size(329, 60);
            this.btnIzbrisiKorisnika.TabIndex = 20;
            this.btnIzbrisiKorisnika.Text = "IZBRISI SELEKTOVANOG KORISNIKA";
            this.btnIzbrisiKorisnika.UseVisualStyleBackColor = false;
            this.btnIzbrisiKorisnika.Click += new System.EventHandler(this.btnIzbrisiKorisnika_Click);
            // 
            // btnIzbrisiDestinaciju
            // 
            this.btnIzbrisiDestinaciju.BackColor = System.Drawing.Color.Salmon;
            this.btnIzbrisiDestinaciju.FlatAppearance.BorderSize = 0;
            this.btnIzbrisiDestinaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiDestinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiDestinaciju.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiDestinaciju.Location = new System.Drawing.Point(17, 462);
            this.btnIzbrisiDestinaciju.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzbrisiDestinaciju.Name = "btnIzbrisiDestinaciju";
            this.btnIzbrisiDestinaciju.Size = new System.Drawing.Size(329, 60);
            this.btnIzbrisiDestinaciju.TabIndex = 24;
            this.btnIzbrisiDestinaciju.Text = "IZBRISI SELEKTOVANU DESTINACIJU";
            this.btnIzbrisiDestinaciju.UseVisualStyleBackColor = false;
            this.btnIzbrisiDestinaciju.Click += new System.EventHandler(this.btnIzbrisiDestinaciju_Click);
            // 
            // btnDodajDestinaciju
            // 
            this.btnDodajDestinaciju.BackColor = System.Drawing.Color.Salmon;
            this.btnDodajDestinaciju.FlatAppearance.BorderSize = 0;
            this.btnDodajDestinaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajDestinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDestinaciju.ForeColor = System.Drawing.Color.White;
            this.btnDodajDestinaciju.Location = new System.Drawing.Point(17, 351);
            this.btnDodajDestinaciju.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajDestinaciju.Name = "btnDodajDestinaciju";
            this.btnDodajDestinaciju.Size = new System.Drawing.Size(329, 60);
            this.btnDodajDestinaciju.TabIndex = 23;
            this.btnDodajDestinaciju.Text = "DODAJ DESTINACIJU";
            this.btnDodajDestinaciju.UseVisualStyleBackColor = false;
            this.btnDodajDestinaciju.Click += new System.EventHandler(this.btnDodajDestinaciju_Click);
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.Salmon;
            this.btnDodajRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(17, 651);
            this.btnDodajRezervaciju.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(329, 60);
            this.btnDodajRezervaciju.TabIndex = 23;
            this.btnDodajRezervaciju.Text = "DODAJ REZERVACIJU";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // btnIzbrisiRezervaciju
            // 
            this.btnIzbrisiRezervaciju.BackColor = System.Drawing.Color.Salmon;
            this.btnIzbrisiRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnIzbrisiRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiRezervaciju.Location = new System.Drawing.Point(17, 762);
            this.btnIzbrisiRezervaciju.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzbrisiRezervaciju.Name = "btnIzbrisiRezervaciju";
            this.btnIzbrisiRezervaciju.Size = new System.Drawing.Size(329, 60);
            this.btnIzbrisiRezervaciju.TabIndex = 24;
            this.btnIzbrisiRezervaciju.Text = "IZBRISI SELEKTOVANU REZERVACIJU";
            this.btnIzbrisiRezervaciju.UseVisualStyleBackColor = false;
            this.btnIzbrisiRezervaciju.Click += new System.EventHandler(this.btnIzbrisiRezervaciju_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Salmon;
            this.btnIzadji.FlatAppearance.BorderSize = 0;
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.White;
            this.btnIzadji.Location = new System.Drawing.Point(1184, 12);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(45, 45);
            this.btnIzadji.TabIndex = 25;
            this.btnIzadji.Text = "X";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(1232, 883);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnIzbrisiRezervaciju);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.btnIzbrisiDestinaciju);
            this.Controls.Add(this.btnDodajDestinaciju);
            this.Controls.Add(this.btnIzbrisiKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.dgvDestinacije);
            this.Controls.Add(this.dgvKorisnici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.DataGridView dgvDestinacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnIzbrisiKorisnika;
        private System.Windows.Forms.Button btnIzbrisiDestinaciju;
        private System.Windows.Forms.Button btnDodajDestinaciju;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Button btnIzbrisiRezervaciju;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnIzadji;
    }
}
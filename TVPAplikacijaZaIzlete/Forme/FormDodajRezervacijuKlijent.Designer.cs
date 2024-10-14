namespace TVPAplikacijaZaIzlete.Forme
{
    partial class FormDodajRezervacijuKlijent
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
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dgvDestinacije = new System.Windows.Forms.DataGridView();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBrojRezervisanihMesta = new System.Windows.Forms.TextBox();
            this.tbFilterMesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterMesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Salmon;
            this.btnIzadji.FlatAppearance.BorderSize = 0;
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.White;
            this.btnIzadji.Location = new System.Drawing.Point(921, 7);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(45, 45);
            this.btnIzadji.TabIndex = 49;
            this.btnIzadji.Text = "X";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dgvDestinacije
            // 
            this.dgvDestinacije.AllowUserToAddRows = false;
            this.dgvDestinacije.AllowUserToDeleteRows = false;
            this.dgvDestinacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestinacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinacije.Location = new System.Drawing.Point(12, 56);
            this.dgvDestinacije.Name = "dgvDestinacije";
            this.dgvDestinacije.ReadOnly = true;
            this.dgvDestinacije.RowHeadersWidth = 51;
            this.dgvDestinacije.RowTemplate.Height = 24;
            this.dgvDestinacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinacije.Size = new System.Drawing.Size(954, 197);
            this.dgvDestinacije.TabIndex = 48;
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.Salmon;
            this.btnDodajRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(16, 351);
            this.btnDodajRezervaciju.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(376, 60);
            this.btnDodajRezervaciju.TabIndex = 46;
            this.btnDodajRezervaciju.Text = "POTVRDI";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 32);
            this.label3.TabIndex = 45;
            this.label3.Text = "Dodaj rezervaciju";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Salmon;
            this.label10.Location = new System.Drawing.Point(12, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 22);
            this.label10.TabIndex = 44;
            this.label10.Text = "Broj rezervisanih mesta";
            // 
            // tbBrojRezervisanihMesta
            // 
            this.tbBrojRezervisanihMesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBrojRezervisanihMesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrojRezervisanihMesta.ForeColor = System.Drawing.Color.Black;
            this.tbBrojRezervisanihMesta.Location = new System.Drawing.Point(16, 294);
            this.tbBrojRezervisanihMesta.Name = "tbBrojRezervisanihMesta";
            this.tbBrojRezervisanihMesta.Size = new System.Drawing.Size(376, 30);
            this.tbBrojRezervisanihMesta.TabIndex = 43;
            // 
            // tbFilterMesto
            // 
            this.tbFilterMesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilterMesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterMesto.ForeColor = System.Drawing.Color.Black;
            this.tbFilterMesto.Location = new System.Drawing.Point(590, 294);
            this.tbFilterMesto.Name = "tbFilterMesto";
            this.tbFilterMesto.Size = new System.Drawing.Size(376, 30);
            this.tbFilterMesto.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(586, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Filtriraj po mestu";
            // 
            // btnFilterMesto
            // 
            this.btnFilterMesto.BackColor = System.Drawing.Color.Salmon;
            this.btnFilterMesto.FlatAppearance.BorderSize = 0;
            this.btnFilterMesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterMesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterMesto.ForeColor = System.Drawing.Color.White;
            this.btnFilterMesto.Location = new System.Drawing.Point(590, 351);
            this.btnFilterMesto.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilterMesto.Name = "btnFilterMesto";
            this.btnFilterMesto.Size = new System.Drawing.Size(376, 60);
            this.btnFilterMesto.TabIndex = 46;
            this.btnFilterMesto.Text = "FILTRIRAJ";
            this.btnFilterMesto.UseVisualStyleBackColor = false;
            this.btnFilterMesto.Click += new System.EventHandler(this.btnFilterMesto_Click);
            // 
            // FormDodajRezervacijuKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 437);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvDestinacije);
            this.Controls.Add(this.btnFilterMesto);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbFilterMesto);
            this.Controls.Add(this.tbBrojRezervisanihMesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDodajRezervacijuKlijent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDodajRezervacijuKlijent";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataGridView dgvDestinacije;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBrojRezervisanihMesta;
        private System.Windows.Forms.TextBox tbFilterMesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterMesto;
    }
}
namespace TVPAplikacijaZaIzlete.Forme
{
    partial class FormIstorijaRezervacija
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
            this.dgvIstorijaRezervacija = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dtpPocetniDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpKrajnjiDatum = new System.Windows.Forms.DateTimePicker();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstorijaRezervacija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIstorijaRezervacija
            // 
            this.dgvIstorijaRezervacija.AllowUserToAddRows = false;
            this.dgvIstorijaRezervacija.AllowUserToDeleteRows = false;
            this.dgvIstorijaRezervacija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIstorijaRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIstorijaRezervacija.Location = new System.Drawing.Point(18, 57);
            this.dgvIstorijaRezervacija.Name = "dgvIstorijaRezervacija";
            this.dgvIstorijaRezervacija.ReadOnly = true;
            this.dgvIstorijaRezervacija.RowHeadersWidth = 51;
            this.dgvIstorijaRezervacija.RowTemplate.Height = 24;
            this.dgvIstorijaRezervacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIstorijaRezervacija.Size = new System.Drawing.Size(904, 257);
            this.dgvIstorijaRezervacija.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Istorija rezervacija";
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Salmon;
            this.btnIzadji.FlatAppearance.BorderSize = 0;
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.White;
            this.btnIzadji.Location = new System.Drawing.Point(877, 5);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(45, 45);
            this.btnIzadji.TabIndex = 47;
            this.btnIzadji.Text = "X";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dtpPocetniDatum
            // 
            this.dtpPocetniDatum.Location = new System.Drawing.Point(433, 384);
            this.dtpPocetniDatum.Name = "dtpPocetniDatum";
            this.dtpPocetniDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpPocetniDatum.TabIndex = 48;
            // 
            // dtpKrajnjiDatum
            // 
            this.dtpKrajnjiDatum.Location = new System.Drawing.Point(703, 384);
            this.dtpKrajnjiDatum.Name = "dtpKrajnjiDatum";
            this.dtpKrajnjiDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpKrajnjiDatum.TabIndex = 49;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Salmon;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(18, 346);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(0);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(376, 60);
            this.btnPretrazi.TabIndex = 50;
            this.btnPretrazi.Text = "FILTRIRAJ PO DATUMU";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(706, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "Krajnji datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(429, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 52;
            this.label2.Text = "Pocetni datum";
            // 
            // FormIstorijaRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dtpKrajnjiDatum);
            this.Controls.Add(this.dtpPocetniDatum);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvIstorijaRezervacija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIstorijaRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIstorijaRezervacija";
            this.Load += new System.EventHandler(this.FormIstorijaRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstorijaRezervacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIstorijaRezervacija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DateTimePicker dtpPocetniDatum;
        private System.Windows.Forms.DateTimePicker dtpKrajnjiDatum;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
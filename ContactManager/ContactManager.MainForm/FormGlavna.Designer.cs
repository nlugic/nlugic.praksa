namespace ContactManager.MainForm
{
    partial class FormGlavna
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
            this.dgvKontakti = new System.Windows.Forms.DataGridView();
            this.gbKontroleDodaj = new System.Windows.Forms.GroupBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.cbTipKontakta = new System.Windows.Forms.ComboBox();
            this.lblTipKontakta = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.btnDodajKontakt = new System.Windows.Forms.Button();
            this.gbPrikazIIzmena = new System.Windows.Forms.GroupBox();
            this.lblTipKontaktaInfo = new System.Windows.Forms.Label();
            this.lblImeInfo = new System.Windows.Forms.Label();
            this.lblPrezimeInfo = new System.Windows.Forms.Label();
            this.lblAdresaInfo = new System.Windows.Forms.Label();
            this.lblKontaktInfo = new System.Windows.Forms.Label();
            this.btnIzmeniKontakt = new System.Windows.Forms.Button();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.tbBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblDodatoInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tbAdresaInfo = new System.Windows.Forms.TextBox();
            this.tbPrezimeInfo = new System.Windows.Forms.TextBox();
            this.tbImeInfo = new System.Windows.Forms.TextBox();
            this.tbKontaktInfo = new System.Windows.Forms.TextBox();
            this.tbDatumInfo = new System.Windows.Forms.TextBox();
            this.cbTipKontaktaInfo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontakti)).BeginInit();
            this.gbKontroleDodaj.SuspendLayout();
            this.gbPrikazIIzmena.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKontakti
            // 
            this.dgvKontakti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKontakti.Location = new System.Drawing.Point(12, 17);
            this.dgvKontakti.Name = "dgvKontakti";
            this.dgvKontakti.Size = new System.Drawing.Size(557, 534);
            this.dgvKontakti.TabIndex = 0;
            // 
            // gbKontroleDodaj
            // 
            this.gbKontroleDodaj.Controls.Add(this.tbBrojTelefona);
            this.gbKontroleDodaj.Controls.Add(this.lblBrojTelefona);
            this.gbKontroleDodaj.Controls.Add(this.btnDodajKontakt);
            this.gbKontroleDodaj.Controls.Add(this.lblAdresa);
            this.gbKontroleDodaj.Controls.Add(this.lblPrezime);
            this.gbKontroleDodaj.Controls.Add(this.lblIme);
            this.gbKontroleDodaj.Controls.Add(this.lblTipKontakta);
            this.gbKontroleDodaj.Controls.Add(this.cbTipKontakta);
            this.gbKontroleDodaj.Controls.Add(this.tbAdresa);
            this.gbKontroleDodaj.Controls.Add(this.tbPrezime);
            this.gbKontroleDodaj.Controls.Add(this.tbIme);
            this.gbKontroleDodaj.Location = new System.Drawing.Point(581, 17);
            this.gbKontroleDodaj.Name = "gbKontroleDodaj";
            this.gbKontroleDodaj.Size = new System.Drawing.Size(292, 232);
            this.gbKontroleDodaj.TabIndex = 1;
            this.gbKontroleDodaj.TabStop = false;
            this.gbKontroleDodaj.Text = "Unos novog kontakta";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(110, 61);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(155, 20);
            this.tbIme.TabIndex = 0;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(110, 92);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(155, 20);
            this.tbPrezime.TabIndex = 1;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(110, 124);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(155, 20);
            this.tbAdresa.TabIndex = 2;
            // 
            // cbTipKontakta
            // 
            this.cbTipKontakta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipKontakta.FormattingEnabled = true;
            this.cbTipKontakta.Location = new System.Drawing.Point(110, 32);
            this.cbTipKontakta.Name = "cbTipKontakta";
            this.cbTipKontakta.Size = new System.Drawing.Size(155, 21);
            this.cbTipKontakta.TabIndex = 3;
            // 
            // lblTipKontakta
            // 
            this.lblTipKontakta.AutoSize = true;
            this.lblTipKontakta.Location = new System.Drawing.Point(19, 35);
            this.lblTipKontakta.Name = "lblTipKontakta";
            this.lblTipKontakta.Size = new System.Drawing.Size(70, 13);
            this.lblTipKontakta.TabIndex = 4;
            this.lblTipKontakta.Text = "Tip kontakta:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(62, 64);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(42, 95);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 6;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(46, 127);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 7;
            this.lblAdresa.Text = "Adresa:";
            // 
            // btnDodajKontakt
            // 
            this.btnDodajKontakt.Location = new System.Drawing.Point(72, 183);
            this.btnDodajKontakt.Name = "btnDodajKontakt";
            this.btnDodajKontakt.Size = new System.Drawing.Size(130, 35);
            this.btnDodajKontakt.TabIndex = 8;
            this.btnDodajKontakt.Text = "Dodaj Kontakt";
            this.btnDodajKontakt.UseVisualStyleBackColor = true;
            this.btnDodajKontakt.Click += new System.EventHandler(this.btnDodajKontakt_Click);
            // 
            // gbPrikazIIzmena
            // 
            this.gbPrikazIIzmena.Controls.Add(this.cbTipKontaktaInfo);
            this.gbPrikazIIzmena.Controls.Add(this.tbDatumInfo);
            this.gbPrikazIIzmena.Controls.Add(this.tbKontaktInfo);
            this.gbPrikazIIzmena.Controls.Add(this.tbImeInfo);
            this.gbPrikazIIzmena.Controls.Add(this.tbPrezimeInfo);
            this.gbPrikazIIzmena.Controls.Add(this.tbAdresaInfo);
            this.gbPrikazIIzmena.Controls.Add(this.lblDodatoInfo);
            this.gbPrikazIIzmena.Controls.Add(this.btnIzmeniKontakt);
            this.gbPrikazIIzmena.Controls.Add(this.lblKontaktInfo);
            this.gbPrikazIIzmena.Controls.Add(this.lblAdresaInfo);
            this.gbPrikazIIzmena.Controls.Add(this.lblPrezimeInfo);
            this.gbPrikazIIzmena.Controls.Add(this.lblImeInfo);
            this.gbPrikazIIzmena.Controls.Add(this.lblTipKontaktaInfo);
            this.gbPrikazIIzmena.Location = new System.Drawing.Point(581, 255);
            this.gbPrikazIIzmena.Name = "gbPrikazIIzmena";
            this.gbPrikazIIzmena.Size = new System.Drawing.Size(291, 254);
            this.gbPrikazIIzmena.TabIndex = 2;
            this.gbPrikazIIzmena.TabStop = false;
            this.gbPrikazIIzmena.Text = "Izabrani Kontakt";
            // 
            // lblTipKontaktaInfo
            // 
            this.lblTipKontaktaInfo.AutoSize = true;
            this.lblTipKontaktaInfo.Location = new System.Drawing.Point(18, 31);
            this.lblTipKontaktaInfo.Name = "lblTipKontaktaInfo";
            this.lblTipKontaktaInfo.Size = new System.Drawing.Size(71, 13);
            this.lblTipKontaktaInfo.TabIndex = 0;
            this.lblTipKontaktaInfo.Text = "Tip Kontakta:";
            // 
            // lblImeInfo
            // 
            this.lblImeInfo.AutoSize = true;
            this.lblImeInfo.Location = new System.Drawing.Point(62, 58);
            this.lblImeInfo.Name = "lblImeInfo";
            this.lblImeInfo.Size = new System.Drawing.Size(27, 13);
            this.lblImeInfo.TabIndex = 1;
            this.lblImeInfo.Text = "Ime:";
            // 
            // lblPrezimeInfo
            // 
            this.lblPrezimeInfo.AutoSize = true;
            this.lblPrezimeInfo.Location = new System.Drawing.Point(42, 82);
            this.lblPrezimeInfo.Name = "lblPrezimeInfo";
            this.lblPrezimeInfo.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeInfo.TabIndex = 2;
            this.lblPrezimeInfo.Text = "Prezime:";
            // 
            // lblAdresaInfo
            // 
            this.lblAdresaInfo.AutoSize = true;
            this.lblAdresaInfo.Location = new System.Drawing.Point(46, 111);
            this.lblAdresaInfo.Name = "lblAdresaInfo";
            this.lblAdresaInfo.Size = new System.Drawing.Size(43, 13);
            this.lblAdresaInfo.TabIndex = 3;
            this.lblAdresaInfo.Text = "Adresa:";
            // 
            // lblKontaktInfo
            // 
            this.lblKontaktInfo.AutoSize = true;
            this.lblKontaktInfo.Location = new System.Drawing.Point(7, 140);
            this.lblKontaktInfo.Name = "lblKontaktInfo";
            this.lblKontaktInfo.Size = new System.Drawing.Size(82, 13);
            this.lblKontaktInfo.TabIndex = 4;
            this.lblKontaktInfo.Text = "Kontakt telefon:";
            // 
            // btnIzmeniKontakt
            // 
            this.btnIzmeniKontakt.Enabled = false;
            this.btnIzmeniKontakt.Location = new System.Drawing.Point(72, 203);
            this.btnIzmeniKontakt.Name = "btnIzmeniKontakt";
            this.btnIzmeniKontakt.Size = new System.Drawing.Size(130, 39);
            this.btnIzmeniKontakt.TabIndex = 5;
            this.btnIzmeniKontakt.Text = "Izmeni Kontakt";
            this.btnIzmeniKontakt.UseVisualStyleBackColor = true;
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(7, 160);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(82, 13);
            this.lblBrojTelefona.TabIndex = 9;
            this.lblBrojTelefona.Text = "Kontakt telefon:";
            // 
            // tbBrojTelefona
            // 
            this.tbBrojTelefona.Location = new System.Drawing.Point(110, 157);
            this.tbBrojTelefona.Name = "tbBrojTelefona";
            this.tbBrojTelefona.Size = new System.Drawing.Size(155, 20);
            this.tbBrojTelefona.TabIndex = 10;
            // 
            // lblDodatoInfo
            // 
            this.lblDodatoInfo.AutoSize = true;
            this.lblDodatoInfo.Location = new System.Drawing.Point(7, 171);
            this.lblDodatoInfo.Name = "lblDodatoInfo";
            this.lblDodatoInfo.Size = new System.Drawing.Size(94, 13);
            this.lblDodatoInfo.TabIndex = 6;
            this.lblDodatoInfo.Text = "Datum dodavanja:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 26);
            this.panel1.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(581, 515);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(144, 36);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Importuj iz fajla...";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(731, 515);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(141, 36);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Eksportuj u fajl...";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // tbAdresaInfo
            // 
            this.tbAdresaInfo.Location = new System.Drawing.Point(122, 108);
            this.tbAdresaInfo.Name = "tbAdresaInfo";
            this.tbAdresaInfo.Size = new System.Drawing.Size(149, 20);
            this.tbAdresaInfo.TabIndex = 8;
            // 
            // tbPrezimeInfo
            // 
            this.tbPrezimeInfo.Location = new System.Drawing.Point(122, 79);
            this.tbPrezimeInfo.Name = "tbPrezimeInfo";
            this.tbPrezimeInfo.Size = new System.Drawing.Size(149, 20);
            this.tbPrezimeInfo.TabIndex = 9;
            // 
            // tbImeInfo
            // 
            this.tbImeInfo.Location = new System.Drawing.Point(122, 55);
            this.tbImeInfo.Name = "tbImeInfo";
            this.tbImeInfo.Size = new System.Drawing.Size(149, 20);
            this.tbImeInfo.TabIndex = 10;
            // 
            // tbKontaktInfo
            // 
            this.tbKontaktInfo.Location = new System.Drawing.Point(122, 137);
            this.tbKontaktInfo.Name = "tbKontaktInfo";
            this.tbKontaktInfo.Size = new System.Drawing.Size(149, 20);
            this.tbKontaktInfo.TabIndex = 11;
            // 
            // tbDatumInfo
            // 
            this.tbDatumInfo.Enabled = false;
            this.tbDatumInfo.Location = new System.Drawing.Point(122, 168);
            this.tbDatumInfo.Name = "tbDatumInfo";
            this.tbDatumInfo.Size = new System.Drawing.Size(149, 20);
            this.tbDatumInfo.TabIndex = 12;
            // 
            // cbTipKontaktaInfo
            // 
            this.cbTipKontaktaInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipKontaktaInfo.FormattingEnabled = true;
            this.cbTipKontaktaInfo.Location = new System.Drawing.Point(122, 28);
            this.cbTipKontaktaInfo.Name = "cbTipKontaktaInfo";
            this.cbTipKontaktaInfo.Size = new System.Drawing.Size(149, 21);
            this.cbTipKontaktaInfo.TabIndex = 13;
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 588);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbPrikazIIzmena);
            this.Controls.Add(this.gbKontroleDodaj);
            this.Controls.Add(this.dgvKontakti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGlavna";
            this.Text = "Contact Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontakti)).EndInit();
            this.gbKontroleDodaj.ResumeLayout(false);
            this.gbKontroleDodaj.PerformLayout();
            this.gbPrikazIIzmena.ResumeLayout(false);
            this.gbPrikazIIzmena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKontakti;
        private System.Windows.Forms.GroupBox gbKontroleDodaj;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblTipKontakta;
        private System.Windows.Forms.ComboBox cbTipKontakta;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnDodajKontakt;
        private System.Windows.Forms.TextBox tbBrojTelefona;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.GroupBox gbPrikazIIzmena;
        private System.Windows.Forms.Label lblDodatoInfo;
        private System.Windows.Forms.Button btnIzmeniKontakt;
        private System.Windows.Forms.Label lblKontaktInfo;
        private System.Windows.Forms.Label lblAdresaInfo;
        private System.Windows.Forms.Label lblPrezimeInfo;
        private System.Windows.Forms.Label lblImeInfo;
        private System.Windows.Forms.Label lblTipKontaktaInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTipKontaktaInfo;
        private System.Windows.Forms.TextBox tbDatumInfo;
        private System.Windows.Forms.TextBox tbKontaktInfo;
        private System.Windows.Forms.TextBox tbImeInfo;
        private System.Windows.Forms.TextBox tbPrezimeInfo;
        private System.Windows.Forms.TextBox tbAdresaInfo;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
    }
}


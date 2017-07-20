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
            this.components = new System.ComponentModel.Container();
            this.dgvKontakti = new System.Windows.Forms.DataGridView();
            this.gbKontroleDodaj = new System.Windows.Forms.GroupBox();
            this.tbBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.btnDodajKontakt = new System.Windows.Forms.Button();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblTipKontakta = new System.Windows.Forms.Label();
            this.cbTipKontakta = new System.Windows.Forms.ComboBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.gbPrikazIIzmena = new System.Windows.Forms.GroupBox();
            this.cbTipKontaktaInfo = new System.Windows.Forms.ComboBox();
            this.tbDatumInfo = new System.Windows.Forms.TextBox();
            this.tbBrojTelefonaInfo = new System.Windows.Forms.TextBox();
            this.tbImeInfo = new System.Windows.Forms.TextBox();
            this.tbPrezimeInfo = new System.Windows.Forms.TextBox();
            this.tbAdresaInfo = new System.Windows.Forms.TextBox();
            this.lblDodatoInfo = new System.Windows.Forms.Label();
            this.btnIzmeniKontakt = new System.Windows.Forms.Button();
            this.lblKontaktInfo = new System.Windows.Forms.Label();
            this.lblAdresaInfo = new System.Windows.Forms.Label();
            this.lblPrezimeInfo = new System.Windows.Forms.Label();
            this.lblImeInfo = new System.Windows.Forms.Label();
            this.lblTipKontaktaInfo = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tmPoruka = new System.Windows.Forms.Timer(this.components);
            this.btnObrisiKontakt = new System.Windows.Forms.Button();
            this.pKontrole = new System.Windows.Forms.Panel();
            this.pPoruka = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontakti)).BeginInit();
            this.gbKontroleDodaj.SuspendLayout();
            this.gbPrikazIIzmena.SuspendLayout();
            this.pKontrole.SuspendLayout();
            this.pPoruka.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKontakti
            // 
            this.dgvKontakti.AllowUserToAddRows = false;
            this.dgvKontakti.AllowUserToDeleteRows = false;
            this.dgvKontakti.AllowUserToResizeRows = false;
            this.dgvKontakti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKontakti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKontakti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKontakti.Location = new System.Drawing.Point(10, 10);
            this.dgvKontakti.MultiSelect = false;
            this.dgvKontakti.Name = "dgvKontakti";
            this.dgvKontakti.ReadOnly = true;
            this.dgvKontakti.RowHeadersVisible = false;
            this.dgvKontakti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvKontakti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKontakti.Size = new System.Drawing.Size(560, 540);
            this.dgvKontakti.TabIndex = 0;
            this.dgvKontakti.SelectionChanged += new System.EventHandler(this.dgvKontakti_SelectionChanged);
            this.dgvKontakti.Click += new System.EventHandler(this.dgvKontakti_Click);
            this.dgvKontakti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvKontakti_KeyDown);
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
            this.gbKontroleDodaj.Location = new System.Drawing.Point(6, 11);
            this.gbKontroleDodaj.Name = "gbKontroleDodaj";
            this.gbKontroleDodaj.Size = new System.Drawing.Size(290, 215);
            this.gbKontroleDodaj.TabIndex = 0;
            this.gbKontroleDodaj.TabStop = false;
            this.gbKontroleDodaj.Text = "Unos novog kontakta";
            // 
            // tbBrojTelefona
            // 
            this.tbBrojTelefona.Location = new System.Drawing.Point(125, 142);
            this.tbBrojTelefona.MaxLength = 20;
            this.tbBrojTelefona.Name = "tbBrojTelefona";
            this.tbBrojTelefona.Size = new System.Drawing.Size(140, 20);
            this.tbBrojTelefona.TabIndex = 4;
            this.tbBrojTelefona.Leave += new System.EventHandler(this.tbBrojTelefona_Leave);
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(38, 145);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(82, 13);
            this.lblBrojTelefona.TabIndex = 10;
            this.lblBrojTelefona.Text = "Kontakt telefon:";
            // 
            // btnDodajKontakt
            // 
            this.btnDodajKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKontakt.Location = new System.Drawing.Point(80, 170);
            this.btnDodajKontakt.Name = "btnDodajKontakt";
            this.btnDodajKontakt.Size = new System.Drawing.Size(130, 35);
            this.btnDodajKontakt.TabIndex = 5;
            this.btnDodajKontakt.Text = "Dodaj Kontakt";
            this.btnDodajKontakt.UseVisualStyleBackColor = true;
            this.btnDodajKontakt.Click += new System.EventHandler(this.btnDodajKontakt_Click);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(77, 115);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 9;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(73, 85);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(93, 55);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime:";
            // 
            // lblTipKontakta
            // 
            this.lblTipKontakta.AutoSize = true;
            this.lblTipKontakta.Location = new System.Drawing.Point(50, 25);
            this.lblTipKontakta.Name = "lblTipKontakta";
            this.lblTipKontakta.Size = new System.Drawing.Size(70, 13);
            this.lblTipKontakta.TabIndex = 6;
            this.lblTipKontakta.Text = "Tip kontakta:";
            // 
            // cbTipKontakta
            // 
            this.cbTipKontakta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipKontakta.FormattingEnabled = true;
            this.cbTipKontakta.Location = new System.Drawing.Point(125, 22);
            this.cbTipKontakta.Name = "cbTipKontakta";
            this.cbTipKontakta.Size = new System.Drawing.Size(140, 21);
            this.cbTipKontakta.TabIndex = 0;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(125, 112);
            this.tbAdresa.MaxLength = 512;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(140, 20);
            this.tbAdresa.TabIndex = 3;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(125, 82);
            this.tbPrezime.MaxLength = 50;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(140, 20);
            this.tbPrezime.TabIndex = 2;
            this.tbPrezime.Leave += new System.EventHandler(this.tbPrezime_Leave);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(125, 52);
            this.tbIme.MaxLength = 50;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(140, 20);
            this.tbIme.TabIndex = 1;
            this.tbIme.Leave += new System.EventHandler(this.tbIme_Leave);
            // 
            // gbPrikazIIzmena
            // 
            this.gbPrikazIIzmena.Controls.Add(this.cbTipKontaktaInfo);
            this.gbPrikazIIzmena.Controls.Add(this.tbDatumInfo);
            this.gbPrikazIIzmena.Controls.Add(this.tbBrojTelefonaInfo);
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
            this.gbPrikazIIzmena.Location = new System.Drawing.Point(6, 232);
            this.gbPrikazIIzmena.Name = "gbPrikazIIzmena";
            this.gbPrikazIIzmena.Size = new System.Drawing.Size(290, 245);
            this.gbPrikazIIzmena.TabIndex = 1;
            this.gbPrikazIIzmena.TabStop = false;
            this.gbPrikazIIzmena.Text = "Izabrani Kontakt";
            // 
            // cbTipKontaktaInfo
            // 
            this.cbTipKontaktaInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipKontaktaInfo.Enabled = false;
            this.cbTipKontaktaInfo.FormattingEnabled = true;
            this.cbTipKontaktaInfo.Location = new System.Drawing.Point(125, 22);
            this.cbTipKontaktaInfo.Name = "cbTipKontaktaInfo";
            this.cbTipKontaktaInfo.Size = new System.Drawing.Size(140, 21);
            this.cbTipKontaktaInfo.TabIndex = 0;
            // 
            // tbDatumInfo
            // 
            this.tbDatumInfo.Enabled = false;
            this.tbDatumInfo.Location = new System.Drawing.Point(125, 172);
            this.tbDatumInfo.MaxLength = 20;
            this.tbDatumInfo.Name = "tbDatumInfo";
            this.tbDatumInfo.Size = new System.Drawing.Size(140, 20);
            this.tbDatumInfo.TabIndex = 5;
            // 
            // tbBrojTelefonaInfo
            // 
            this.tbBrojTelefonaInfo.Enabled = false;
            this.tbBrojTelefonaInfo.Location = new System.Drawing.Point(125, 142);
            this.tbBrojTelefonaInfo.MaxLength = 20;
            this.tbBrojTelefonaInfo.Name = "tbBrojTelefonaInfo";
            this.tbBrojTelefonaInfo.Size = new System.Drawing.Size(140, 20);
            this.tbBrojTelefonaInfo.TabIndex = 4;
            this.tbBrojTelefonaInfo.Leave += new System.EventHandler(this.tbBrojTelefonaInfo_Leave);
            // 
            // tbImeInfo
            // 
            this.tbImeInfo.Enabled = false;
            this.tbImeInfo.Location = new System.Drawing.Point(125, 52);
            this.tbImeInfo.MaxLength = 50;
            this.tbImeInfo.Name = "tbImeInfo";
            this.tbImeInfo.Size = new System.Drawing.Size(140, 20);
            this.tbImeInfo.TabIndex = 1;
            this.tbImeInfo.Leave += new System.EventHandler(this.tbImeInfo_Leave);
            // 
            // tbPrezimeInfo
            // 
            this.tbPrezimeInfo.Enabled = false;
            this.tbPrezimeInfo.Location = new System.Drawing.Point(125, 82);
            this.tbPrezimeInfo.MaxLength = 50;
            this.tbPrezimeInfo.Name = "tbPrezimeInfo";
            this.tbPrezimeInfo.Size = new System.Drawing.Size(140, 20);
            this.tbPrezimeInfo.TabIndex = 2;
            this.tbPrezimeInfo.Leave += new System.EventHandler(this.tbPrezimeInfo_Leave);
            // 
            // tbAdresaInfo
            // 
            this.tbAdresaInfo.Enabled = false;
            this.tbAdresaInfo.Location = new System.Drawing.Point(125, 112);
            this.tbAdresaInfo.MaxLength = 512;
            this.tbAdresaInfo.Name = "tbAdresaInfo";
            this.tbAdresaInfo.Size = new System.Drawing.Size(140, 20);
            this.tbAdresaInfo.TabIndex = 3;
            // 
            // lblDodatoInfo
            // 
            this.lblDodatoInfo.AutoSize = true;
            this.lblDodatoInfo.Location = new System.Drawing.Point(26, 175);
            this.lblDodatoInfo.Name = "lblDodatoInfo";
            this.lblDodatoInfo.Size = new System.Drawing.Size(94, 13);
            this.lblDodatoInfo.TabIndex = 12;
            this.lblDodatoInfo.Text = "Datum dodavanja:";
            // 
            // btnIzmeniKontakt
            // 
            this.btnIzmeniKontakt.Enabled = false;
            this.btnIzmeniKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniKontakt.Location = new System.Drawing.Point(80, 200);
            this.btnIzmeniKontakt.Name = "btnIzmeniKontakt";
            this.btnIzmeniKontakt.Size = new System.Drawing.Size(130, 35);
            this.btnIzmeniKontakt.TabIndex = 6;
            this.btnIzmeniKontakt.Text = "Izmeni Kontakt";
            this.btnIzmeniKontakt.UseVisualStyleBackColor = true;
            this.btnIzmeniKontakt.Click += new System.EventHandler(this.btnIzmeniKontakt_Click);
            // 
            // lblKontaktInfo
            // 
            this.lblKontaktInfo.AutoSize = true;
            this.lblKontaktInfo.Location = new System.Drawing.Point(38, 145);
            this.lblKontaktInfo.Name = "lblKontaktInfo";
            this.lblKontaktInfo.Size = new System.Drawing.Size(82, 13);
            this.lblKontaktInfo.TabIndex = 11;
            this.lblKontaktInfo.Text = "Kontakt telefon:";
            // 
            // lblAdresaInfo
            // 
            this.lblAdresaInfo.AutoSize = true;
            this.lblAdresaInfo.Location = new System.Drawing.Point(77, 115);
            this.lblAdresaInfo.Name = "lblAdresaInfo";
            this.lblAdresaInfo.Size = new System.Drawing.Size(43, 13);
            this.lblAdresaInfo.TabIndex = 10;
            this.lblAdresaInfo.Text = "Adresa:";
            // 
            // lblPrezimeInfo
            // 
            this.lblPrezimeInfo.AutoSize = true;
            this.lblPrezimeInfo.Location = new System.Drawing.Point(73, 85);
            this.lblPrezimeInfo.Name = "lblPrezimeInfo";
            this.lblPrezimeInfo.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeInfo.TabIndex = 9;
            this.lblPrezimeInfo.Text = "Prezime:";
            // 
            // lblImeInfo
            // 
            this.lblImeInfo.AutoSize = true;
            this.lblImeInfo.Location = new System.Drawing.Point(93, 55);
            this.lblImeInfo.Name = "lblImeInfo";
            this.lblImeInfo.Size = new System.Drawing.Size(27, 13);
            this.lblImeInfo.TabIndex = 8;
            this.lblImeInfo.Text = "Ime:";
            // 
            // lblTipKontaktaInfo
            // 
            this.lblTipKontaktaInfo.AutoSize = true;
            this.lblTipKontaktaInfo.Location = new System.Drawing.Point(49, 25);
            this.lblTipKontaktaInfo.Name = "lblTipKontaktaInfo";
            this.lblTipKontaktaInfo.Size = new System.Drawing.Size(71, 13);
            this.lblTipKontaktaInfo.TabIndex = 7;
            this.lblTipKontaktaInfo.Text = "Tip Kontakta:";
            // 
            // lblPoruka
            // 
            this.lblPoruka.BackColor = System.Drawing.Color.Transparent;
            this.lblPoruka.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.Location = new System.Drawing.Point(0, 0);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(884, 26);
            this.lblPoruka.TabIndex = 0;
            this.lblPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(160, 485);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(140, 30);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Importuj iz fajla...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(160, 520);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(140, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Eksportuj u fajl...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tmPoruka
            // 
            this.tmPoruka.Interval = 5000;
            this.tmPoruka.Tick += new System.EventHandler(this.tmPoruka_Tick);
            // 
            // btnObrisiKontakt
            // 
            this.btnObrisiKontakt.Enabled = false;
            this.btnObrisiKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKontakt.Location = new System.Drawing.Point(20, 500);
            this.btnObrisiKontakt.Name = "btnObrisiKontakt";
            this.btnObrisiKontakt.Size = new System.Drawing.Size(110, 40);
            this.btnObrisiKontakt.TabIndex = 2;
            this.btnObrisiKontakt.Text = "Obriši Kontakt";
            this.btnObrisiKontakt.UseVisualStyleBackColor = true;
            this.btnObrisiKontakt.Click += new System.EventHandler(this.btnObrisiKontakt_Click);
            // 
            // pKontrole
            // 
            this.pKontrole.Controls.Add(this.btnExport);
            this.pKontrole.Controls.Add(this.btnObrisiKontakt);
            this.pKontrole.Controls.Add(this.btnImport);
            this.pKontrole.Controls.Add(this.gbKontroleDodaj);
            this.pKontrole.Controls.Add(this.gbPrikazIIzmena);
            this.pKontrole.Dock = System.Windows.Forms.DockStyle.Right;
            this.pKontrole.Location = new System.Drawing.Point(575, 0);
            this.pKontrole.Name = "pKontrole";
            this.pKontrole.Size = new System.Drawing.Size(309, 561);
            this.pKontrole.TabIndex = 1;
            // 
            // pPoruka
            // 
            this.pPoruka.BackColor = System.Drawing.SystemColors.Control;
            this.pPoruka.Controls.Add(this.lblPoruka);
            this.pPoruka.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPoruka.Location = new System.Drawing.Point(0, 561);
            this.pPoruka.Name = "pPoruka";
            this.pPoruka.Size = new System.Drawing.Size(884, 26);
            this.pPoruka.TabIndex = 3;
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 587);
            this.Controls.Add(this.pKontrole);
            this.Controls.Add(this.pPoruka);
            this.Controls.Add(this.dgvKontakti);
            this.Name = "FormGlavna";
            this.Text = "Contact Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGlavna_FormClosing);
            this.Load += new System.EventHandler(this.FormGlavna_Load);
            this.Shown += new System.EventHandler(this.FormGlavna_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontakti)).EndInit();
            this.gbKontroleDodaj.ResumeLayout(false);
            this.gbKontroleDodaj.PerformLayout();
            this.gbPrikazIIzmena.ResumeLayout(false);
            this.gbPrikazIIzmena.PerformLayout();
            this.pKontrole.ResumeLayout(false);
            this.pPoruka.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbTipKontaktaInfo;
        private System.Windows.Forms.TextBox tbDatumInfo;
        private System.Windows.Forms.TextBox tbBrojTelefonaInfo;
        private System.Windows.Forms.TextBox tbImeInfo;
        private System.Windows.Forms.TextBox tbPrezimeInfo;
        private System.Windows.Forms.TextBox tbAdresaInfo;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Timer tmPoruka;
        private System.Windows.Forms.Button btnObrisiKontakt;
        private System.Windows.Forms.Panel pKontrole;
        private System.Windows.Forms.Panel pPoruka;
    }
}


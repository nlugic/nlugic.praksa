using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Data;
using System.Text.RegularExpressions;

namespace ContactManager.MainForm
{
    public partial class FormGlavna : Form
    {
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            IspisiPorukuObavestenja("Dobrodišli u Contact Manager!");

            UcitajPodatke();
        }

        private void btnDodajKontakt_Click(object sender, EventArgs e)
        {
            if (ValidanUnosZaDodavanje())
                using (ContactManagerDBEntities baza = new ContactManagerDBEntities())
                {
                    ContactType tip = cbTipKontakta.SelectedItem as ContactType;
                    baza.ContactTypes.Attach(tip);

                    Contact zaDodavanje = new Contact { FirstName = PrvoSlovoVeliko(tbIme.Text.Trim(' ')),
                                                        LastName = PrvoSlovoVeliko(tbPrezime.Text.Trim(' ')),
                                                        Address = tbAdresa.Text.Trim(' '),
                                                        PhoneNumber = tbBrojTelefona.Text.Trim(' '),
                                                        InsertDate = DateTime.Now };

                    tip.Contacts.Add(zaDodavanje);
                    baza.SaveChanges();
                    IspisiPorukuObavestenja("Kontakt je uspešno dodat!");
                }
            ResetujKontroleZaDodavanje();
            UcitajPodatke();
        }

        private void btnIzmeniKontakt_Click(object sender, EventArgs e)
        {
            if (ValidanUnosZaIzmenu())
            {
                Contact zaIzmenu = (Contact)dgvKontakti.CurrentRow.DataBoundItem;

                using (ContactManagerDBEntities baza = new ContactManagerDBEntities())
                {
                    baza.Contacts.Attach(zaIzmenu);
                    
                    ContactType tip = cbTipKontaktaInfo.SelectedItem as ContactType;
                    baza.ContactTypes.Attach(tip);

                    zaIzmenu.FirstName = PrvoSlovoVeliko(tbImeInfo.Text.Trim(' '));
                    zaIzmenu.LastName = PrvoSlovoVeliko(tbPrezimeInfo.Text.Trim(' '));
                    zaIzmenu.Address = tbAdresaInfo.Text.Trim(' ');
                    zaIzmenu.PhoneNumber = tbBrojTelefonaInfo.Text.Trim(' ');
                    zaIzmenu.ContactType = tip;

                    baza.SaveChanges();
                    IspisiPorukuObavestenja("Kontakt je uspešno izmenjen!");
                }
            }
            ResetujKontroleZaIzmenu();
            UcitajPodatke();
        }

        private void btnObrisiKontakt_Click(object sender, EventArgs e)
        {
            BrisanjeKontakta();
        }

        private void BrisanjeKontakta()
        {
            Contact zaBrisanje = (Contact)dgvKontakti.CurrentRow.DataBoundItem;

            using (ContactManagerDBEntities baza = new ContactManagerDBEntities())
            {
                baza.Contacts.Attach(zaBrisanje);

                baza.Contacts.Remove(zaBrisanje);
                baza.SaveChanges();
                IspisiPorukuObavestenja("Kontakt je uspešno obrisan!");
            }
            ResetujKontroleZaIzmenu();
            UcitajPodatke();
        }

        private bool ValidanUnosZaDodavanje()
        {
            if (cbTipKontakta.SelectedIndex == -1)
            {
                IspisiPorukuGreske("Morate odabrati tip kontakta!");
                return false;
            }

            return ValidnoImeIBrTelefona(tbIme, tbBrojTelefona);
        }

        private bool ValidanUnosZaIzmenu()
        {
            return ValidnoImeIBrTelefona(tbImeInfo, tbBrojTelefonaInfo);
        }

        private bool ValidnoImeIBrTelefona(TextBox ime, TextBox tel)
        {
            if (string.IsNullOrWhiteSpace(ime.Text))
            {
                IspisiPorukuGreske("Ime mora biti prisutno!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tel.Text))
            {
                IspisiPorukuGreske("Broj telefona mora biti prisutan u odgovarajućem formatu (+XXX XX XXXXXXX)!");
                return false;
            }

            return ValidanFormatBrojaTelefona(tel);
        }

        private bool ValidanFormatBrojaTelefona(TextBox tel)
        {
            if (!dobarTelefon(tel.Text))
            {
                IspisiPorukuGreske("Niste uneli broj telefona u traženom formatu (+XXX XX XXXXXXX)!");
                return false;
            }

            return true;
        }

        private void IspisiPorukuUputstva(string poruka, bool ogranicenPrikaz)
        {
            IspisiPoruku(poruka, false);
            pPoruka.BackColor = Color.CornflowerBlue;
        }

        private void IspisiPorukuObavestenja(string poruka)
        {
            IspisiPoruku(poruka);
            pPoruka.BackColor = Color.DarkSeaGreen;
        }

        private void IspisiPorukuGreske(string poruka)
        {
            IspisiPoruku(poruka);
            pPoruka.BackColor = Color.IndianRed;
        }

        private void IspisiPoruku(string poruka, bool ogranicenPrikaz = true)
        {
            lblPoruka.Text = poruka;
            tmPoruka.Enabled = ogranicenPrikaz;
        }

        private void tmPoruka_Tick(object sender, EventArgs e)
        {
            lblPoruka.Text = string.Empty;
            tmPoruka.Enabled = false;
            pPoruka.BackColor = SystemColors.Control;
        }

        public static string PrvoSlovoVeliko(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] charArray = s.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);

            for (int i = 1; i < charArray.Length; i++)
                charArray[i] = char.ToLower(charArray[i]);
            
            return new string(charArray);
        }

        public static bool dobarTelefon(string brTel)
        {
            Regex brTelefona = new Regex(@"^((\+|00)\d{3})?[\s/-]?\d{2,3}[\s/-]?[\d\s/-]{7,14}$|^\d{10}$");
            return brTelefona.Match(brTel).Success;
        }

        private void FormGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult zatvori = MessageBox.Show("Da li ste sigurni da želite da zatvorite program?",
                                                   "Obaveštenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = !(zatvori == DialogResult.Yes);
        }

        private void tbIme_Leave(object sender, EventArgs e)
        {
            tbIme.Text = PrvoSlovoVeliko(tbIme.Text);
        }

        private void tbImeInfo_Leave(object sender, EventArgs e)
        {
            tbImeInfo.Text = PrvoSlovoVeliko(tbImeInfo.Text);
        }

        private void tbPrezime_Leave(object sender, EventArgs e)
        {
            tbPrezime.Text = PrvoSlovoVeliko(tbPrezime.Text);
        }

        private void tbPrezimeInfo_Leave(object sender, EventArgs e)
        {
            tbPrezimeInfo.Text = PrvoSlovoVeliko(tbPrezimeInfo.Text);
        }

        private void tbBrojTelefona_Leave(object sender, EventArgs e)
        {
            ValidanFormatBrojaTelefona(sender as TextBox);
        }

        private void tbBrojTelefonaInfo_Leave(object sender, EventArgs e)
        {
            ValidanFormatBrojaTelefona(sender as TextBox);
        }

        private void UcitajPodatke()
        {
            using (ContactManagerDBEntities baza = new ContactManagerDBEntities())
            {
                dgvKontakti.DataSource = (from c in baza.Contacts select c).ToList();

                cbTipKontakta.DataSource = (from ct in baza.ContactTypes select ct).ToList();
                cbTipKontaktaInfo.DataSource = (from ct in baza.ContactTypes select ct).ToList();

                PodesiDGVICB();
            }
        }

        private void PodesiDGVICB()
        {
            dgvKontakti.Columns["ContactID"].Visible = false;
            dgvKontakti.Columns["ContactTypeID"].Visible = false;

            dgvKontakti.Columns["FirstName"].HeaderText = "Ime";
            dgvKontakti.Columns["LastName"].HeaderText = "Prezime";
            dgvKontakti.Columns["Address"].HeaderText = "Adresa";
            dgvKontakti.Columns["PhoneNumber"].HeaderText = "Broj telefona";
            dgvKontakti.Columns["InsertDate"].HeaderText = "Upisan dana";
            dgvKontakti.Columns["ContactType"].HeaderText = "Grupa";

            dgvKontakti.ClearSelection();

            cbTipKontakta.DisplayMember = "Caption";
            cbTipKontaktaInfo.DisplayMember = "Caption";
        }

        private void dgvKontakti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKontakti.SelectedRows == null)
                ResetujKontroleZaIzmenu();
            else
                btnObrisiKontakt.Enabled = true;
        }

        private void dgvKontakti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvKontakti.SelectedRows != null)
                BrisanjeKontakta();
        }

        private void PopuniKontrole(Contact zaPopunu)
        {
            using (ContactManagerDBEntities baza = new ContactManagerDBEntities())
            {
                baza.Contacts.Attach(zaPopunu);

                cbTipKontaktaInfo.SelectedItem = zaPopunu.ContactType;
            }
            cbTipKontaktaInfo.Enabled = true;
            tbImeInfo.Text = zaPopunu.FirstName;
            tbImeInfo.Enabled = true;
            tbPrezimeInfo.Text = zaPopunu.LastName;
            tbPrezimeInfo.Enabled = true;
            tbAdresaInfo.Text = zaPopunu.Address;
            tbAdresaInfo.Enabled = true;
            tbBrojTelefonaInfo.Text = zaPopunu.PhoneNumber;
            tbBrojTelefonaInfo.Enabled = true;
            tbDatumInfo.Text = zaPopunu.InsertDate.ToString();
            btnIzmeniKontakt.Enabled = true;
            btnObrisiKontakt.Enabled = true;
        }

        private void ResetujKontroleZaDodavanje()
        {
            tbIme.Text = string.Empty;
            tbPrezime.Text = string.Empty;
            tbAdresa.Text = string.Empty;
            tbBrojTelefona.Text = string.Empty;

            dgvKontakti.ClearSelection();
        }

        private void ResetujKontroleZaIzmenu()
        {
            cbTipKontaktaInfo.Enabled = false;
            tbImeInfo.Text = string.Empty;
            tbImeInfo.Enabled = false;
            tbPrezimeInfo.Text = string.Empty;
            tbPrezimeInfo.Enabled = false;
            tbAdresaInfo.Text = string.Empty;
            tbAdresaInfo.Enabled = false;
            tbBrojTelefonaInfo.Text = string.Empty;
            tbBrojTelefonaInfo.Enabled = false;
            tbDatumInfo.Text = string.Empty;

            btnIzmeniKontakt.Enabled = false;
            btnObrisiKontakt.Enabled = false;

            dgvKontakti.ClearSelection();
        }

        private void dgvKontakti_Click(object sender, EventArgs e)
        {
            if (dgvKontakti.SelectedRows != null)
            {
                Contact zaPopunu = (Contact)dgvKontakti.CurrentRow.DataBoundItem;
                
                PopuniKontrole(zaPopunu);
                IspisiPorukuUputstva("Možete izmeniti odabrani kontakt, ili ga obrisati (DEL).", false);
            }
        }
    }
}

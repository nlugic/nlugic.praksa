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

namespace ContactManager.MainForm
{
    public partial class FormGlavna : Form
    {
        public FormGlavna()
        {
            InitializeComponent();
        }

        private void btnDodajKontakt_Click(object sender, EventArgs e)
        {
            if (ValidanUnosZaDodavanje())
                using (ContactManagerDBEntities baza = new ContactManagerDBEntities())
                {
                    Contact zaDodavanje = new Contact { ContactTypeID = cbTipKontakta.SelectedIndex + 1, // ne moze ovako
                                                        FirstName = tbIme.Text.Trim(' '),
                                                        LastName = tbPrezime.Text.Trim(' '),
                                                        Address = tbAdresa.Text.Trim(' '),
                                                        PhoneNumber = tbBrojTelefona.Text.Trim(' '),
                                                        InsertDate = DateTime.Now };
                    baza.Contacts.Add(zaDodavanje);
                    baza.SaveChanges();
                }
        }

        private void btnIzmeniKontakt_Click(object sender, EventArgs e)
        {
            if (ValidanUnosZaIzmenu())
                using (ContactManagerDBEntities baza = new ContactManagerDBEntities())
                {
                    Contact zaIzmenu = baza.Contacts.Find(); // na osnovu kliknutog, treba da se doda id

                    zaIzmenu.ContactTypeID = cbTipKontaktaInfo.SelectedIndex + 1; // ne moze ovako
                    zaIzmenu.FirstName = tbImeInfo.Text.Trim(' ');
                    zaIzmenu.LastName = tbPrezimeInfo.Text.Trim(' ');
                    zaIzmenu.Address = tbAdresaInfo.Text.Trim(' ');
                    zaIzmenu.PhoneNumber = tbBrojTelefonaInfo.Text.Trim(' ');

                    baza.SaveChanges();
                }
        }

        private void btnObrisiKontakt_Click(object sender, EventArgs e)
        {
            using (ContactManagerDBEntities baza = new ContactManagerDBEntities())
            {
                Contact zaBrisanje = baza.Contacts.Find(); // na osnovu kliknutog, treba da se doda id

                baza.Contacts.Remove(zaBrisanje);
                baza.SaveChanges();
            }
        }

        private bool ValidanUnosZaDodavanje()
        {
            if (cbTipKontakta.SelectedIndex == -1)
            {
                IspisiPorukuGreske("Morate odabrati tip kontakta!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbIme.Text))
            {
                IspisiPorukuGreske("Ime mora biti prisutno!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbBrojTelefona.Text))
            {
                IspisiPorukuGreske("Broj telefona mora biti prisutan u odgovarajućem formatu!");
                return false;
            }

            return true;
        }

        private bool ValidanUnosZaIzmenu()
        {
            if (string.IsNullOrWhiteSpace(tbImeInfo.Text))
            {
                IspisiPorukuGreske("Ime mora biti prisutno!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbBrojTelefonaInfo.Text))
            {
                IspisiPorukuGreske("Broj telefona mora biti prisutan u odgovarajućem formatu!");
                return false;
            }

            return true;
        }

        private void IspisiPorukuUputstva(string poruka)
        {
            IspisiPoruku(poruka, false);
            pPoruka.BackColor = Color.DarkSeaGreen;
        }

        private void IspisiPorukuObavestenja(string poruka)
        {
            IspisiPoruku(poruka);
            pPoruka.BackColor = Color.CornflowerBlue;
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
        }

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            IspisiPorukuObavestenja("Dobrodišli u Contact Manager!");
        }

    }
}

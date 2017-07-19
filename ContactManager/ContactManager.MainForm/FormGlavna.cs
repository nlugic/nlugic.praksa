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
                using (var db = new ContactManagerDBEntities())
                {
                    Contact zaDodavanje = new Contact { ContactTypeID = cbTipKontakta.SelectedIndex, // ne moze ovako
                                                        FirstName = tbIme.Text,
                                                        LastName = tbPrezime.Text,
                                                        Address = tbAdresa.Text,
                                                        PhoneNumber = tbBrojTelefona.Text,
                                                        InsertDate = DateTime.Now };
                    db.Contacts.Add(zaDodavanje);
                    db.SaveChanges();
                }
        }

        private void btnIzmeniKontakt_Click(object sender, EventArgs e)
        {
            if (ValidanUnosZaIzmenu())
                using (var db = new ContactManagerDBEntities())
                {
                    Contact zaIzmenu = db.Contacts.Find(); // na osnovu kliknutog

                    zaIzmenu.ContactTypeID = cbTipKontaktaInfo.SelectedIndex; // ne moze ovako
                    zaIzmenu.FirstName = tbImeInfo.Text;
                    zaIzmenu.LastName = tbPrezimeInfo.Text;
                    zaIzmenu.Address = tbAdresaInfo.Text;
                    zaIzmenu.PhoneNumber = tbKontaktInfo.Text;

                    db.SaveChanges();
                }
        }

        private bool ValidanUnosZaDodavanje()
        {
            return false; // da ne kenja
        }

        private bool ValidanUnosZaIzmenu()
        {
            return false; // da ne kenja
        }

    }
}

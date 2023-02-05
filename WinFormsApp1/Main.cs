using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DataAccessLayer;
using EntityLayer;

namespace UILayer
{
    public partial class Main : Form
    {
        PlakContext context;

        public Main()
        {
            InitializeComponent();
        }
        #region buttons
        private void btnGiris_Click(object sender, EventArgs e)
        {
            context = new PlakContext();

            var user = context.AppUsers.Where(x => x.UserName == txtKullaniciAdi.Text).ToList();
            string passwordUnCrypted = sha256_hash(txtSifre.Text);
            
            if (user.Count != 0)
            {
                if (user[0].UserPassword == passwordUnCrypted) // Password check
                {
                   
                    CleanTheControls(groupBox1.Controls);
                    groupBox2.Visible = true;
                    groupBox1.Visible = false;
                    grpCreateNewAccount.Visible = false;
                }
                else
                {
                    MessageBox.Show("Password is not correct. Please check the password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CleanTheControls(groupBox1.Controls);
                }

            }
            else
            {
                MessageBox.Show("UserName  is not correct. Please create a new account.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CleanTheControls(groupBox1.Controls);
            }
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            context = new PlakContext();
            if ( txtSifree.Text == txtSifreTekrari.Text)
            {
                if ( CheckForSpecialCharacter(txtSifree.Text))
                {
                    if (CheckForLowerCase(txtSifree.Text))
                    {
                        if (CheckForUpperCase(txtSifree.Text))
                        {
                            AppUser newuser = new AppUser() { UserName = txtKullaniciAdii.Text, UserPassword = sha256_hash(txtSifree.Text) };
                            context.AppUsers.Add(newuser);
                            context.SaveChanges();
                            
                            groupBox1.Visible = true;
                            grpCreateNewAccount.Visible = false;
                            CleanTheControls(grpCreateNewAccount.Controls);

                        }
                        else
                        {
                            MessageBox.Show("Please use in password minumum 2 uppercase characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CleanTheControls(grpCreateNewAccount.Controls);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please use in password minumum 3 lowercase characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CleanTheControls(grpCreateNewAccount.Controls);
                    }
                }
                else
                {
                    MessageBox.Show("Please use minumum 2 speacial characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CleanTheControls(grpCreateNewAccount.Controls);
                }

            }
            else
            {
                MessageBox.Show("Passwords are not same!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CleanTheControls(grpCreateNewAccount.Controls);
            }


        }

        #endregion
        #region methods 


        /// <summary>
        /// change string format to encrypted to save password into database as a clear-text
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


        public void CleanTheControls(Control.ControlCollection RelatedGroupBox)
        {
            foreach (Control control in RelatedGroupBox)
            {
                if (control is GroupBox)
                {

                    foreach (Control control1 in control.Controls)
                    {
                        if (control1 is TextBox)
                        {
                            ((TextBox)control1).Clear();
                        }
                        else if (control1 is DateTimePicker)
                        {
                            ((DateTimePicker)control1).Value = DateTime.Now;
                        }
                        else if (control1 is ComboBox)
                        {
                            ((ComboBox)control1).SelectedIndex = 0;
                        }
                    }
                }
            }
        }


        public  bool CheckForLowerCase(string sifre)
        {
            int count = 0;
            foreach (char item in sifre)
            {
                if (char.IsLower(item))
                {
                    count++;
                }
            }
            if (count >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  bool CheckForSpecialCharacter(string sifre)
        {
            string specialCharacters = "!:+*";
            int count = 0;
            foreach (char item in sifre)
            {
                if (specialCharacters.Contains(item))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  bool CheckForUpperCase(string sifre)
        {
            int count = 0;
            foreach (char item in sifre)
            {
                if (char.IsUpper(item))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        private void lblYoneticiGirisi_Click(object sender, EventArgs e)
        {
            
            groupBox1.Visible = false;
            grpCreateNewAccount.Visible = true;
        }
    }
}

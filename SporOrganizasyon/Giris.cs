using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SporOrganizasyon
{
    public partial class Giris : Form
    {
        BusinessLogic bl;
        public Giris()
        {
            InitializeComponent();
            bl = new BusinessLogic();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int id = bl.LoginKontrol(txtKullanici.Text, txtSifre.Text);
            if ( id > 0)
            {
                
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                AnaEkran anaEkran = new AnaEkran(txtKullanici.Text, id);
                anaEkran.ShowDialog();
                this.Close();
               
            }
            else
                MessageBox.Show("Giriş Başarısız");
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kaydol form = new Kaydol();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void txtKullanici_Click(object sender, EventArgs e)
        {
            if(txtKullanici.Text=="Kullanıcı Adı")
            txtKullanici.Clear();
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            txtSifre.Clear();
            txtSifre.PasswordChar = '*';
            
            
        }

       
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
                txtSifre.Clear();
            txtSifre.PasswordChar = '*';
        }
    }
}

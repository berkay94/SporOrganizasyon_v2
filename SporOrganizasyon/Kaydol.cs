using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace SporOrganizasyon
{
    public partial class Kaydol : Form
    {
        BusinessLogic bl;
        
        public Kaydol()
        {
            InitializeComponent();
            bl = new BusinessLogic();
        }

        private void groupBoxKullanici_Enter(object sender, EventArgs e)
        {

        }

        private void Kaydol_Load(object sender, EventArgs e)
        {
            foreach (var spor in bl.SporAl())
            {
                checkedListBoxSpor.Items.Add(spor);
                
                checkedListBoxSpor.DisplayMember = "SporAdi";
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            int[] sporlar = new int[checkedListBoxSpor.CheckedItems.Count];
            for (int i = 0; i < sporlar.Length; i++)
            {
                Sporlar castedItem = checkedListBoxSpor.CheckedItems[i] as Sporlar;
                sporlar[i] = castedItem.SporId;
            }

            int k = bl.KullaniciKaydet(txtAd.Text, txtSoyad.Text, txtEmail.Text, maskedTelefon.Text, txtSifre.Text, txtIlce.Text,Convert.ToDateTime(dateTimeTrh.Text),Convert.ToInt32(comboBoxCins.ValueMember),sporlar);

          

            if (k > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {

                MessageBox.Show("Girilen Değerlerde Eksiklik Var!!");
            }

            // MessageBox.Show(checkedListBoxSpor.CheckedItems.Count.ToString());
        }

        private void comboBoxCins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCins.SelectedIndex==0)
            {
                comboBoxCins.ValueMember = "0";
            }
            else
            {
                comboBoxCins.ValueMember = "1";
            }
        }

       
    }
}

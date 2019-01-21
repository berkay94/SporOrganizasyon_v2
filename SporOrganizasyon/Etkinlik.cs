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
using DAL;
namespace SporOrganizasyon
{
    public partial class Etkinlik : Form
    {
        BusinessLogic bl;
        public Etkinlik()
        {
            InitializeComponent();
            bl = new BusinessLogic();
        }

        private void Etkinlik_Load(object sender, EventArgs e)
        {
            comboBoxTip.DataSource = bl.EtkinlikTipAl<EtkinlikTip>();
            comboBoxTip.DisplayMember = "Tip";
            comboBoxTip.ValueMember = "TipId";

            comboBoxMekan.DataSource = bl.MekanAl<Mekanlar>();
            comboBoxMekan.DisplayMember = "MekanAdi";
            comboBoxMekan.ValueMember = "Mid";

            comboBoxSpor.DataSource = bl.SporAl<Sporlar>();
            comboBoxSpor.DisplayMember = "SporAdi";
            comboBoxSpor.ValueMember = "SporId";
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            int k = bl.EtkinlikAc(txtEtkinlik.Text, int.Parse(comboBoxTip.SelectedValue.ToString()), int.Parse(comboBoxMekan.SelectedValue.ToString()),Convert.ToDateTime(maskedTextBoxTrh.Text), int.Parse(txtKontenjan.Text),int.Parse(comboBoxSpor.SelectedValue.ToString()));

            if (k>0)
            {
                MessageBox.Show("Etkinlik Oluştu");
            }
            else
            {
                MessageBox.Show("Etkinlik Oluşamadı");
            }
        }
    }
}

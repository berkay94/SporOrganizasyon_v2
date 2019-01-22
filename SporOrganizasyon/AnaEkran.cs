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
    public partial class AnaEkran : Form
    {
        public string Username { get; set; }
        public int Userid { get; set; }

        BusinessLogic bl;
        public AnaEkran(string username, int userid)
        {
            InitializeComponent();
            bl = new BusinessLogic();
            Username = username;
            Userid = userid;
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = bl.EtkinlikAl();
            dataGridView1.Columns["EtkinlikId"].Visible = false;
            labelGiris.Text = Username;
        }

        private void AnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttonMekan_Click(object sender, EventArgs e)
        {
            Mekan mekan = new Mekan();
            this.Hide();
            mekan.ShowDialog();
            this.Show();
        }

        private void buttonEtkinlik_Click(object sender, EventArgs e)
        {
            Etkinlik etkinlik = new Etkinlik();
            this.Hide();
            etkinlik.ShowDialog();
            this.Show();
        }

        private void buttonKatil_Click(object sender, EventArgs e)
        {
            int id = bl.Katil(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Userid);
            if (id > 0)
            {
                MessageBox.Show("Etkinliğe Katıldınız");
            }
            else
            {
                MessageBox.Show("Problem Oluştu");
            }
        }
        //asdassd
       

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            buttonKatil.Visible = true;
        }
    }
}

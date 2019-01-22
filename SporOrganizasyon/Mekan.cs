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

    public partial class Mekan : Form
    {
        BusinessLogic bl;
        public Mekan()
        {
            InitializeComponent();
            bl = new BusinessLogic();
           
        }

        private void Mekan_Load(object sender, EventArgs e)
        {
            foreach (var il in bl.Iller())
            {
                TreeNode node = new TreeNode(il.Sehir);
                node.Tag = il.Id;
                treeViewKonum.Nodes.Add(node);
                foreach (var ilce in bl.Ilceler(il.Id))
                {
                    TreeNode Altnode = new TreeNode(ilce.Ad);
                    Altnode.Tag = ilce.Id;
                    node.Nodes.Add(Altnode);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           int k= bl.MekanAc(txtMekanAdi.Text, Convert.ToInt32(treeViewKonum.SelectedNode.Tag));

            if (k > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
                MessageBox.Show("Girilen Değerlerde Eksiklik Var!!");
            }
        }
    }
}

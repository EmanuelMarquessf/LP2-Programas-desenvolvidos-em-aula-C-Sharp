using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PontoDeVenda.View
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnProductMenuItem_Click(object sender, EventArgs e)
        {
            BtnProductMenuItem.BackColor = Color.DarkSeaGreen;

            FrmCostumer product = new();
            product.ShowDialog();

            BtnProductMenuItem.BackColor = Color.WhiteSmoke;


        }

        private void btnClientMenuItem_Click(object sender, EventArgs e)
        {
            btnClientMenuItem.BackColor = Color.DarkSeaGreen;

            this.Visible = false;
            FrmConsultClient client = new();
            client.ShowDialog();
            this.Visible = true;

            btnClientMenuItem.BackColor = Color.WhiteSmoke;
        }
    }
}

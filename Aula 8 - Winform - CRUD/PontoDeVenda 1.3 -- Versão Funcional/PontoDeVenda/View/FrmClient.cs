using PontoDeVenda.Model;
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
    public partial class FrmClient : Form
    {
        private int id = -1;
        public FrmClient()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string cpf = mtbCpf.Text;
            string email = txbEmail.Text;
            string fone = mtbFone.Text;

            try
            {
                ClientDAO clientDAO = new();
                if (id == -1)
                {
                    Client client = new(name, cpf, email, fone);
                    clientDAO.Insert(client);
                }
                else
                {
                    Client client = new(id, name, cpf, email, fone);
                    clientDAO.Update(client);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbName.Focus();
                if (err.Message.ToUpper().Contains("Nome"))
                    txbName.Focus();
                if (err.Message.ToUpper().Contains("CPF"))
                    mtbCpf.Focus();
                if (err.Message.ToUpper().Contains("Email"))
                    txbEmail.Focus();
                if (err.Message.ToUpper().Contains("Telefone"))
                    mtbFone.Focus();
                return;
            }
            MessageBox.Show("Cliente Cadastrado!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Clear();
            mtbCpf.Clear();
            txbEmail.Clear();
            mtbFone.Clear();
            txbName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClientDAO clientDao = new();

            try
            {
                clientDao.Delete(id);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnClear_Click(null, null);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

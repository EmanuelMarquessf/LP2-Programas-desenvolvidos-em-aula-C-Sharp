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
    public partial class FrmCostumer : Form
    {
        public FrmCostumer()
        {
            InitializeComponent();
        }
       
                private void BtnSave_Click(object sender, EventArgs e)
                {/*
                    string description = txbDescription.Text;
                    int quant = nmcQuant.DecimalPlaces;
                    string value = mskValue.Text;

                    try
                    {
                        Product product = new(description, quant, value);
                        ProductDAO productDAO = new();
                        productDAO.insert(product);
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show($"{err.Message}", "AVISO DE ERRO", MessageBox);
                        if (err.Message.ToUpper().Contains("Descricao"))
                            txbDescription.Focus();
                        if (err.Message.ToUpper().Contains("Quantidade"))
                            nmcQuant.Focus();
                        if (err.Message.ToUpper().Contains("Valor"))
                            mskValue.Focus();
                        return;
                    }
            */
                }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplo2.Formularios
{
    public partial class FormExemploComboBox : Form
    {
        public FormExemploComboBox()
        {
            InitializeComponent();
            txtPercDesconto.Visible = false; //para não ficar visivel
            LbPercentual.Visible = false; // para não ficar visivel

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            int tipoCliente = cbTipoCliente.SelectedIndex;
            double valorCompra = Convert.ToDouble(txtValorCompra.Text);
            double valorComDesconto = 0;

            switch (tipoCliente)
            {
                case 0: //Cliente Diamante: 25%
                    {
                        valorComDesconto =  valorCompra - valorCompra * 0.25;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    } 
                case 1: //Cliente Ouro: 20%
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.20;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }

                case 2: //Cliente VIP: 15%
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.15;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;

                        break;
                    }

                case 3: //Cliente COMUM: 10%
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.10;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
         
                    }

                case 4: //Cliente Aleatório: 5%
                    {

                        valorComDesconto = valorCompra - valorCompra * 0.05;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;                     
                    }

                default:
                    {
                        MessageBox.Show("SELECIONE UM CLIENTE Por Favor", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
    
                    }
                 
            } // fim da estrutura switch

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbTipoCliente.SelectedIndex = -1;
            txtPercDesconto.Clear();
            txtResultado.Clear();
            txtValorCompra.Clear();
            txtPercDesconto.Visible = false;  
            LbPercentual.Visible= false;

        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;

            if(tipoCliente == 4)
            {
                txtPercDesconto.Visible = true; //para ficar visivel.
                LbPercentual.Visible = true;
            }
            else
            {
                txtPercDesconto.Visible= false;
                LbPercentual.Visible = false;
            }

        }

        private void FormExemploComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplo2.Formularios
{
    public partial class FormExemploAlerta : Form
    {
        public FormExemploAlerta()
        {
            InitializeComponent();
        }

        private void FormExemploAlerta_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            double valor1, valor2, total;
            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            if (valor2 !=0)
            {

                total = valor1 / valor2;
                txtTotal.Text = total.ToString("F2");

            }
            else
            {
                MessageBox.Show("Não é Possivel dividir por zero!", "ADS/JIPA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor2.Clear();
                txtValor2.Select();
            }

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

            txtTotal.Clear();
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor1.Select();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

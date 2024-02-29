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
    public partial class FormExemploRotulos : Form
    {
        public FormExemploRotulos()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {

            txtPercentual.Clear();
            txtSalarioAtual.Clear();
            txtSalarioAtual.Select();
            LbResultado.Text = "SALARIO REAJUSTADO:";
            LbResultado.ForeColor = Color.Black;

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            double salarioAtual = 0;
            double percentual = 0;
            double salarioReajustado = 0;

            salarioAtual = Convert.ToDouble(txtSalarioAtual.Text);
            percentual = Convert.ToDouble(txtPercentual.Text);
            percentual = percentual / 100;

            salarioReajustado = salarioAtual + salarioAtual * percentual;

            LbResultado.Text = "O salario Atualizado: " + salarioReajustado.ToString("C2");
            LbResultado.ForeColor = Color.Blue;

            //C2 => para moeda corrente R$ 0,00


        }

        private void txtSalarioAtual_KeyDown(object sender, KeyEventArgs e)
        {

            //para ir para o campo seguinte
            if(e.KeyCode == Keys.Enter)
            {
                
                // verifica se o campo esta vazio
                if (txtSalarioAtual.Text == "")
                {
                    MessageBox.Show("O Campo está vazio!", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSalarioAtual.Select();  //volta ao campo
                }
                else
                {

                    txtPercentual.Select();

                }

            }

        }

        private void txtSalarioAtual_KeyUp(object sender, KeyEventArgs e)
        {

            bool verificarNumero = false;

            // Verificar do que foi digitad => Numer ou Letra?

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;
            }
            else{ 
                //liberar a virgula
                if(e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;

                if (e.KeyCode == Keys.Enter) verificarNumero = true; //liberar a tecla enter
                if (e.KeyCode == Keys.Back) verificarNumero = true; //liberar a tecla back
                int qtdVirgula = txtSalarioAtual.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false; //verificar virgulas

            }

            //varificar final => a mensagem vai aparecer se um dos itens não atendido
            if(verificarNumero == false)
            {
                MessageBox.Show("Somente numeros", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioAtual.Text = txtSalarioAtual.Text.Remove(txtSalarioAtual.Text.Length - 1);
            }

        }

        private void FormExemploRotulos_Load(object sender, EventArgs e)
        {

        }
    }
}

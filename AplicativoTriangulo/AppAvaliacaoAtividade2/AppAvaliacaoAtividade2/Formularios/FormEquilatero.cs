using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace AppAvaliacaoAtividade2.Formularios
{
    public partial class FormEquilatero : Form
    {
        public FormEquilatero()
        {
            InitializeComponent();
            txtAreaEqui.BackColor = Color.LightPink;

        }

        private void cbTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;
            switch (tipoCalculo)
            {
                case 0: //calculo da area
                    {
                        txtAltura.Visible = false;
                        lbAltura.Visible = false;

                        txtAreaEqui.Visible = true;
                        lbAreaEqui.Visible = true;

                        txtAreaEqui.BackColor = Color.LightPink;
                        txtLadoTri.BackColor = Color.White; 

                        break;
                    }
                case 1: //decobrir altura
                    {
                        txtAreaEqui.Visible = false;
                        lbAreaEqui.Visible = false;

                        txtAltura.Visible = true;
                        lbAltura.Visible = true;

                        txtLadoTri.BackColor = Color.White;
                        txtAltura.BackColor = Color.LightPink;

                        break;

                    }
                case 2: //decobrir o lado
                    {
                        txtAltura.Visible = false;
                        lbAltura.Visible = false;

                        txtAreaEqui.Visible = true;
                        lbAreaEqui.Visible = true;

                        txtAreaEqui.BackColor = Color.White;
                        txtLadoTri.BackColor = Color.LightPink;

                        break;
                    }
                    

            } //fim s.


        }

        private void lbAreaEqui_Click(object sender, EventArgs e)
        {

        }

        private void txtAreaEqui_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;

            //Variaveis
            double ladoTri, areaEqui, altura;

            switch (tipoCalculo)
            {
                case 0: // area do triangulo
                    {
                        ladoTri = Convert.ToDouble(txtLadoTri.Text);
                        areaEqui = (Math.Pow(ladoTri, 2) * Math.Sqrt(3) / 4 );
                       
                        txtAreaEqui.Text = areaEqui.ToString("F2");

                        break;
                    }
                case 1: // altura do triangulo
                    {
                        ladoTri = Convert.ToDouble(txtLadoTri.Text);
                        altura = (Math.Sqrt(3) * ladoTri) / 2;

                        txtAltura.Text = altura.ToString("F2");

                        break;
                    }
                case 2: // lado do triangulo
                    {
                        areaEqui = Convert.ToDouble(txtAreaEqui.Text);
                        ladoTri = Math.Sqrt((areaEqui * 4) / Math.Sqrt(3));
  
                        txtLadoTri.Text = ladoTri.ToString("F2");

                        break;
                    }
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbTipoCalculo.Items.Clear();
            txtLadoTri.Clear();
            txtAltura.Clear();
            txtAreaEqui.Clear();

        }

        private void txtLadoTri_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificar = false;

            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificar = true;
                if (e.KeyCode == Keys.Tab) verificar = true;
                if (e.KeyCode == Keys.Back) verificar = true;

                int virgula = txtLadoTri.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLadoTri.Text = txtLadoTri.Text.Remove(txtLadoTri.Text.Length - 1);
            }
        }

        private void txtAltura_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificar = false;

            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificar = true;
                if (e.KeyCode == Keys.Tab) verificar = true;
                if (e.KeyCode == Keys.Back) verificar = true;

                int virgula = txtAltura.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAltura.Text = txtAltura.Text.Remove(txtAltura.Text.Length - 1);
            }
        }

        private void txtAreaEqui_KeyUp(object sender, KeyEventArgs e)
        {

            bool verificar = false;

            if ((e.KeyCode == Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificar = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificar = true;
                if (e.KeyCode == Keys.Tab) verificar = true;
                if (e.KeyCode == Keys.Back) verificar = true;

                int virgula = txtAreaEqui.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAreaEqui.Text = txtAreaEqui.Text.Remove(txtAreaEqui.Text.Length - 1);
            }

        }
    }
}

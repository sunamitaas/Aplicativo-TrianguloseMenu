using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAvaliacaoAtividade2.Formularios
{
    public partial class FormRetangulo : Form
    {
        public FormRetangulo()
        {
            InitializeComponent();
            txtHipotenusa.Visible = false;
            txtArea.Visible = false;
            lbHipotenusa.Visible = false;
            lbArea.Visible = false;
            txtArea.BackColor = Color.LightPink;
        }

        private void cbTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;
            switch (tipoCalculo)
            {
                case 0: //calculo da area
                    {
                        txtHipotenusa.Visible = false;
                        lbHipotenusa.Visible = false;

                        txtArea.Visible = true;
                        lbArea.Visible = true;
                        txtCatetoA.BackColor = Color.White;
                        txtCatetoB.BackColor = Color.White;
                        break;
                    }
                case 1: //decobrir o valor de (a)
                    {
                        txtArea.Visible = false;
                        lbArea.Visible = false;

                        txtHipotenusa.Visible = true;
                        lbHipotenusa.Visible = true;
                        txtCatetoA.BackColor = Color.LightPink;
                        txtCatetoB.BackColor = Color.White;
                        txtHipotenusa.BackColor = Color.White;
                        break;
                    }
                case 2: //decobrir o valor de (b)
                    {
                        txtArea.Visible = false;
                        lbArea.Visible = false;

                        txtHipotenusa.Visible = true;
                        lbHipotenusa.Visible = true;
                        txtCatetoA.BackColor = Color.White;
                        txtCatetoB.BackColor = Color.LightPink;
                        txtHipotenusa.BackColor = Color.White;

                        break;
                    }
                     
                case 3: //decobrir o valor de (c)
                    {
                        txtArea.Visible = false;
                        lbArea.Visible = false;

                        txtHipotenusa.Visible = true;
                        lbHipotenusa.Visible = true;
                        txtCatetoA.BackColor = Color.White;
                        txtCatetoB.BackColor = Color.White;
                        txtHipotenusa.BackColor = Color.LightPink;

                        break;
                    }

            } //fim s.
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;

            //Variaveis
            double catetoA, catetoB, hipotenusa, area;

            switch (tipoCalculo)
            {
                case 0:
                    {
                        catetoA = Convert.ToDouble(txtCatetoA.Text);
                        catetoB = Convert.ToDouble(txtCatetoB.Text);
                        area = (catetoA * catetoB) / 2;
                        txtArea.Text = area.ToString("F2");

                        break;
                    }
                case 1:
                    {
                        catetoB = Convert.ToDouble(txtCatetoB.Text);
                        hipotenusa = Convert.ToDouble(txtHipotenusa.Text);

                        catetoB = catetoB * catetoB;
                        hipotenusa = hipotenusa * hipotenusa;

                        catetoA = Math.Pow((hipotenusa - catetoB), 0.5);
                        txtCatetoA.Text = catetoA.ToString("F2");

                        break;
                    }
                case 2:
                    {
                        catetoA = Convert.ToDouble(txtCatetoA.Text);
                        hipotenusa = Convert.ToDouble(txtHipotenusa.Text);

                        catetoA = catetoA * catetoA;
                        hipotenusa = hipotenusa * hipotenusa;

                        catetoB = Math.Pow((hipotenusa - catetoA), 0.5);
                        txtCatetoA.Text = catetoA.ToString("F2");

                        break;
                    }
                case 3:
                    {
                        catetoA = Convert.ToDouble(txtCatetoA.Text);
                        catetoB = Convert.ToDouble(txtHipotenusa.Text);

                        catetoA = catetoA * catetoA;
                        catetoB = catetoB * catetoB;

                        hipotenusa = Math.Pow((catetoB - catetoA), 0.5);
                        txtCatetoA.Text = catetoA.ToString("F2");

                        break;
                    }
            }

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbTipoCalculo.Items.Clear();
            txtCatetoA.Clear();
            txtCatetoB.Clear();
            txtHipotenusa.Clear();
            txtArea.Clear();

        }

        private void txtCatetoA_KeyUp(object sender, KeyEventArgs e)
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

                int virgula = txtCatetoA.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatetoA.Text = txtCatetoA.Text.Remove(txtCatetoA.Text.Length - 1);
            }
        }

        private void txtCatetoB_KeyUp(object sender, KeyEventArgs e)
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

                int virgula = txtCatetoB.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatetoB.Text = txtCatetoB.Text.Remove(txtCatetoB.Text.Length - 1);
            }
        }

        private void txtHipotenusa_KeyUp(object sender, KeyEventArgs e)
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

                int virgula = txtHipotenusa.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHipotenusa.Text = txtHipotenusa.Text.Remove(txtHipotenusa.Text.Length - 1);
            }

        }

        private void txtArea_KeyUp(object sender, KeyEventArgs e)
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

                int virgula = txtArea.Text.Count(v => v == ',');
                if (virgula > 1) verificar = false;

            }

            if (verificar == false)
            {
                MessageBox.Show("Somente Números", "CC/ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArea.Text = txtArea.Text.Remove(txtArea.Text.Length - 1);
            }

        }
    }
}

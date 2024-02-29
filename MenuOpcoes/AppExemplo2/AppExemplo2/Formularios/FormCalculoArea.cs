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
    public partial class FormCalculoArea : Form
    {
        public FormCalculoArea()
        {
            InitializeComponent();
            txtHipotenusa.Visible = false;
            txtArea.Visible = false;
            lbHipotenusa.Visible=false;
            //lbArea.Visible = false;
            txtArea.BackColor = Color.LightGreen;  //mudar a cor de fundo

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                        LbArea.Visible = true;
                        txtCatetoA.BackColor = Color.White;
                        txtCatetoB.BackColor = Color.White;
                        break;
                    }
                case 1: //decobrir o valor de (a)
                    {
                        txtArea.Visible = false;
                        LbArea.Visible = false;

                        txtHipotenusa.Visible = true;
                        lbHipotenusa.Visible = true;
                        txtCatetoA.BackColor = Color.LightGreen;
                        txtCatetoB.BackColor = Color.White;
                        txtHipotenusa.BackColor = Color.White;
                        break;
                    }
            
            }

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemplo2.Formularios;  // 1° fazer esta declaração.

namespace AppExemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAlertas_Click(object sender, EventArgs e)
        {

           FormAlertas form = new FormAlertas();
           form.ShowDialog();

        }

        private void btExemploAlerta_Click(object sender, EventArgs e)
        {

            FormExemploAlerta form = new FormExemploAlerta();
            form.ShowDialog();

        }

        private void btAlteracaoRotulo_Click(object sender, EventArgs e)
        {

            FormExemploRotulos form = new FormExemploRotulos();
            form.ShowDialog();

        }

        private void btComboBox_Click(object sender, EventArgs e)
        {

            FormExemploComboBox form = new FormExemploComboBox();
            form.ShowDialog();

        }
    }
}

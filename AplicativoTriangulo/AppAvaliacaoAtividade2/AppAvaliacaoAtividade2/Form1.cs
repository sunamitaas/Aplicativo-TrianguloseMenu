using AppAvaliacaoAtividade2.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAvaliacaoAtividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_CaixaNome_Click(object sender, EventArgs e)
        {

        }

        private void btEquilatero_Click(object sender, EventArgs e)
        {
            FormEquilatero form = new FormEquilatero();
            form.ShowDialog();
        }

        private void btRetangulo_Click(object sender, EventArgs e)
        {
            FormRetangulo form = new FormRetangulo();
            form.ShowDialog();
        }

        private void btIsosceles_Click(object sender, EventArgs e)
        {
            FormIsosceles form = new FormIsosceles();
            form.ShowDialog();
        }

        private void btAreaTriangulo_Click(object sender, EventArgs e)
        {
            FormAreaTriangulo form = new FormAreaTriangulo();
            form.ShowDialog();
        }
    }
}

using cadastroAnimal.Controller;
using cadastroAnimal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroAnimal.view
{
    public partial class TelaCadastroAnimais : Form
    {
        public TelaCadastroAnimais()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrer_Click(object sender, EventArgs e)
        {
            Animais.Nome = tbx_name.Text;
            Animais.Raca = tbx_raca.Text;
            Animais.Porte = cbx_.Porte.Text;

            ControllerAnimais
        }
    }
}

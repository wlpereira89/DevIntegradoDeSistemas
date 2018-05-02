using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.PN;

namespace Servidor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gerarCli_Click(object sender, EventArgs e)
        {
            povoarBanco.gerarCliente();
            MessageBox.Show("Dados inseridos");
        }

        private void gerarPedidos_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
            Form1 _f1;
            _f1 = new Form1();
            _f1.Show();
        }
    }
}

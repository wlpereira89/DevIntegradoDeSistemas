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

namespace App
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
            Form5 _f;
            _f = new Form5();
            _f.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
            Form1 _f;
            _f = new Form1();
            _f.Show();
        }
    }
}

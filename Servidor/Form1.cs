using Modelo.PN;
using System;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gerarDados_Click(object sender, EventArgs e)
        {
            Form2 _f;
            _f = new Form2();
            _f.Show();
            Hide();
        }

        private void cadastrarProdutos_Click(object sender, EventArgs e)
        {
            Form3 _f;
            _f = new Form3();
            _f.Show();
            Hide();
        }

        private void fechar_Click(object sender, EventArgs e)
        {            
            Application.Exit();
            Close();
        }
    }
}

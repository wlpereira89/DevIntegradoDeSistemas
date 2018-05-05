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
using Modelo.DAO;
namespace App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
            Form1 _f1;
            _f1 = new Form1();
            _f1.Show();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Produtos novo = new Produtos
            {
                Descricao = desc.Text,
                Preco = Convert.ToDouble(price.Value)
            };
            if (pnProdutos.novoProduto(novo))
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro no cadastro");
            }
        }

        private void deArquivo_Click(object sender, EventArgs e)
        {
            Form4 _f = new Form4();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
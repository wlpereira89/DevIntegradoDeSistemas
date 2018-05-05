using Modelo.PN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            comboBox1.DataSource = App.Global.Faturamento.listarClientesComPedido() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Close();
            Form11 _f;
            _f = new Form11();
            _f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cliente = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(' ')[0]);
            pnPedidos lista = new pnPedidos(cliente);
            listBox1.DataSource = lista.ListagemPedidos;
            label2.Text = "Valor total faturado do cliente: " + lista.ValorTotalPedidos;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (povoarBanco.gerarPedidos(Convert.ToInt32(numericUpDown1.Value)))
                MessageBox.Show("Gerados com sucesso!");
            else
                MessageBox.Show("Erro na geração");
             
        }
    }
}

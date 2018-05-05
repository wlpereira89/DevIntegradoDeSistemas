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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Close();
            Form11 _f;
            _f = new Form11();
            _f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

            }
            else if (radioButton2.Checked)
            {
                pnRelatorio relatorio = new pnRelatorio(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                listBox1.DataSource = relatorio.gerarRelatorio();
            }
            else if (radioButton3.Checked)
            {
                pnRelatorio relatorio = new pnRelatorio(Convert.ToInt32(textBox3.Text));
                listBox1.DataSource = relatorio.gerarRelatorio();
            }
            else
            {
                MessageBox.Show("Selecione uma opção de relatório");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = false;            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
        }
    }
}

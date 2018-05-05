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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void gerarFaturamento_Click(object sender, EventArgs e)
        {
            Form7 _f;
            _f = new Form7();
            _f.Show();      
        }

        private void Relatorios_Click(object sender, EventArgs e)
        {
            if (App.Global.Faturamento == null)
                MessageBox.Show("Para verificar os relatórios o faturamento deve ser fechado");
            else
            {
                Close();
                Form11 _f;
                _f = new Form11();
                _f.Show();
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Close();
            Form1 _f;
            _f = new Form1();
            _f.Show();
        }
    }
}

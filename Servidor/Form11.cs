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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void porPeriodo_Click(object sender, EventArgs e)
        {
            Close();
            Form9 _f;
            _f = new Form9();
            _f.Show();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Close();
            Form6 _f;
            _f = new Form6();
            _f.Show();
        }

        private void pedidosPorCl_Click(object sender, EventArgs e)
        {
            Close();
            Form8 _f;
            _f = new Form8();
            _f.Show();
        }
    }
}

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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("O limite para data é o dia atual");
            }
            else if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("A data final deve ser maior que a inicial");
            }
            else if((dateTimePicker1.Value.Date == DateTime.Now.Date) || (dateTimePicker1.Value.Date == dateTimePicker2.Value.Date))
            {
                MessageBox.Show("O range minimo é um dia");
            }
            else
            {
                App.Global.Faturamento = new pnFaturamento(dateTimePicker1.Value, dateTimePicker2.Value);                
                Close();                
                MessageBox.Show("Faturamento gerado com sucesso");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}

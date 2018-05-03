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
    public partial class Form4 : Form
    {
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private String arquivo;
        

        public Form4()
        {
            InitializeComponent();
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Procurar arquivos";
            dialogo.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            dialogo.Filter = "Arquivos texto (*.csv)|*.csv";
            DialogResult resposta = dialogo.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                arquivo = dialogo.FileName;                

            }
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Separador do arquivo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(211, 74);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Separador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (pnProdutos.novosProdutosCsv(arquivo, Convert.ToChar(textBox1.Text))){
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
                MessageBox.Show("Ocorreu um erro no cadastro");
            Close();
        }
    }
}

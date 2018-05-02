namespace Servidor
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.desc = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço";
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Location = new System.Drawing.Point(122, 70);
            this.price.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(120, 20);
            this.price.TabIndex = 2;
            this.price.Tag = "R$";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(122, 34);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(251, 20);
            this.desc.TabIndex = 3;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(29, 123);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(133, 23);
            this.Cadastrar.TabIndex = 4;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Voltar ao menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar a partir de csv";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deArquivo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 184);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
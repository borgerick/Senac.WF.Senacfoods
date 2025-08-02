namespace SenacFoods
{
    partial class FrmComandaCad
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            comboBoxMesa = new ComboBox();
            comboBoxCardapio = new ComboBox();
            buttonMais = new Button();
            label5 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnVoltar = new Button();
            txtTextoCardapio = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(comboBoxMesa);
            groupBox1.Controls.Add(comboBoxCardapio);
            groupBox1.Controls.Add(buttonMais);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtNomeCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(19, 65);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(310, 334);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 153);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(257, 104);
            dataGridView1.TabIndex = 16;
            // 
            // comboBoxMesa
            // 
            comboBoxMesa.FormattingEnabled = true;
            comboBoxMesa.Location = new Point(99, 72);
            comboBoxMesa.Margin = new Padding(2);
            comboBoxMesa.Name = "comboBoxMesa";
            comboBoxMesa.Size = new Size(182, 28);
            comboBoxMesa.TabIndex = 15;
            // 
            // comboBoxCardapio
            // 
            comboBoxCardapio.FormattingEnabled = true;
            comboBoxCardapio.Location = new Point(99, 107);
            comboBoxCardapio.Margin = new Padding(2);
            comboBoxCardapio.Name = "comboBoxCardapio";
            comboBoxCardapio.Size = new Size(146, 28);
            comboBoxCardapio.TabIndex = 14;
            // 
            // buttonMais
            // 
            buttonMais.BackColor = Color.FromArgb(255, 255, 128);
            buttonMais.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMais.Location = new Point(253, 107);
            buttonMais.Margin = new Padding(2);
            buttonMais.Name = "buttonMais";
            buttonMais.Size = new Size(26, 26);
            buttonMais.TabIndex = 13;
            buttonMais.Text = "+";
            buttonMais.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 107);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Cardapio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 72);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 9;
            label4.Text = "Mesa";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(168, 279);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 34);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.Location = new Point(36, 279);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 34);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(114, 24);
            txtNomeCliente.Margin = new Padding(2);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(192, 27);
            txtNomeCliente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LimeGreen;
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(txtTextoCardapio);
            panel2.Location = new Point(0, -1);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 62);
            panel2.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Location = new Point(239, 18);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(90, 27);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtTextoCardapio
            // 
            txtTextoCardapio.BackColor = Color.LimeGreen;
            txtTextoCardapio.BorderStyle = BorderStyle.None;
            txtTextoCardapio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(6, 17);
            txtTextoCardapio.Margin = new Padding(2);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(190, 27);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "Comanda";
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 424);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmComandaCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmComandaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtNomeCliente;
        private Label label1;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Button btnVoltar;
        private TextBox txtTextoCardapio;
        private ComboBox comboBoxMesa;
        private ComboBox comboBoxCardapio;
        private Button buttonMais;
        private DataGridView dataGridView1;
    }
}
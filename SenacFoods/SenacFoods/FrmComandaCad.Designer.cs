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
            comboBoxNumeroComanda = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxNumeroComanda);
            groupBox1.Controls.Add(label2);
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
            groupBox1.Location = new Point(24, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 417);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(321, 130);
            dataGridView1.TabIndex = 16;
            // 
            // comboBoxMesa
            // 
            comboBoxMesa.FormattingEnabled = true;
            comboBoxMesa.Location = new Point(124, 142);
            comboBoxMesa.Name = "comboBoxMesa";
            comboBoxMesa.Size = new Size(227, 33);
            comboBoxMesa.TabIndex = 15;
            // 
            // comboBoxCardapio
            // 
            comboBoxCardapio.FormattingEnabled = true;
            comboBoxCardapio.Location = new Point(124, 179);
            comboBoxCardapio.Name = "comboBoxCardapio";
            comboBoxCardapio.Size = new Size(182, 33);
            comboBoxCardapio.TabIndex = 14;
            // 
            // buttonMais
            // 
            buttonMais.BackColor = Color.FromArgb(255, 255, 128);
            buttonMais.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMais.Location = new Point(316, 179);
            buttonMais.Name = "buttonMais";
            buttonMais.Size = new Size(33, 33);
            buttonMais.TabIndex = 13;
            buttonMais.Text = "+";
            buttonMais.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 179);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 11;
            label5.Text = "Cardapio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 142);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Mesa";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(210, 359);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 43);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.Location = new Point(31, 359);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(122, 43);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(142, 88);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(239, 31);
            txtNomeCliente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 91);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LimeGreen;
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(txtTextoCardapio);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 77);
            panel2.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Location = new Point(299, 22);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // txtTextoCardapio
            // 
            txtTextoCardapio.BackColor = Color.LimeGreen;
            txtTextoCardapio.BorderStyle = BorderStyle.None;
            txtTextoCardapio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(8, 21);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(238, 32);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "Comanda";
            // 
            // comboBoxNumeroComanda
            // 
            comboBoxNumeroComanda.FormattingEnabled = true;
            comboBoxNumeroComanda.Location = new Point(182, 31);
            comboBoxNumeroComanda.Name = "comboBoxNumeroComanda";
            comboBoxNumeroComanda.Size = new Size(155, 33);
            comboBoxNumeroComanda.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 34);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 17;
            label2.Text = "Numero Comanda";
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 530);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
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
        private ComboBox comboBoxNumeroComanda;
        private Label label2;
    }
}
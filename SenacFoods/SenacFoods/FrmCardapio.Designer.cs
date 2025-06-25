namespace SenacFoods
{
    partial class FrmCardapio
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
            panel1 = new Panel();
            Pesquisar = new Label();
            btnVoltar = new Button();
            txtTextoCardapio = new TextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            BotaoEditar = new Button();
            BotaoExcluir = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(Pesquisar);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtTextoCardapio);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 77);
            panel1.TabIndex = 1;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.BackColor = Color.White;
            Pesquisar.ForeColor = Color.Black;
            Pesquisar.Location = new Point(278, 29);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(86, 25);
            Pesquisar.TabIndex = 5;
            Pesquisar.Text = "Pesquisar";
            // 
            // btnVoltar
            // 
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Location = new Point(759, 23);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtTextoCardapio
            // 
            txtTextoCardapio.BackColor = Color.Sienna;
            txtTextoCardapio.BorderStyle = BorderStyle.None;
            txtTextoCardapio.Font = new Font("Segoe UI", 19F);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(12, 12);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(227, 51);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "CARDAPIO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 31);
            textBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(23, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 312);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(816, 285);
            dataGridView1.TabIndex = 0;
            // 
            // BotaoEditar
            // 
            BotaoEditar.Location = new Point(753, 401);
            BotaoEditar.Name = "BotaoEditar";
            BotaoEditar.Size = new Size(112, 34);
            BotaoEditar.TabIndex = 3;
            BotaoEditar.Text = "# Editar";
            BotaoEditar.UseVisualStyleBackColor = true;
            // 
            // BotaoExcluir
            // 
            BotaoExcluir.Location = new Point(635, 401);
            BotaoExcluir.Name = "BotaoExcluir";
            BotaoExcluir.Size = new Size(112, 34);
            BotaoExcluir.TabIndex = 4;
            BotaoExcluir.Text = "X Excluir";
            BotaoExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(894, 447);
            Controls.Add(BotaoExcluir);
            Controls.Add(BotaoEditar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrnCardapio";
            Load += FrmCardapio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTextoCardapio;
        private Button btnVoltar;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button BotaoEditar;
        private Button BotaoExcluir;
        private Label Pesquisar;
        private TextBox textBox1;
    }
}
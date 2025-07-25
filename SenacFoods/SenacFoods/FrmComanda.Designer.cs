namespace SenacFoods
{
    partial class FrmComanda
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
            btnVoltar = new Button();
            txtTextoCardapio = new TextBox();
            txtPesquisar = new TextBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            groupBox1 = new GroupBox();
            btnComanda = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtTextoCardapio);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 62);
            panel1.TabIndex = 2;
            // 
            // btnVoltar
            // 
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Location = new Point(607, 18);
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
            txtTextoCardapio.BackColor = Color.Green;
            txtTextoCardapio.BorderStyle = BorderStyle.None;
            txtTextoCardapio.Font = new Font("Segoe UI", 19F);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(10, 10);
            txtTextoCardapio.Margin = new Padding(2);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(182, 43);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "COMANDA";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(301, 14);
            txtPesquisar.Margin = new Padding(2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(297, 27);
            txtPesquisar.TabIndex = 8;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(513, 321);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 27);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "X Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 128);
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(607, 321);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 27);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "# Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPesquisar);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(18, 66);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(678, 250);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.Green;
            btnComanda.ForeColor = Color.BlanchedAlmond;
            btnComanda.Location = new Point(12, 14);
            btnComanda.Margin = new Padding(2);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(94, 27);
            btnComanda.TabIndex = 5;
            btnComanda.Text = "+Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(662, 191);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 358);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmComanda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmComanda";
            Load += FrmComanda_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVoltar;
        private TextBox txtTextoCardapio;
        private Button btnExcluir;
        private Button btnEditar;
        private GroupBox groupBox1;
        private Button btnComanda;
        private DataGridView dataGridView1;
        private TextBox txtPesquisar;
    }
}
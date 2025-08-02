namespace SenacFoods
{
    partial class FrmUsuario
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
            txtPesquisa = new TextBox();
            btnVoltar = new Button();
            txtTextoCardapio = new TextBox();
            groupBox1 = new GroupBox();
            btnExcluirUsuario = new Button();
            btnAdicionarUsuario = new Button();
            btnEditarUsuario = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtTextoCardapio);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 62);
            panel1.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(196, 18);
            txtPesquisa.Margin = new Padding(2, 2, 2, 2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(297, 27);
            txtPesquisa.TabIndex = 7;
            txtPesquisa.TextChanged += txtPesquisaUsuario_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Location = new Point(607, 18);
            btnVoltar.Margin = new Padding(2, 2, 2, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(90, 27);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtTextoCardapio
            // 
            txtTextoCardapio.BackColor = Color.FromArgb(192, 64, 0);
            txtTextoCardapio.BorderStyle = BorderStyle.None;
            txtTextoCardapio.Font = new Font("Segoe UI", 19F);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(10, 10);
            txtTextoCardapio.Margin = new Padding(2, 2, 2, 2);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(182, 43);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "USUÁRIO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluirUsuario);
            groupBox1.Controls.Add(btnAdicionarUsuario);
            groupBox1.Controls.Add(btnEditarUsuario);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(22, 66);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(674, 282);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(107, 22);
            btnExcluirUsuario.Margin = new Padding(2, 2, 2, 2);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(90, 27);
            btnExcluirUsuario.TabIndex = 6;
            btnExcluirUsuario.Text = "X Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.BackColor = Color.FromArgb(192, 64, 0);
            btnAdicionarUsuario.ForeColor = Color.BlanchedAlmond;
            btnAdicionarUsuario.Location = new Point(12, 22);
            btnAdicionarUsuario.Margin = new Padding(2, 2, 2, 2);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(90, 27);
            btnAdicionarUsuario.TabIndex = 5;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.UseVisualStyleBackColor = false;
            btnAdicionarUsuario.Click += btnAdicionarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Enabled = false;
            btnEditarUsuario.Location = new Point(206, 22);
            btnEditarUsuario.Margin = new Padding(2, 2, 2, 2);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(90, 27);
            btnEditarUsuario.TabIndex = 5;
            btnEditarUsuario.Text = "# Editar";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 58);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(662, 215);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 358);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVoltar;
        private TextBox txtTextoCardapio;
        private GroupBox groupBox1;
        private Button btnAdicionarUsuario;
        private DataGridView dataGridView1;
        private TextBox txtPesquisa;
        private Button btnExcluirUsuario;
        private Button btnEditarUsuario;
    }
}
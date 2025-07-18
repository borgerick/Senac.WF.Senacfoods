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
            btnVoltar = new Button();
            txtTextoCardapio = new TextBox();
            groupBox1 = new GroupBox();
            btnAdicionarUsuario = new Button();
            dataGridView1 = new DataGridView();
            txtPesquisaUsuario = new TextBox();
            btnExcluirUsuario = new Button();
            btnEditarUsuario = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(txtPesquisaUsuario);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtTextoCardapio);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 77);
            panel1.TabIndex = 3;
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
            txtTextoCardapio.BackColor = Color.FromArgb(192, 64, 0);
            txtTextoCardapio.BorderStyle = BorderStyle.None;
            txtTextoCardapio.Font = new Font("Segoe UI", 19F);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(12, 12);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(227, 51);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "USUÁRIO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluirUsuario);
            groupBox1.Controls.Add(btnAdicionarUsuario);
            groupBox1.Controls.Add(btnEditarUsuario);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(28, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 324);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.BackColor = Color.FromArgb(192, 64, 0);
            btnAdicionarUsuario.ForeColor = Color.BlanchedAlmond;
            btnAdicionarUsuario.Location = new Point(15, 27);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(112, 34);
            btnAdicionarUsuario.TabIndex = 5;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(827, 236);
            dataGridView1.TabIndex = 0;
            // 
            // txtPesquisaUsuario
            // 
            txtPesquisaUsuario.Location = new Point(245, 23);
            txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            txtPesquisaUsuario.Size = new Size(370, 31);
            txtPesquisaUsuario.TabIndex = 7;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(139, 27);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(112, 34);
            btnExcluirUsuario.TabIndex = 6;
            btnExcluirUsuario.Text = "X Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Enabled = false;
            btnEditarUsuario.Location = new Point(257, 27);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(112, 34);
            btnEditarUsuario.TabIndex = 5;
            btnEditarUsuario.Text = "# Editar";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 447);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuario";
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
        private TextBox txtPesquisaUsuario;
        private Button btnExcluirUsuario;
        private Button btnEditarUsuario;
    }
}
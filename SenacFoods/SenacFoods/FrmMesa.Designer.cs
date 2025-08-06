namespace SenacFoods
{
    partial class FrmMesa
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
            txtFrmMesa = new TextBox();
            txtPesquisa = new TextBox();
            Mesa = new GroupBox();
            dataGridView1 = new DataGridView();
            btnEditarMesa = new Button();
            btnAdicionarMesa = new Button();
            btnExcluir = new Button();
            panel1.SuspendLayout();
            Mesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtFrmMesa);
            panel1.Controls.Add(txtPesquisa);
            panel1.Location = new Point(-6, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 78);
            panel1.TabIndex = 2;
            // 
            // btnVoltar
            // 
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Location = new Point(457, 23);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtFrmMesa
            // 
            txtFrmMesa.BackColor = Color.DarkGray;
            txtFrmMesa.BorderStyle = BorderStyle.None;
            txtFrmMesa.Font = new Font("Segoe UI", 19F);
            txtFrmMesa.ForeColor = Color.White;
            txtFrmMesa.Location = new Point(12, 12);
            txtFrmMesa.Margin = new Padding(2);
            txtFrmMesa.Name = "txtFrmMesa";
            txtFrmMesa.Size = new Size(116, 51);
            txtFrmMesa.TabIndex = 2;
            txtFrmMesa.Text = "MESA";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(149, 26);
            txtPesquisa.Margin = new Padding(2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(156, 31);
            txtPesquisa.TabIndex = 6;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // Mesa
            // 
            Mesa.Controls.Add(btnAdicionarMesa);
            Mesa.Controls.Add(btnExcluir);
            Mesa.Controls.Add(btnEditarMesa);
            Mesa.Controls.Add(dataGridView1);
            Mesa.Location = new Point(23, 82);
            Mesa.Margin = new Padding(2);
            Mesa.Name = "Mesa";
            Mesa.Padding = new Padding(2);
            Mesa.Size = new Size(556, 353);
            Mesa.TabIndex = 3;
            Mesa.TabStop = false;
            Mesa.Text = "Mesa";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 69);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(491, 206);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEditarMesa
            // 
            btnEditarMesa.BackColor = Color.FromArgb(255, 255, 128);
            btnEditarMesa.Location = new Point(157, 296);
            btnEditarMesa.Margin = new Padding(2);
            btnEditarMesa.Name = "btnEditarMesa";
            btnEditarMesa.Size = new Size(112, 39);
            btnEditarMesa.TabIndex = 10;
            btnEditarMesa.Text = "Editar";
            btnEditarMesa.UseVisualStyleBackColor = false;
            btnEditarMesa.Click += btnEditarMesa_Click;
            // 
            // btnAdicionarMesa
            // 
            btnAdicionarMesa.BackColor = Color.FromArgb(128, 255, 128);
            btnAdicionarMesa.Location = new Point(70, 15);
            btnAdicionarMesa.Margin = new Padding(2);
            btnAdicionarMesa.Name = "btnAdicionarMesa";
            btnAdicionarMesa.Size = new Size(234, 39);
            btnAdicionarMesa.TabIndex = 9;
            btnAdicionarMesa.Text = "Adicionar";
            btnAdicionarMesa.UseVisualStyleBackColor = false;
            btnAdicionarMesa.Click += btnAdicionarMesa_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(279, 296);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 39);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 448);
            Controls.Add(Mesa);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMesa";
            Load += FrmMesa_Load;
            Click += btnVoltar_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Mesa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVoltar;
        private TextBox txtFrmMesa;
        private TextBox txtPesquisa;
        private GroupBox Mesa;
        private DataGridView dataGridView1;
        private Button btnEditarMesa;
        private Button btnAdicionarMesa;
        private Button btnExcluir;
    }
}
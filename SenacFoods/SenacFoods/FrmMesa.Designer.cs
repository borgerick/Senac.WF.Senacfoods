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
            txtMesa = new TextBox();
            label1 = new Label();
            txtNumMesa = new TextBox();
            label2 = new Label();
            btnExcluir = new Button();
            label3 = new Label();
            comboBoxSitMesa = new ComboBox();
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
            panel1.Location = new Point(-5, 0);
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
            // txtFrmMesa
            // 
            txtFrmMesa.BackColor = Color.DarkGray;
            txtFrmMesa.BorderStyle = BorderStyle.None;
            txtFrmMesa.Font = new Font("Segoe UI", 19F);
            txtFrmMesa.ForeColor = Color.White;
            txtFrmMesa.Location = new Point(10, 10);
            txtFrmMesa.Margin = new Padding(2);
            txtFrmMesa.Name = "txtFrmMesa";
            txtFrmMesa.Size = new Size(182, 43);
            txtFrmMesa.TabIndex = 2;
            txtFrmMesa.Text = "MESA";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(193, 21);
            txtPesquisa.Margin = new Padding(2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(297, 27);
            txtPesquisa.TabIndex = 6;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // Mesa
            // 
            Mesa.Controls.Add(dataGridView1);
            Mesa.Location = new Point(254, 89);
            Mesa.Margin = new Padding(2);
            Mesa.Name = "Mesa";
            Mesa.Padding = new Padding(2);
            Mesa.Size = new Size(434, 259);
            Mesa.TabIndex = 3;
            Mesa.TabStop = false;
            Mesa.Text = "Mesa";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 24);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(398, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEditarMesa
            // 
            btnEditarMesa.BackColor = Color.FromArgb(255, 255, 128);
            btnEditarMesa.Location = new Point(29, 294);
            btnEditarMesa.Margin = new Padding(2);
            btnEditarMesa.Name = "btnEditarMesa";
            btnEditarMesa.Size = new Size(90, 31);
            btnEditarMesa.TabIndex = 10;
            btnEditarMesa.Text = "Editar";
            btnEditarMesa.UseVisualStyleBackColor = false;
            btnEditarMesa.Click += btnEditarMesa_Click;
            // 
            // btnAdicionarMesa
            // 
            btnAdicionarMesa.BackColor = Color.FromArgb(128, 255, 128);
            btnAdicionarMesa.Location = new Point(29, 259);
            btnAdicionarMesa.Margin = new Padding(2);
            btnAdicionarMesa.Name = "btnAdicionarMesa";
            btnAdicionarMesa.Size = new Size(187, 31);
            btnAdicionarMesa.TabIndex = 9;
            btnAdicionarMesa.Text = "Adicionar";
            btnAdicionarMesa.UseVisualStyleBackColor = false;
            btnAdicionarMesa.Click += btnAdicionarMesa_Click;
            // 
            // txtMesa
            // 
            txtMesa.Location = new Point(29, 136);
            txtMesa.Margin = new Padding(2);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(44, 27);
            txtMesa.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 113);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 11;
            label1.Text = "Mesa";
            // 
            // txtNumMesa
            // 
            txtNumMesa.Location = new Point(99, 136);
            txtNumMesa.Margin = new Padding(2);
            txtNumMesa.Name = "txtNumMesa";
            txtNumMesa.Size = new Size(117, 27);
            txtNumMesa.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 113);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 13;
            label2.Text = "Numero Pessoas";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(126, 294);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 31);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 185);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 16;
            label3.Text = "Situacao Mesa";
            // 
            // comboBoxSitMesa
            // 
            comboBoxSitMesa.ForeColor = Color.Black;
            comboBoxSitMesa.FormattingEnabled = true;
            comboBoxSitMesa.Location = new Point(29, 208);
            comboBoxSitMesa.Margin = new Padding(2);
            comboBoxSitMesa.Name = "comboBoxSitMesa";
            comboBoxSitMesa.Size = new Size(189, 28);
            comboBoxSitMesa.TabIndex = 17;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 358);
            Controls.Add(comboBoxSitMesa);
            Controls.Add(label3);
            Controls.Add(btnExcluir);
            Controls.Add(txtNumMesa);
            Controls.Add(label2);
            Controls.Add(txtMesa);
            Controls.Add(label1);
            Controls.Add(btnEditarMesa);
            Controls.Add(btnAdicionarMesa);
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
            PerformLayout();
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
        private TextBox txtMesa;
        private Label label1;
        private TextBox txtNumMesa;
        private Label label2;
        private Button btnExcluir;
        private Label label3;
        private ComboBox comboBoxSitMesa;
    }
}
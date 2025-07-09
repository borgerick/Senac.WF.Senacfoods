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
            txtTituloMesa = new TextBox();
            label1 = new Label();
            txtNumeroMesa = new TextBox();
            label2 = new Label();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 77);
            panel1.TabIndex = 2;
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
            // 
            // txtFrmMesa
            // 
            txtFrmMesa.BackColor = Color.DarkGray;
            txtFrmMesa.BorderStyle = BorderStyle.None;
            txtFrmMesa.Font = new Font("Segoe UI", 19F);
            txtFrmMesa.ForeColor = Color.White;
            txtFrmMesa.Location = new Point(12, 12);
            txtFrmMesa.Name = "txtFrmMesa";
            txtFrmMesa.Size = new Size(227, 51);
            txtFrmMesa.TabIndex = 2;
            txtFrmMesa.Text = "MESA";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(241, 26);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(370, 31);
            txtPesquisa.TabIndex = 6;
            // 
            // Mesa
            // 
            Mesa.Controls.Add(dataGridView1);
            Mesa.Location = new Point(317, 111);
            Mesa.Name = "Mesa";
            Mesa.Size = new Size(543, 324);
            Mesa.TabIndex = 3;
            Mesa.TabStop = false;
            Mesa.Text = "Mesa";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(497, 275);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditarMesa
            // 
            btnEditarMesa.BackColor = Color.FromArgb(255, 128, 128);
            btnEditarMesa.Location = new Point(165, 366);
            btnEditarMesa.Name = "btnEditarMesa";
            btnEditarMesa.Size = new Size(111, 39);
            btnEditarMesa.TabIndex = 10;
            btnEditarMesa.Text = "Editar";
            btnEditarMesa.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarMesa
            // 
            btnAdicionarMesa.BackColor = Color.FromArgb(128, 255, 128);
            btnAdicionarMesa.Location = new Point(48, 366);
            btnAdicionarMesa.Name = "btnAdicionarMesa";
            btnAdicionarMesa.Size = new Size(111, 39);
            btnAdicionarMesa.TabIndex = 9;
            btnAdicionarMesa.Text = "Adicionar";
            btnAdicionarMesa.UseVisualStyleBackColor = false;
            btnAdicionarMesa.Click += btnAdicionarMesa_Click;
            // 
            // txtTituloMesa
            // 
            txtTituloMesa.Location = new Point(48, 181);
            txtTituloMesa.Name = "txtTituloMesa";
            txtTituloMesa.Size = new Size(192, 31);
            txtTituloMesa.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 152);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 11;
            label1.Text = "Numero Mesa";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(48, 293);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(192, 31);
            txtNumeroMesa.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 264);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 13;
            label2.Text = "Numero Pessoas";
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 447);
            Controls.Add(txtNumeroMesa);
            Controls.Add(label2);
            Controls.Add(txtTituloMesa);
            Controls.Add(label1);
            Controls.Add(btnEditarMesa);
            Controls.Add(btnAdicionarMesa);
            Controls.Add(Mesa);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMesa";
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
        private TextBox txtTituloMesa;
        private Label label1;
        private TextBox txtNumeroMesa;
        private Label label2;
    }
}
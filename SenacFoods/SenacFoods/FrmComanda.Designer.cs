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
            btnExcluir = new Button();
            btnEditar = new Button();
            groupBox1 = new GroupBox();
            btnAdicionar = new Button();
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
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtTextoCardapio
            // 
            txtTextoCardapio.BackColor = Color.Green;
            txtTextoCardapio.BorderStyle = BorderStyle.None;
            txtTextoCardapio.Font = new Font("Segoe UI", 19F);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(12, 12);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(227, 51);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "COMANDA";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(641, 401);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "X Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 128);
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(759, 401);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "# Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(23, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 312);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Green;
            btnAdicionar.ForeColor = Color.BlanchedAlmond;
            btnAdicionar.Location = new Point(15, 18);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "+Comanda";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(827, 239);
            dataGridView1.TabIndex = 0;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 447);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmComanda";
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
        private Button btnExcluir;
        private Button btnEditar;
        private GroupBox groupBox1;
        private Button btnAdicionar;
        private DataGridView dataGridView1;
    }
}
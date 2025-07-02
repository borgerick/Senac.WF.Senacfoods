namespace SenacFoods
{
    partial class FrmCardapioCad
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
            panel2 = new Panel();
            btnVoltar = new Button();
            txtTextoCardapio = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            txtDescricao = new RichTextBox();
            textPreco = new TextBox();
            txtTitulo = new TextBox();
            chkPossuiPreparo = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Sienna;
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(txtTextoCardapio);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 77);
            panel2.TabIndex = 2;
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
            txtTextoCardapio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(8, 21);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(238, 32);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "Cadastro de Cardapio";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(617, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(203, 69);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.Location = new Point(617, 101);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(203, 69);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(textPreco);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(chkPossuiPreparo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(23, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 357);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "btnSalvar";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(25, 129);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(527, 88);
            txtDescricao.TabIndex = 8;
            txtDescricao.Text = "";
            // 
            // textPreco
            // 
            textPreco.Location = new Point(25, 257);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(527, 31);
            textPreco.TabIndex = 7;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(25, 63);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(527, 31);
            txtTitulo.TabIndex = 5;
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(25, 310);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(164, 29);
            chkPossuiPreparo.TabIndex = 4;
            chkPossuiPreparo.Text = "Possui preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 229);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Preço:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 101);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(894, 450);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnVoltar;
        private TextBox txtTextoCardapio;
        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox groupBox1;
        private CheckBox chkPossuiPreparo;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox txtDescricao;
        private TextBox textPreco;
        private TextBox txtTitulo;
    }
}
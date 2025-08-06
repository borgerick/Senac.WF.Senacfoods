namespace SenacFoods
{
    partial class FrmMesaCad
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
            panel2.Location = new Point(0, -2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 62);
            panel2.TabIndex = 2;
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
            txtTextoCardapio.BackColor = Color.Sienna;
            txtTextoCardapio.BorderStyle = BorderStyle.None;
            txtTextoCardapio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTextoCardapio.ForeColor = Color.White;
            txtTextoCardapio.Location = new Point(6, 17);
            txtTextoCardapio.Margin = new Padding(2);
            txtTextoCardapio.Name = "txtTextoCardapio";
            txtTextoCardapio.Size = new Size(207, 27);
            txtTextoCardapio.TabIndex = 2;
            txtTextoCardapio.Text = "CADASTRO CARDAPIO";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(494, 156);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 55);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.Location = new Point(494, 81);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(162, 55);
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
            groupBox1.Location = new Point(18, 65);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(678, 286);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "btnSalvar";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(20, 103);
            txtDescricao.Margin = new Padding(2);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(422, 71);
            txtDescricao.TabIndex = 8;
            txtDescricao.Text = "";
            // 
            // textPreco
            // 
            textPreco.Location = new Point(20, 206);
            textPreco.Margin = new Padding(2);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(422, 27);
            textPreco.TabIndex = 7;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(20, 50);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(422, 27);
            txtTitulo.TabIndex = 5;
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(20, 248);
            chkPossuiPreparo.Margin = new Padding(2);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(135, 24);
            chkPossuiPreparo.TabIndex = 4;
            chkPossuiPreparo.Text = "Possui preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 183);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Preço:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(715, 360);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmCardapioCad";
            StartPosition = FormStartPosition.CenterScreen;
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
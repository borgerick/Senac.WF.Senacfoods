namespace SenacFoods
{
    partial class FrmMesaCas
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            panel2 = new Panel();
            btnVoltar = new Button();
            txtCadastroMesa = new TextBox();
            textNumeroMesa = new TextBox();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textNumeroMesa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(23, 92);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(388, 163);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 31);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 9;
            label4.Text = "Numero Mesa";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(217, 95);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 42);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.Location = new Point(52, 95);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(122, 42);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(txtCadastroMesa);
            panel2.Location = new Point(0, -1);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 78);
            panel2.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.Location = new Point(299, 22);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // txtCadastroMesa
            // 
            txtCadastroMesa.BackColor = Color.DarkGray;
            txtCadastroMesa.BorderStyle = BorderStyle.None;
            txtCadastroMesa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCadastroMesa.ForeColor = Color.White;
            txtCadastroMesa.Location = new Point(8, 21);
            txtCadastroMesa.Margin = new Padding(2);
            txtCadastroMesa.Name = "txtCadastroMesa";
            txtCadastroMesa.Size = new Size(238, 32);
            txtCadastroMesa.TabIndex = 2;
            txtCadastroMesa.Text = "Cadastro Mesa";
            // 
            // textNumeroMesa
            // 
            textNumeroMesa.Location = new Point(165, 28);
            textNumeroMesa.Name = "textNumeroMesa";
            textNumeroMesa.Size = new Size(174, 31);
            textNumeroMesa.TabIndex = 17;
            // 
            // FrmMesaCas
            // 
            ClientSize = new Size(435, 279);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaCas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMesaCas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Button btnCancelar;
        private Button btnSalvar;
        private Panel panel2;
        private Button btnVoltar;
        private TextBox txtCadastroMesa;
        private TextBox textNumeroMesa;
    }
}
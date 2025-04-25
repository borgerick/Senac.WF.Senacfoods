namespace SenacFoods
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 619);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(337, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 619);
            panel2.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(255, 128, 0);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 20F);
            btnEntrar.ForeColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(120, 401);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(360, 61);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(255, 128, 0);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 19F);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(120, 271);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(360, 51);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "SENHA";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(255, 128, 0);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 19F);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(120, 175);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(360, 51);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 291);
            label2.Name = "label2";
            label2.Size = new Size(365, 48);
            label2.TabIndex = 1;
            label2.Text = "_______________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 195);
            label1.Name = "label1";
            label1.Size = new Size(365, 48);
            label1.TabIndex = 1;
            label1.Text = "_______________________";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(989, 619);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += this.FrmLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label2;
        private Label label1;
        private Button btnEntrar;
    }
}

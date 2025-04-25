namespace SenacFoods
{
    partial class FrmPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(34, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(32, 59);
            button1.Name = "button1";
            button1.Size = new Size(161, 150);
            button1.TabIndex = 0;
            button1.Text = "Cardápio";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(226, 59);
            button2.Name = "button2";
            button2.Size = new Size(161, 150);
            button2.TabIndex = 0;
            button2.Text = "Comanda";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(419, 59);
            button3.Name = "button3";
            button3.Size = new Size(161, 150);
            button3.TabIndex = 0;
            button3.Text = "Pedido Cozinha";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 64, 0);
            button4.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button4.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(614, 59);
            button4.Name = "button4";
            button4.Size = new Size(161, 150);
            button4.TabIndex = 0;
            button4.Text = "Usuário";
            button4.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(894, 570);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
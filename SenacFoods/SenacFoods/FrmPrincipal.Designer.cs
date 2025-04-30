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
            btnUsuario = new Button();
            btnPedidoCozinha = new Button();
            btnComanda = new Button();
            btnCardapio = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(btnUsuario);
            groupBox1.Controls.Add(btnPedidoCozinha);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(40, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(192, 64, 0);
            btnUsuario.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnUsuario.FlatAppearance.BorderSize = 2;
            btnUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnUsuario.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.FromArgb(255, 128, 0);
            btnUsuario.Location = new Point(600, 59);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(161, 150);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuário";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.BackColor = Color.Teal;
            btnPedidoCozinha.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnPedidoCozinha.FlatAppearance.BorderSize = 2;
            btnPedidoCozinha.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnPedidoCozinha.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnPedidoCozinha.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedidoCozinha.ForeColor = Color.FromArgb(255, 128, 0);
            btnPedidoCozinha.Location = new Point(405, 59);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.Size = new Size(161, 150);
            btnPedidoCozinha.TabIndex = 0;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.UseVisualStyleBackColor = false;
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.Green;
            btnComanda.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnComanda.FlatAppearance.BorderSize = 2;
            btnComanda.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnComanda.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnComanda.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComanda.ForeColor = Color.FromArgb(255, 128, 0);
            btnComanda.Location = new Point(212, 59);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(161, 150);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.Sienna;
            btnCardapio.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnCardapio.FlatAppearance.BorderSize = 2;
            btnCardapio.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnCardapio.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCardapio.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCardapio.ForeColor = Color.FromArgb(255, 128, 0);
            btnCardapio.Location = new Point(18, 59);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(161, 150);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.FlatAppearance.BorderColor = Color.Black;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ControlLightLight;
            btnFechar.Location = new Point(835, 10);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(48, 48);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Black;
            btnMinimizar.FlatAppearance.BorderColor = Color.Black;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = SystemColors.ControlLightLight;
            btnMinimizar.ImageAlign = ContentAlignment.TopCenter;
            btnMinimizar.Location = new Point(782, 11);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(48, 48);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "-";
            btnMinimizar.TextAlign = ContentAlignment.TopCenter;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(894, 447);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
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
        private Button btnCardapio;
        private Button btnUsuario;
        private Button btnPedidoCozinha;
        private Button btnComanda;
        private Button btnFechar;
        private Button btnMinimizar;
    }
}
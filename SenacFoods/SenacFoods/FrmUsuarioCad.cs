using System.Drawing.Text;

namespace SenacFoods
{
    public partial class FrmUsuarioCad : Form
    {
        public FrmUsuarioCad()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            AtualizaUsuario();
        }

        private void AtualizaUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text) ||
                string.IsNullOrWhiteSpace(comboBoxPerfilUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtValidaSenha.Text)
                || txtSenha.Text != txtValidaSenha.Text
                || txtSenha.Text.Length < 6
                || txtValidaSenha.Text.Length < 6
                || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))

                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)

             if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSenha.Text != txtValidaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            {

            }
            using (var bd = new ComandaDBContext())
            {
                // Captura os dados da tela
                string nome = txtNomeCompleto.Text;
                string ddd = txtDDD.Text;
                string celular = txtCelular.Text;
                string tipousuario = comboBoxPerfilUsuario.Text;
                string email = txtEmail.Text;
                string nomeusuario = txtUsuario.Text;
                string senha = txtSenha.Text;
                string validasenha = txtValidaSenha.Text;
                // Cria um novo usuário
                var usuario = new Usuario
                {
                    Nome = nome,
                    //DDD = ddd,
                    //Celular = celular,
                    //TipoUsuario = tipousuario,
                    Email = email,
                    //NomeUsuario = nomeusuario,
                    Senha = senha
                    //ValidaSenha = validasenha,
                };
                // Adiciona o usuário ao banco de dados
                bd.Usuarios.Add(usuario);
                bd.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
        }


            private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPerfilUsuario.Items.Add("Garçom");
            comboBoxPerfilUsuario.Items.Add("Administrador");
            comboBoxPerfilUsuario.Items.Add("Cozinha");
        }
    }
}

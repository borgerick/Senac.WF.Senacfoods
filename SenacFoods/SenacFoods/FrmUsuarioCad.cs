namespace SenacFoods
{
    public partial class FrmUsuarioCad : Form
    {
        private Usuario _usuarioItem; // variável para armazenar o usuário selecionado

        public FrmUsuarioCad()
        {
            InitializeComponent();// inicializa o formulário sem usuário selecionado
        }

        public FrmUsuarioCad(Usuario usuarioItem)
        {
            _usuarioItem = usuarioItem; // inicializa o cardápio selecionado
            InitializeComponent();

            CarregarDadosDaTela();
        }
        private void CarregarDadosDaTela() // método para carregar os dados do usuário na tela
        {
            if (_usuarioItem == null)
            {
                txtNomeCompleto.Text = _usuarioItem.Nome;
                txtEmail.Text = _usuarioItem.Email;
                txtUsuario.Text = _usuarioItem.NomeUsuario;
                txtSenha.Text = _usuarioItem.Senha;
                txtValidaSenha.Text = _usuarioItem.ValidaSenha;
                comboBoxPerfilUsuario.Text = _usuarioItem.TipoUsuario;
            }
        }
        private void btnSalvarUsuario_Click(object sender, EventArgs e) // evento do botão Salvar Usuário
        {
            if (_usuarioItem == null)
            {
                SalvarUsuario();
            }
            else
            {
                AtualizaUsuario();
            }
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

                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                    DDD = ddd,
                    Celular = celular,
                    TipoUsuario = tipousuario,
                    Email = email,
                    NomeUsuario = nomeusuario,
                    Senha = senha,
                    ValidaSenha = validasenha,
                };
                // Adiciona o usuário ao banco de dados
                bd.Usuarios.Add(usuario);
                bd.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
        }


        private void SalvarUsuario()
        {
            using (var banco = new ComandaDBContext()) // conecta com banco
            {
                string nome = txtNomeCompleto.Text;
                string ddd = txtDDD.Text;
                string celular = txtCelular.Text;
                string tipousuario = comboBoxPerfilUsuario.Text;
                string email = txtEmail.Text;
                string nomeusuario = txtUsuario.Text;
                string senha = txtSenha.Text;
                string validasenha = txtValidaSenha.Text;
                // Verifica se os campos obrigatórios estão preenchidos
                if (string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(tipousuario) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(nomeusuario) ||
                    string.IsNullOrWhiteSpace(senha) ||
                    string.IsNullOrWhiteSpace(validasenha)
                    || senha != validasenha
                    || senha.Length < 6
                    || validasenha.Length < 6
                    || !email.Contains("@") || !email.Contains(".com"))
                {
                    MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (senha.Length < 6)
                {
                    MessageBox.Show("A senha deve ter no mínimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (senha != validasenha)
                {
                    MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Cria um novo usuário
                var usuario = new Usuario
                {
                    Nome = nome,
                    DDD = ddd,
                    Celular = celular,
                    TipoUsuario = tipousuario,
                    Email = email,
                    NomeUsuario = nomeusuario,
                    Senha = senha,
                    ValidaSenha = validasenha,
                };

                // Adiciona o usuário ao banco de dados
                banco.Usuarios.Add(usuario);
                banco.SaveChanges();
            }
            // Exibe mensagem de sucesso
            MessageBox.Show("Usuário cadastrado!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close(); // fecha o formulário após salvar o usuário
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Certeza que deseja sair sem salvar?",
                "OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
    }
}



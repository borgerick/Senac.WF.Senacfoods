namespace SenacFoods
{
    public partial class FrmUsuarioCad : Form
    {
        private Usuario _usuarioItem;
        public FrmUsuarioCad()
        {
            InitializeComponent();
        }

        public FrmUsuarioCad(Usuario usuarioItem)
        {
            _usuarioItem = usuarioItem;
            InitializeComponent();

            CarregarDadosDaTela();
        }
        private void CarregarDadosDaTela()
        {
            if (_usuarioItem != null)
            {
                txtNomeCompleto.Text = _usuarioItem.Nome;
                txtDDD.Text = _usuarioItem.DDD;
                txtCelular.Text = _usuarioItem.Celular;
                txtUsuario.Text = _usuarioItem.NomeUsuario;
                txtSenha.Text = _usuarioItem.Senha;
                txtValidaSenha.Text = _usuarioItem.ValidaSenha;
                comboBoxPerfilUsuario.Text = _usuarioItem.TipoUsuario;
                chkUsuarioAtivo.Checked = _usuarioItem.Ativo;
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
            if (!ValidarCampos()) // Verifica se os campos estão preenchidos corretamente
                return;

            using (var bd = new ComandaDBContext())
            {
                // Captura os dados da tela
                string nome = txtNomeCompleto.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                bool ativo = chkUsuarioAtivo.Checked;
                string ddd = txtDDD.Text;
                string celular = txtCelular.Text;
                string tipousuario = comboBoxPerfilUsuario.Text;
                string nomeusuario = txtUsuario.Text;
                string validasenha = txtValidaSenha.Text;
                // Cria um novo usuário
                var Usuario = bd.Usuarios.First(x => x.Id == _usuarioItem.Id);
                Usuario.Nome = nome;
                Usuario.Email = email;
                Usuario.Senha = senha;
                Usuario.Ativo = ativo;
                Usuario.DDD = ddd;
                Usuario.Celular = celular;
                Usuario.TipoUsuario = tipousuario;
                Usuario.NomeUsuario = nomeusuario;
                Usuario.ValidaSenha = validasenha;

                // Adiciona o usuário ao banco de dados
                bd.Usuarios.Update(Usuario);
                bd.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void SalvarUsuario()
        {
            if (!ValidarCampos()) // Verifica se os campos estão preenchidos corretamente
                return;

            using (var banco = new ComandaDBContext()) // conecta com banco
            {
                string nome = txtNomeCompleto.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                bool ativo = chkUsuarioAtivo.Checked;
                string ddd = txtDDD.Text;
                string celular = txtCelular.Text;
                string tipousuario = comboBoxPerfilUsuario.Text;
                string nomeusuario = txtUsuario.Text;
                string validasenha = txtValidaSenha.Text;
                // Cria um novo usuário
                var usuario = new Usuario
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                    Ativo = ativo,
                    DDD = ddd,
                    Celular = celular,
                    TipoUsuario = tipousuario,
                    NomeUsuario = nomeusuario,
                    ValidaSenha = validasenha,
                };

                // Adiciona o usuário ao banco de dados
                banco.Usuarios.Add(usuario);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário cadastrado!",
               "Sucesso",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            this.Close();
        }
        private bool ValidarCampos()
        {
            string nome = txtNomeCompleto.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;
            string validaSenha = txtValidaSenha.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Nome é obrigatório.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtNomeCompleto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("O campo E-mail é obrigatório.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve conter no mínimo 6 caracteres.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }

            if (senha != validaSenha)
            {
                MessageBox.Show("As senhas não coincidem.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtValidaSenha.Focus();
                return false;
            }

            return true;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuarioCad_Load(object sender, EventArgs e)
        {
            CarregarPerfis();
        }

        private void CarregarPerfis()
        {
            comboBoxPerfilUsuario.Items.Clear(); // limpa qualquer valor anterior

            comboBoxPerfilUsuario.Items.Add("admin");
            comboBoxPerfilUsuario.Items.Add("garcom");
            comboBoxPerfilUsuario.Items.Add("funcionario");

            comboBoxPerfilUsuario.SelectedIndex = 0; // seleciona o primeiro por padrão
        }
    }
}



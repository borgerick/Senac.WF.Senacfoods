namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        string _nomeUsuario;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidarLogin(txtLogin.Text, txtSenha.Text);
            if (loginValido)
            {
                //oculta tela de login
                this.Hide();
                //criar uma instancia de FrmPrincipal
                var frmPrincipal = new FrmPrincipal(_nomeUsuario, txtSenha.Text);
                //exibe a tela principal
                frmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            //conecta com o banco de dados
            using (var banco = new ComandaDBContext())
            {
                //consultar a tabela usuario
                var usuario = banco
                                .Usuarios
                                .FirstOrDefault(u => u.Email == nome.ToLower() && u.Senha == senha);
                if (usuario is not null)
                    usuarioValido = true; //se o usuario for diferente de nulo, o usuario é valido
                _nomeUsuario = usuario.Nome;
            }

            //SE nome é igual a admin e senha é igual a 123
            if (usuarioValido)
            {   //Retorna Verdadeiro
                return true;
            }
            else
            { //Exibe uma mensagem de erro
            MessageBox.Show("Login ou senha inválidos");
                return false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha tela de login
            Close();
            //Encerra o aplicativo
            Application.Exit();
        }
    }
}

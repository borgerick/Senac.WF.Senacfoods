namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
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
                var frmPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                //exibe a tela principal
                frmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string nome, string senha)
        {       //SE nome é igual a admin e senha é igual a 123
            if (nome == "admin" && senha == "123")
            {   //Retorna Verdadeiro
                return false;
            }
            else
            { //Exibe uma mensagem de erro
            MessageBox.Show("Login ou senha inválidos");
                return true;
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

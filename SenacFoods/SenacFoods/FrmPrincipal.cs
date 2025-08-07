namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            //exibe o nome do usuario na tela principal
            lblMensagem.Text = "Bem vindo(a) " + nome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //fechar a tela principal
            Close();
            //cri uma intancia de tela de login
            var frmLogin = new FrmLogin();
            //exibe a tela de login
            frmLogin.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            //criar uma variavel
            var frmCardapio = new FrmCardapio();
            //Exibe a tela de cardapio com estilo modal (não consegue sair sem clicar em alguma das opções)
            frmCardapio.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            //criar uma variavel
            var frmComanda = new FrmComanda();
            //Exibe a tela com estilo modal (não consegue sair sem clicar em alguma das opções)
            frmComanda.ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            //criar uma variavel
            var frmPedidoCozinha = new FrmPedidoCozinha();
            //Exibe a tela com estilo modal (não consegue sair sem clicar em alguma das opções)
            frmPedidoCozinha.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var frmUsuario = new FrmUsuario();//criar uma variavel
            frmUsuario.ShowDialog();
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            //criar uma variavel
            var frmMesa = new FrmMesa();
            //Exibe a tela com estilo modal (não consegue sair sem clicar em alguma das opções)
            frmMesa.ShowDialog();
        }
    }
}

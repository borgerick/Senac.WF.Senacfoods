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
            //oculta tela de login
            this.Hide();
            //criar uma instancia de FrmPrincipal
            var frmPrincipal = new FrmPrincipal();
            //exibe a tela principal
            frmPrincipal.Show();
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

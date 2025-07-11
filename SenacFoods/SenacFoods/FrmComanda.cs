

namespace SenacFoods
{
    public partial class FrmComanda : Form
    {
        public FrmComanda()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //fechar a tela principal
            Close();
            //cri uma intancia de tela de login
            var frmPrincipal = new FrmPrincipal("","");
            //exibe a tela de login
            frmPrincipal.Show();
        }
    }
}

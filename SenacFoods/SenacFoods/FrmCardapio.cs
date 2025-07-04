namespace SenacFoods
{
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //fechar a tela principal
            Close();
            //cri uma intancia de tela de login
            var frmPrincipal = new FrmPrincipal("", "");
            //exibe a tela de login
            frmPrincipal.Show();
        }
        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            //conectar ao banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consulta a tabela CardapioItem
                var cardapios = bd.CardapioItens.AsQueryable();
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
                                                     c.Descricao.Contains(txtPesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios.ToList();
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // chamar o metodo buscar cardapio
            BuscarCardapio();
        }


    }
}

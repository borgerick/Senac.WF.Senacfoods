namespace SenacFoods
{
    public partial class FrmCardapio : Form
    {
        CardapioItem? cardapioSelecionado;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar o cardapio selecionado
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled =true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                //abrir formulario de edicao
                var banana = new FrmCardapioCad(cardapioSelecionado);
                banana.ShowDialog();
                BuscarCardapio();//atualizar lista de cardaio
                cardapioSelecionado = null;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
                using (var bd = new ComandaDBContext())

                {
                    bd.CardapioItens.Remove(cardapioSelecionado);
                    bd.SaveChanges();

                    MessageBox.Show("Cardápio excluído com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    BuscarCardapio(); //atualizar lista de cardapio
                    cardapioSelecionado = null;
            }
        }
        

       
    }
}

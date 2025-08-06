namespace SenacFoods
{
    public partial class FrmCardapio : Form
    {
        Mesatem? cardapioSelecionado;
        public FrmCardapio()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();//fechar a tela principal
            var frmPrincipal = new FrmPrincipal("", "");//cria uma intancia de tela de login
            frmPrincipal.Show();//exibe a tela de login
        }
        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            using (var bd = new ComandaDBContext()) //conectar ao banco de dados
            {
                //consulta a tabela CardapioItem
                var cardapios = bd.CardapioItens.AsQueryable();
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
                                                     c.Descricao.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = cardapios.ToList();//popular o grid com a tabela consultada
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmMesaCad().ShowDialog();
            BuscarCardapio(); //atualizar lista de cardapio
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarCardapio();//atualizar lista de cardapio com base na pesquisa
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar o cardapio selecionado
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesatem;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                var banana = new FrmMesaCad(cardapioSelecionado);//abrir formulario de edicao
                banana.ShowDialog();// exibe o formulário de edição
                BuscarCardapio();//atualizar lista de cardaio
                cardapioSelecionado = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
                using (var bd = new ComandaDBContext())

                {
                    bd.CardapioItens.Remove(cardapioSelecionado);//remover o usuário selecionado
                    bd.SaveChanges();//salvar as alterações no banco de dados

                }
            MessageBox.Show("Cardápio excluído com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            BuscarCardapio(); //atualizar lista de cardapio
            cardapioSelecionado = null;
        }
    }
}

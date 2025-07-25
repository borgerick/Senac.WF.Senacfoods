namespace SenacFoods
{
    public partial class FrmComanda : Form
    {
        Comanda? comandaSelecionada;
        public FrmComanda()
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
        private void FrmComanda_Load(object sender, EventArgs e)
        {
            BuscarComandas();
        }

        private void BuscarComandas()
        {
            using (var bd = new ComandaDBContext()) //conectar ao banco de dados
            {
                //consulta a tabela Comanda
                var comandas = bd.Comandas.AsQueryable();
                if (!string.IsNullOrWhiteSpace(txtPesquisar.Text))
                {
                    comandas = comandas.Where(c => c.Nome.Contains(txtPesquisar.Text) ||
                                                    c.Descricao.Contains(txtPesquisar.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = comandas.ToList();
            }


        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComandaCad().ShowDialog();
            BuscarComandas(); //atualizar lista de comandas
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarComandas(); //atualizar lista de comandas com base na pesquisa
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar a comanda selecionada
                comandaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Comanda;
                btnEditar.Enabled = true;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (comandaSelecionada != null)
            {
                var comandasEditar = new FrmComanda(comandaSelecionada);//abrir formulario de edicao
                comandasEditar.ShowDialog();// exibe o formulário de edição
                BuscarComandas();//atualizar lista de cardaio
                comandaSelecionada = null;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (comandaSelecionada != null)
            {
                //excluir a comanda selecionada
                using (var bd = new ComandaDBContext())
                {
                    bd.Comandas.Remove(comandaSelecionada);
                    bd.SaveChanges();
                }
                BuscarComandas(); //atualizar lista de comandas
            }
        }
    }
 }

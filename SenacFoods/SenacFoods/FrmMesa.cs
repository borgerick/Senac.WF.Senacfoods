namespace SenacFoods
{
    public partial class FrmMesa : Form

    {
        Mesa? SelecionarMesa;
        public FrmMesa()
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
        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            //conectar ao banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consulta a tabela Mesa
                var mesas = bd.Mesas.AsQueryable();

                int.TryParse(txtNumeroMesa.Text, out int numeromesa); // converte o texto do campo txtNumeroMesa para um inteiro
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    mesas = mesas.Where(c => c.NumeroMesa == numeromesa); //
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = mesas.ToList();
            }
        }

        private void btnAdicionarMesa_Click(object sender, EventArgs e)
        {
            SalvarMesa(); // chama o método para salvar a mesa
            BuscarMesa(); // chama o método para buscar as mesas atualizadas
        }

        private void SalvarMesa() // método para salvar o cardápio
        {
            // conectar
            using (var banco = new ComandaDBContext())
            {
                // captar os dados da tela

                int.TryParse(txtNumeroMesa.Text, out int numeromesa);

                // criar um novo cardapio   
                var mesa = new Mesa
                {

                    NumeroMesa = numeromesa
                };
                // adicionar o cardapio
                banco.Mesas.Add(mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            //fechar a tela principal
            Close();
            //cri uma intancia de tela de login
            var frmPrincipal = new FrmPrincipal("", "");
            //exibe a tela de login
            frmPrincipal.Show();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (SelecionarMesa != null)
            {
                // var confirmacao = MessageBox.Show("Deseja realmente excluir o usuário selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                using (var bd = new ComandaDBContext())
                {
                    bd.Mesas.Remove(SelecionarMesa); //remover o usuário selecionado
                    bd.SaveChanges(); //salvar as alterações no banco de dados
                }
                MessageBox.Show("Usuário excluído com sucesso!",
                               "Sucesso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                BuscarMesa(); //atualizar lista de usuários após exclusão
                SelecionarMesa = null; //limpar a seleção do usuário
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado para exclusão.",
                 "Aviso",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                SelecionarMesa = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;//pegar a mesa selecionada
                btnEditarMesa.Enabled = true; //habilitar o botão de editar mesa
            }
            
        }
    }
}


namespace SenacFoods
{
    public partial class FrmCardapioCad : Form
    {
        private CardapioItem _cardapioItem;

        

        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(CardapioItem cardapioItem)
        { 
            _cardapioItem = cardapioItem; // inicializa o cardápio selecionado
            InitializeComponent();

            CarregarDadosDaTela();

        }
        private void CarregarDadosDaTela() // método para carregar os dados do cardápio na tela
        {
            if (_cardapioItem != null)
            {
                txtTitulo.Text = _cardapioItem.Titulo;
                txtDescricao.Text = _cardapioItem.Descricao;
                textPreco.Text = _cardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _cardapioItem.PossuiPreparo;
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e) // evento do botão Salvar
        {
            if (_cardapioItem == null)
            {
                SalvarCardapio();

            }
            else
            {
                AtualizarCardapio();
            }
        }


        private void AtualizarCardapio()
        {
            using(var bd = new ComandaDBContext())
            {
                //captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(textPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                //atualizar o cardapio
                var cardapioItem = bd.CardapioItens.First(x => x.Id == _cardapioItem.Id);
                cardapioItem.Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuiPreparo;
                //salvar as alterações no banco
                bd.CardapioItens.Update(cardapioItem);
                bd.SaveChanges();

                MessageBox.Show("Cardápio excluído com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void SalvarCardapio() // método para salvar o cardápio
        {
            // conectar
            using (var banco = new ComandaDBContext())
            {
                // captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(textPreco.Text, out decimal preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                // criar um novo cardapio
                var cardapio = new CardapioItem
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                // adicionar o cardapio
                banco.CardapioItens.Add(cardapio);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardápio salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

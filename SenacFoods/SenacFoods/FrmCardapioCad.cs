namespace SenacFoods
{
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(CardapioItem cardapioItem)
        { 
            InitializeComponent(); 
        }

        private void btnSalvar_Click_1(object sender, EventArgs e) // evento do botão Salvar
        {
            SalvarCardapio(); // chama o método para salvar o cardápio
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

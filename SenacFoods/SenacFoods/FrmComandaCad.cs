namespace SenacFoods
{
    public partial class FrmComandaCad : Form
    {
        private ComandaItem _comandaItem;
        public FrmComandaCad()
        {
            InitializeComponent();
        }

        public FrmComandaCad(ComandaItem comandaItem)
        {
            _comandaItem = comandaItem;
            InitializeComponent();

            CarregarDadosDaTelaComanda();
        }
        private void CarregarDadosDaTelaComanda() // método para carregar os dados da comanda na tela
        {
            //if (_comandaItem != null)
            //{
            //    txtNumeroComanda.Text = _comandaItem.NumeroComanda.ToString();
            //    txtDataHoraAbertura.Text = _comandaItem.DataHoraAbertura.ToString("g");
            //    txtValorTotal.Text = _comandaItem.ValorTotal.ToString("F2");
            //    chkComandaFechada.Checked = _comandaItem.ComandaFechada;
            //}
        }
        private void btnSalvar_Click(object sender, EventArgs e) // evento do botão Salvar
        {

        }
        private void AtualizarComanda()
        {
            using (var bd = new ComandaDBContext())
            {
                //captar os dados da tela
                //int.TryParse(txtNumeroComanda.Text, out var numeroComanda);
                //DateTime.TryParse(txtDataHoraAbertura.Text, out var dataHoraAbertura);
                //decimal.TryParse(txtValorTotal.Text, out var valorTotal);
                //bool comandaFechada = chkComandaFechada.Checked;

                ////atualizar a comanda
                //var comandaItem = bd.ComandaItens.First(x => x.Id == _comandaItem.Id);
                //comandaItem.NumeroComanda = numeroComanda;
                //comandaItem.DataHoraAbertura = dataHoraAbertura;
                //comandaItem.ValorTotal = valorTotal;
                //comandaItem.ComandaFechada = comandaFechada;

                //// salvar as alterações no banco de dados
                //bd.SaveChanges();

                //MessageBox.Show("Comanda atualizada com sucesso!", 
                //                "Sucesso", 
                //                MessageBoxButtons.OK, 
                //                MessageBoxIcon.Information);
                //this.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show
                            ("Deseja Cancelar?.", 
                            "Cancelada", 
                            MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Information);
            if(resultado == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}

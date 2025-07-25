
namespace SenacFoods
{
    public partial class FrmComandaCad : Form
    {
        private ComandaItem _comandaItem;
        public FrmComandaCad()
        {
            InitializeComponent();
            buscarmesas();
        }

        private void buscarmesas()
        {
            
           // comboBoxMesa.DataSource = 
        }

        public FrmComandaCad(ComandaItem comandaItem)
        {
            _comandaItem = comandaItem; // inicializa o cardápio selecionado
            InitializeComponent();

            CarregarDadosDaTelaComanda();
        }
        private void CarregarDadosDaTelaComanda() // método para carregar os dados da comanda na tela
        {
            //if (_comandaItem != null)
            //{
              ///  txtNumeroComanda.Text = _comandaItem.NumeroComanda.ToString();
               // txtDataHoraAbertura.Text = _comandaItem.DataHoraAbertura.ToString("g");
              //  txtValorTotal.Text = _comandaItem.ValorTotal.ToString("F2");
              //  chkComandaFechada.Checked = _comandaItem.ComandaFechada;
           // }
        }
    }
}

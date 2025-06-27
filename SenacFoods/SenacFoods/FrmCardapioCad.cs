using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            SalvarCardapio();
        }

        private void SalvarCardapio()
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
                var cardapio = new CardapioItem{
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                // adicionar o cardapio
                banco.CardapioItens.Add(cardapio);
                banco.SaveChanges();
            }
    }
}

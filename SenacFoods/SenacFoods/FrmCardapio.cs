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
                var cardapios = bd.CardapioItens.ToList();
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
        }
    }
}

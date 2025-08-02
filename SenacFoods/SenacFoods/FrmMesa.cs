namespace SenacFoods
{
    public partial class FrmMesa : Form
    {
        Mesa? SelecionarMesa;

        public FrmMesa()
        {
            InitializeComponent();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            CarregarPerfis();
            BuscarMesa();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var frmPrincipal = new FrmPrincipal("", "");
            frmPrincipal.Show();
        }

        private void BuscarMesa()
        {
            using (var bd = new ComandaDBContext())
            {
                var mesas = bd.Mesas.AsQueryable();

                int.TryParse(txtNumMesa.Text, out int numeromesa);
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    mesas = mesas.Where(c => c.NumeroMesa == numeromesa);
                }

                dataGridView1.DataSource = mesas.ToList();
            }
        }

        private void btnAdicionarMesa_Click(object sender, EventArgs e)
        {
            SalvarMesa();
            BuscarMesa();
        }

        private void SalvarMesa()
        {
            if (!ValidarCampos())
                return;

            int.TryParse(txtMesa.Text, out int numeroMesa);
            int.TryParse(txtNumMesa.Text, out int numPessoasMesa);
            string situacaoTexto = comboBoxSitMesa.Text;
            int situacaoMesa = situacaoTexto == "livre" ? 0 :
                               situacaoTexto == "ocupada" ? 1 : -1;

            using (var banco = new ComandaDBContext())
            {
                if (SelecionarMesa == null)
                {
                    var novaMesa = new Mesa
                    {
                        NumeroMesa = numeroMesa,
                        NumPessoasMesa = numPessoasMesa,
                        SituacaoMesa = situacaoMesa
                    };

                    banco.Mesas.Add(novaMesa);
                }
                else
                {
                    var mesa = banco.Mesas.First(x => x.Id == SelecionarMesa.Id);
                    mesa.NumeroMesa = numeroMesa;
                    mesa.NumPessoasMesa = numPessoasMesa;
                    mesa.SituacaoMesa = situacaoMesa;

                    banco.Mesas.Update(mesa);
                }

                banco.SaveChanges();
            }

            MessageBox.Show("Mesa salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
            SelecionarMesa = null;
            BuscarMesa();
        }

        private bool ValidarCampos()
        {
            string mesa = txtMesa.Text.Trim();
            string numpessoasmesa = txtNumMesa.Text.Trim();

            if (string.IsNullOrWhiteSpace(mesa))
            {
                MessageBox.Show("O campo MESA é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMesa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(numpessoasmesa))
            {
                MessageBox.Show("O campo NUMERO PESSOAS é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumMesa.Focus();
                return false;
            }
            return true;
        }

        private void LimparCampos()
        {
            txtMesa.Clear();
            txtNumMesa.Clear();
            comboBoxSitMesa.SelectedIndex = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (SelecionarMesa != null)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir essa mesa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    using (var bd = new ComandaDBContext())
                    {
                        bd.Mesas.Remove(SelecionarMesa);
                        bd.SaveChanges();
                    }
                    MessageBox.Show("Mesa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BuscarMesa();
                    SelecionarMesa = null;
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma mesa selecionada para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelecionarMesa = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;

                if (SelecionarMesa != null)
                {
                    txtMesa.Text = SelecionarMesa.NumeroMesa.ToString();
                    txtNumMesa.Text = SelecionarMesa.NumPessoasMesa.ToString();

                    switch (SelecionarMesa.SituacaoMesa)
                    {
                        case 0: comboBoxSitMesa.Text = "livre"; break;
                        case 1: comboBoxSitMesa.Text = "ocupada"; break;
                        default: comboBoxSitMesa.Text = "-"; break;
                    }

                    btnEditarMesa.Enabled = true;
                }
            }
        }

        private void CarregarPerfis()
        {
            comboBoxSitMesa.Items.Clear();
            comboBoxSitMesa.Items.Add("livre");
            comboBoxSitMesa.Items.Add("ocupada");
            comboBoxSitMesa.Items.Add("-");
            comboBoxSitMesa.SelectedIndex = 0;
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            if (SelecionarMesa != null)
            {
                MessageBox.Show("Edite os dados da mesa nos campos acima e clique em 'Salvar'.", "Editar Mesa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

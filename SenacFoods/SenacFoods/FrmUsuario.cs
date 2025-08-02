namespace SenacFoods
{
    public partial class FrmUsuario : Form
    {
        Usuario? usuarioSelecionado;
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var frmPrincipal = new FrmPrincipal("", "");
            frmPrincipal.Show();
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void BuscarUsuarios()
        {
            using (var bd = new ComandaDBContext()) //conectar ao banco de dados
            {
                //consulta a tabela Usuario
                var usuarios = bd.Usuarios.AsQueryable();//consulta a tabela Usuario
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    usuarios = usuarios.Where(u => u.Nome.Contains(txtPesquisa.Text) ||
                                                     u.Email.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = usuarios.ToList();
            }
        }
        private void btnAdicionarUsuario_Click(object sender, EventArgs e) //evento do botão Adicionar Usuário
        {
            new FrmUsuarioCad().ShowDialog();
            BuscarUsuarios();
        }
        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e) //evento do campo de pesquisa
        {
            BuscarUsuarios();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //evento do clique na célula do grid
        {
            if (e.RowIndex >= 0)
            {
                //pegar o usuário selecionado
                usuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditarUsuario.Enabled = true; //habilitar o botão de editar usuário
            }

        }
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                var abreEdicao = new FrmUsuarioCad(usuarioSelecionado);
                abreEdicao.ShowDialog();
                BuscarUsuarios();
                usuarioSelecionado = null;
            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
                using (var bd = new ComandaDBContext())

                {
                    bd.Usuarios.Remove(usuarioSelecionado);
                    bd.SaveChanges();
                }
            MessageBox.Show("Usuário excluído com sucesso!",
                           "Sucesso",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            BuscarUsuarios();
            usuarioSelecionado = null;
        }
    }
}
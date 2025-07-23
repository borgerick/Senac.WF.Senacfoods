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
            //fechar a tela principal
            Close();
            //cri uma intancia de tela de login
            var frmPrincipal = new FrmPrincipal("", "");
            //exibe a tela de login
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
                var usuarios = bd.Usuarios.AsQueryable();//consulta a tabela Usuario
                if (!string.IsNullOrWhiteSpace(txtPesquisaUsuario.Text))
                {
                    usuarios = usuarios.Where(u => u.Nome.Contains(txtPesquisaUsuario.Text) ||
                                                     u.Email.Contains(txtPesquisaUsuario.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = usuarios.ToList();
            }
        }
        private void btnAdicionarUsuario_Click(object sender, EventArgs e) //evento do botão Adicionar Usuário
        {
            new FrmUsuarioCad().ShowDialog();
            BuscarUsuarios(); //atualizar lista de usuários
        }
        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e) //evento do campo de pesquisa
        {
            BuscarUsuarios(); //atualizar lista de usuários com base na pesquisa
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
                var abreEdicao = new FrmUsuarioCad(usuarioSelecionado); //criar uma instância do formulário de edição
                abreEdicao.ShowDialog(); //exibir o formulário de edição
                BuscarUsuarios(); //atualizar lista de usuários após edição
                usuarioSelecionado = null; //limpar a seleção do usuário

            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if(usuarioSelecionado != null)
            {
                var confirmacao = MessageBox.Show("Deseja realmente excluir o usuário selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    using (var bd = new ComandaDBContext())
                    {
                        bd.Usuarios.Remove(usuarioSelecionado); //remover o usuário selecionado
                        bd.SaveChanges(); //salvar as alterações no banco de dados

                        MessageBox.Show("Usuário excluído com sucesso!",
                                   "Sucesso",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                        BuscarUsuarios(); //atualizar lista de usuários após exclusão
                        usuarioSelecionado = null; //limpar a seleção do usuário
                    }
                }
            }
        }
    

}

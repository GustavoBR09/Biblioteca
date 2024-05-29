namespace Biblioteca
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ButtonCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastroClientes form = new FormCadastroClientes();
            form.ShowDialog();
        }

        private void ButtonCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionarios form = new FormCadastroFuncionarios();
            form.ShowDialog();
        }

        private void ButtonCadastroLivro_Click(object sender, EventArgs e)
        {
            FormCadastroLivros form = new FormCadastroLivros();
            form.ShowDialog();
        }
    }
}
using Biblioteca.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca
{
    public partial class FormPrincipal : Form
    {
        private BibliotecaDBContext? context;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            context = new BibliotecaDBContext();
            context.Database.EnsureCreated();
            context.Clientes.Load();
            context.Emprestimos.Load();
            context.Enderecos.Load();
            context.Funcionarios.Load();
        }

        private void ButtonCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadastroClientes form = new FormCadastroClientes(context);
            form.ShowDialog();
        }

        private void ButtonCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionarios form = new FormCadastroFuncionarios(context);
            form.ShowDialog();
        }

        private void ButtonCadastroLivro_Click(object sender, EventArgs e)
        {
            FormCadastroLivros form = new FormCadastroLivros();
            form.ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            context?.Dispose();
            context = null;
        }
    }
}
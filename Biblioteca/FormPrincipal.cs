using Biblioteca.Dominio.Entidades;
using Biblioteca.Infra.Data.Context;
using Biblioteca.Infra.Data.Interfaces;
using Biblioteca.Infra.Data.Repositories;
using Biblioteca.ViewModels;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Linq.Expressions;

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
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Clientes.Load();
            context.Emprestimos.Load();
            context.Enderecos.Load();
            context.Funcionarios.Load();
            context.Livros.Load();

            CarregaDadosEmprestimo();

        }

        public void CarregaDadosEmprestimo()
        {
            LivroRepository livroRepository = new LivroRepository(context);
            Expression<Func<Livro, bool>> expression = l => l.QuantidadeDisponiveis > 0;
            var livros = livroRepository.BuscaLivro(expression).OrderBy(l => l.Titulo);
            comboBoxLivroEmprestimo.DataSource = livros.ToList();

            ClienteRepository clienteRepository = new ClienteRepository(context);
            Expression<Func<Cliente, bool>> expresso = c => true;
            var clientes = clienteRepository.BuscaCliente(expresso).OrderBy(l => l.Nome);
            comboBoxClienteEmprestimo.DataSource = clientes.ToList();

            Expression<Func<Emprestimo, bool>> expressionEmprestimo = e => e.DataDevolucaoReal == null;
            EmprestimoRepository emprestimoRepository = new EmprestimoRepository(context);

            var emprestimoViewModel = new List<EmprestimoViewModel>();
            foreach (var emprestimo in expressionEmprestimo)
            {
                emprestimoViewModel.Add(DomainToEmprestimoViewModel(emprestimo));
            }

            dataGridViewEmprestimos.DataSource = emprestimoRepository.BuscaEmprestimo(EmprestimoViewModel).ToList();
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
            FormCadastroLivros form = new FormCadastroLivros(context);
            form.ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            context?.Dispose();
            context = null;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        public void CarregarLivros()
        {
            LivroRepository livrosRepository = new LivroRepository(context);

            //Criar uma expression por fora
            Expression<Func<Livro, bool>> expression = l => true;

            if (textBoxPesquisaLivros.Text != "")
            {
                string filtroPesquisa = textBoxPesquisaLivros.Text.Trim();

                expression = expression.And(l => l.Titulo.Contains(filtroPesquisa) ||
                l.Autor.Contains(filtroPesquisa));

                //Por ano de pesquisa
                int anoPublicacao;
                if (int.TryParse(textBoxPesquisaLivros.Text, out anoPublicacao))
                {
                    expression = expression.And(l => l.AnoPublicacao == anoPublicacao);
                }
            }

            var livros = livrosRepository.BuscaLivro(expression).ToList();
            dataGridViewLivros.DataSource = livros;
        }

        private void buttonPesquisaClientes_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        public void CarregarClientes()
        {
            ClienteRepository clienteRepository = new ClienteRepository(context);

            Expression<Func<Cliente, bool>> expression = l => true;

            if (textBoxPesquisaClientes.Text != "")
            {
                string filtroPesquisa = textBoxPesquisaClientes.Text.Trim();

                expression = expression.And(c => c.CPF.Contains(filtroPesquisa) ||
                c.Nome.Contains(filtroPesquisa)
                || c.Email.Contains(filtroPesquisa));
            }

            var clientes = clienteRepository.BuscaCliente(expression).ToList();

            var clientesViewModel = new List<ClienteViewModel>();
            foreach (var cliente in clientes)
            {
                clientesViewModel.Add(DomainToClienteViewModel(cliente));
            }

            dataGridViewClientes.DataSource = clientesViewModel;
        }

        private void buttonPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

        private void CarregarFuncionario()
        {
            FuncionarioRepository funcionarioRepository = new FuncionarioRepository(context);

            Expression<Func<Funcionario, bool>> expression = l => true;
            if (textBoxPesquisaFuncionarios.Text != "")
            {
                string filtroPesquisa = textBoxPesquisaFuncionarios.Text.Trim();

                expression = expression.And(f => f.CarteiraTrabalho.Contains(filtroPesquisa) ||
                    f.Nome.Contains(filtroPesquisa) ||
                    f.Email.Contains(filtroPesquisa) ||
                    f.NomeUsuario.Contains(filtroPesquisa) ||
                    f.Senha.Contains(filtroPesquisa));
            }

            var funcionarios = funcionarioRepository.BuscaFuncionario(expression).ToList();

            var funcionarioViewModels = new List<FuncionarioViewModel>();
            foreach (var funcionario in funcionarios)
            {
                funcionarioViewModels.Add(DomainToFuncionarioViewModel(funcionario));
            }

            dataGridViewFuncionarios.DataSource = funcionarioViewModels;
        }

        private void buttonEmprestar_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.ClienteID = Convert.ToInt32(comboBoxClienteEmprestimo.SelectedValue);
            emprestimo.LivroID = Convert.ToInt32(comboBoxLivroEmprestimo.SelectedValue);
            emprestimo.DataDevolucaoPrevista = dateTimePickerDataDevolução.Value;
            emprestimo.DataEmprestimo = DateTime.Now;
            emprestimo.DataDevolucaoReal = null;

            EmprestimoRepository emprestimoRepository = new EmprestimoRepository(context);
            emprestimoRepository.Add(emprestimo);

            LivroRepository livroRepository = new LivroRepository(context);

            var livro = livroRepository.GetLivro(emprestimo.LivroID);
            livro.QuantidadeDisponiveis--;

            livroRepository.Editar(livro);

            CarregaDadosEmprestimo();

        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            FormDevolucao formDevolucao = new FormDevolucao(context, this);

            formDevolucao.ShowDialog();
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            CarregaDadosEmprestimo();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

        private void textBoxPesquisaLivros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                CarregarLivros();
            }
        }

        private void textBoxPesquisaClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                CarregarClientes();
            }
        }

        private void textBoxPesquisaFuncionarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                CarregarFuncionario();
            }
        }

        private void buttonCadastroClientes_Click(object sender, EventArgs e)
        {
            FormCadastroClientes form = new FormCadastroClientes(context);
            form.ShowDialog();
        }

        private void buttonCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionarios form = new FormCadastroFuncionarios(context);
            form.ShowDialog();
        }

        private void buttonCadastroLivros_Click(object sender, EventArgs e)
        {
            FormCadastroLivros form = new FormCadastroLivros(context);
            form.ShowDialog();
        }

        public ClienteViewModel DomainToClienteViewModel(Cliente domain)
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel();
            clienteViewModel.CPF = domain.CPF;
            clienteViewModel.Nome = domain.Nome;
            clienteViewModel.Email = domain.Email;
            clienteViewModel.Telefone = domain.Telefone;

            EnderecoRepository enderecoRepository = new EnderecoRepository(context);
            var endereco = enderecoRepository.GetEndereco(domain.EnderecoID);

            clienteViewModel.Endereco = endereco.Rua + ", " + endereco.Numero + ", " + endereco.Complemento + ", " +
                endereco.Bairro + ", " + endereco.Cidade + ", " + endereco.Estado;

            return clienteViewModel;
        }

        public FuncionarioViewModel DomainToFuncionarioViewModel(Funcionario domain)
        {
            FuncionarioViewModel funcionarioViewModel = new FuncionarioViewModel();
            funcionarioViewModel.Nome = domain.Nome;
            funcionarioViewModel.Email = domain.Email;
            funcionarioViewModel.Telefone = domain.Telefone;
            funcionarioViewModel.CarteiraTrabalho = domain.CarteiraTrabalho;
            funcionarioViewModel.NomeUsuario = domain.NomeUsuario;

            EnderecoRepository enderecoRepository = new EnderecoRepository(context);
            var endereco = enderecoRepository.GetEndereco(domain.EnderecoID);

            funcionarioViewModel.Endereco = endereco.Rua + ", " + endereco.Numero + ", " + endereco.Complemento + ", " +
                endereco.Bairro + ", " + endereco.Cidade + ", " + endereco.Estado;

            return funcionarioViewModel;
        }
    }
}
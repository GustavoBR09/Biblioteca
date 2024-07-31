using Biblioteca.Dominio.Entidades;
using Biblioteca.Infra.Data.Context;
using Biblioteca.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormDevolucao : Form
    {
        BibliotecaDBContext context;

        decimal VALORMULTA = 2.0M;
        private readonly FormPrincipal _formPrincipal;
        public FormDevolucao(BibliotecaDBContext ctx, FormPrincipal formPrincipal)
        {
            context = ctx;
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }

        private void FormDevolucao_Load(object sender, EventArgs e)
        {
            //Carregar apenas clientes que tem empréstimo

            //1. Pego os ids dos clientes que tem empréstimo
            var emprestimoRepository = new EmprestimoRepository(context);
            var idUsuarios = emprestimoRepository.BuscaEmprestimo(e => e.DataDevolucaoReal == null).
                Select(e => e.ClienteID).Distinct().ToList();


            //2. Pego o objeto Cliente e preencho o comboBox
            var clienteRepository = new ClienteRepository(context);
            var clientes = clienteRepository.BuscaCliente(c => idUsuarios.Contains(c.Id)).ToList();

            //3. Inserir esses clientes no combobox
            comboBoxClienteDevolucao.DataSource = clientes;
        }

        private void comboBoxClienteDevolucao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Traga todos os livros que estão emprestado para o cliente selecionado
            if (comboBoxClienteDevolucao.SelectedIndex != -1)
            {
                var clienteId = Convert.ToInt32(comboBoxClienteDevolucao.SelectedValue);
                var emprestimoRepository = new EmprestimoRepository(context);
                var idLivros = emprestimoRepository.BuscaEmprestimo(e => e.DataDevolucaoReal == null && e.ClienteID == clienteId).
                    Select(e => e.LivroID).ToList();

                var livroRepository = new LivroRepository(context);
                var livros = livroRepository.BuscaLivro(l => idLivros.Contains(l.Id)).ToList();

                comboBoxLivroDevolucao.DataSource = livros;
            }
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            //1. Vamos pegar o empréstimo com base no cliente e o livro
            int idCliente = Convert.ToInt32(comboBoxClienteDevolucao.SelectedValue);
            int idLivro = Convert.ToInt32(comboBoxLivroDevolucao.SelectedValue);

            EmprestimoRepository emprestimoRepository = new EmprestimoRepository(context);

            var emprestimo = emprestimoRepository.BuscaEmprestimo(e => e.LivroID == idLivro && e.ClienteID == idCliente)
                .FirstOrDefault();

            //2. Colocar o livro como devolvido e ver se tem multa
            emprestimo.DataDevolucaoReal = DateTime.Now;

            if (emprestimo.DataDevolucaoReal.Value.Date > emprestimo.DataDevolucaoPrevista.Date)
            {
                TimeSpan diferencaData = emprestimo.DataDevolucaoReal.Value - emprestimo.DataDevolucaoPrevista;
                int diasAtraso = Convert.ToInt32(diferencaData.TotalDays);
                emprestimo.Multa = diasAtraso * VALORMULTA;
            }

            emprestimoRepository.Editar(emprestimo);

            //3. Vamos adicionar um exemplar no livro como disponível
            LivroRepository livroRepository = new LivroRepository(context);

            Livro livro = livroRepository.GetLivro(idLivro);
            livro.QuantidadeDisponiveis += 1;

            livroRepository.Editar(livro);

            //4. Exibe para o cliente que está tudo ok ou que tem que pagar a multa.
            if (emprestimo.Multa > 0)
            {
                MessageBox.Show("Há uma multa de: R$ " + emprestimo.Multa);
            }
            else
            {
                MessageBox.Show("Não há multas a pagar");
            }

            //5. Fechar essa tela.
            _formPrincipal.CarregaDadosEmprestimo();
            _formPrincipal.CarregarLivros();
            this.Close();

        }
    }
}

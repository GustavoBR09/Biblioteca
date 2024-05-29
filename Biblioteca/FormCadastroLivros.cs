using Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Infra.Data.Repositories;

namespace Biblioteca
{
    public partial class FormCadastroLivros : Form
    {
        public FormCadastroLivros()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            NovoLivro();
            //5. Fechar o formulário
            this.Close();
        }

        private void NovoLivro()
        {
            //1. Criar um novo objeto livro
            Livro livro = new Livro();
            //2. Jogar as informações do formulário no objeto livro
            livro.Titulo = textBoxTitulo.Text;
            livro.Autor = textBoxAutor.Text;
            livro.AnoPublicacao = Convert.ToInt32(textBoxAnoPublicacao.Text);
            //livro.GeneroLiterario = comboBoxGeneroLiterario.Text;
            livro.NumeroPaginas = Convert.ToInt32(numericUpDownNumeroPaginas.Value);
            livro.QuantidadeDisponiveis = Convert.ToInt32(numericUpDownQuantidade.Value);
            //3. Salvar o livro no banco de dados
            LivroRepository repository = new LivroRepository();
            repository.Add(livro);
            //4. Exibir mensagem que salvou
            MessageBox.Show("Livro cadastrado com sucesso.");
        }

        private void buttonCadastrarNovo_Click(object sender, EventArgs e)
        {
            NovoLivro();
            textBoxTitulo.Clear();
            textBoxAutor.Clear();
            textBoxAnoPublicacao.Clear();
            comboBoxGeneroLiterario.SelectedIndex = -1;
            numericUpDownNumeroPaginas.Value = 0;
            numericUpDownQuantidade.Value = 0;
        }
    }
}

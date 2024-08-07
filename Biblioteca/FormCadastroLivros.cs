﻿using Biblioteca.Dominio.Entidades;
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
using Biblioteca.Infra.Data.Context;
using Biblioteca.Dominio.Enums;

namespace Biblioteca
{
    public partial class FormCadastroLivros : Form
    {
        BibliotecaDBContext context;
        public FormCadastroLivros(BibliotecaDBContext ctx)
        {
            context = ctx;
            InitializeComponent();
        }
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
            livro.GeneroLiterario = (Genero)comboBoxGeneroLiterario.SelectedItem;
            livro.NumeroPaginas = Convert.ToInt32(numericUpDownNumeroPaginas.Value);
            livro.QuantidadeDisponiveis = Convert.ToInt32(numericUpDownQuantidade.Value);
            //3. Salvar o livro no banco de dados
            LivroRepository repository = new LivroRepository(context);
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

        private void FormCadastroLivros_Load(object sender, EventArgs e)
        {
            comboBoxGeneroLiterario.DataSource = Enum.GetValues(typeof(Genero));
        }
    }
}

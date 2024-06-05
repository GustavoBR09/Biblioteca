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
    public partial class FormCadastroFuncionarios : Form
    {
        BibliotecaDBContext context;
        public FormCadastroFuncionarios(BibliotecaDBContext ctx)
        {
            context = ctx;
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            NovoFuncionario();
            this.Close();
        }

        private void NovoFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            Endereco endereco = new Endereco();
            funcionario.PessoaEndereco = endereco;
            funcionario.EnderecoID = endereco.Id;

            endereco.Rua = textBoxRua.Text;
            endereco.Bairro = textBoxBairro.Text;
            endereco.Numero = textBoxNumero.Text;
            endereco.Cidade = textBoxCidade.Text;
            endereco.Estado = comboBoxEstado.Text;
            endereco.Complemento = textBoxComplemento.Text;

            EnderecoRepository repositoryend = new EnderecoRepository(context);
            endereco = repositoryend.Add(endereco);

            funcionario.Nome = textBoxNome.Text;
            funcionario.Email = textBoxEmail.Text;
            funcionario.CarteiraTrabalho = textBoxCarteiraTrabalho.Text;
            funcionario.Senha = textBoxSenha.Text;
            funcionario.Telefone = textBoxTelefone.Text;

            FuncionarioRepository repository = new FuncionarioRepository(context);
            funcionario = repository.Add(funcionario);

            MessageBox.Show("Funcionario cadastrado com sucesso.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoFuncionario();
            textBoxRua.Clear();
            textBoxBairro.Clear();
            textBoxNumero.Clear();
            textBoxCidade.Clear();
            comboBoxEstado.SelectedIndex = -1;
            textBoxComplemento.Clear();

            textBoxNome.Clear();
            textBoxEmail.Clear();
            textBoxCarteiraTrabalho.Clear();
            textBoxSenha.Clear();
            textBoxTelefone.Clear();
        }
    }
}

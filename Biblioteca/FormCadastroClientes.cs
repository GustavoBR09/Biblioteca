using Biblioteca.Dominio.Entidades;
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
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            NovoCliente();
            //5. Fechar o formulário
            this.Close();
        }

        private void NovoCliente()
        {
            //1. Criar um novo objeto cliente
            Cliente cliente = new Cliente();
            Endereco endereco = new Endereco();
            cliente.PessoaEndereco = endereco;
            cliente.EnderecoID = endereco.Id;

            //2. Jogar as informações do formulário no objeto cliente
            endereco.Rua = textBoxRua.Text;
            endereco.Complemento = textBoxComplemento.Text;
            endereco.Numero = textBoxNumero.Text;
            endereco.Bairro = textBoxBairro.Text;
            endereco.Cidade = textBoxCidade.Text;
            endereco.Estado = comboBoxEstado.Text;

            EnderecoRepository repositoryend = new EnderecoRepository();
            endereco = repositoryend.Add(endereco);

            cliente.Nome = textBoxNome.Text;
            cliente.Email = textBoxEmail.Text;
            cliente.Telefone = maskedTextBoxTelefone.Text;
            cliente.CPF = maskedTextBoxCPF.Text;

            //3. Salvar o cliente no banco de dados
            ClienteRepository repository = new ClienteRepository();
            repository.Add(cliente);
            //4. Exibir mensagem que salvou
            MessageBox.Show("Cliente cadastrado com sucesso.");
        }

        private void buttonCadastrarNovo_Click(object sender, EventArgs e)
        {
            NovoCliente();
            textBoxNome.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxCPF.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxComplemento.Clear();
            textBoxRua.Clear();
            textBoxNumero.Clear();
            comboBoxEstado.SelectedIndex = -1;
        }
    }
}

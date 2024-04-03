using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Pessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int EnderecoID { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco PessoaEndereco { get; set;}
    }
}

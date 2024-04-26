using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public abstract class Pessoa : Entidade
    {
        public string Nome { get; set; }
        public int EnderecoID { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco PessoaEndereco { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Funcionario : Pessoa 
    {
        public string CarteiraTrabalho { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
    }
}

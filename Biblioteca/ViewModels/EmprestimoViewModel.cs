using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ViewModels
{
    public class EmprestimoViewModel
    {
        public int Id { get; set; }
        public string NomeLivro { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFuncionario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime? DataDevolucaoReal { get; set; }
        public decimal Multa { get; set; }
    }
}

using Biblioteca.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Entidades
{
    public class Livro : Entidade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set;}
        public int AnoPublicacao { get; set;}
        public int NumeroPaginas { get; set;}
        public int QuantidadeDisponiveis { get; set;}
        public Genero  GeneroLiterario { get; set;}
    }
}

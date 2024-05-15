using Biblioteca.Dominio.Enums;

namespace Biblioteca.Dominio.Entidades
{
    public class Livro : Entidade
    {
        public string Titulo { get; set; }
        public string Autor { get; set;}
        public int AnoPublicacao { get; set;}
        public int NumeroPaginas { get; set;}
        public int QuantidadeDisponiveis { get; set;}
        public Genero  GeneroLiterario { get; set;}
    }
}

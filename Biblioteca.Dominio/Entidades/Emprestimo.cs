namespace Biblioteca.Dominio.Entidades
{
    public class Emprestimo : Entidade
    { 
        public int LivroID { get; set; }
        public int ClienteID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime? DataDevolucaoReal {  get; set; }
        public decimal Multa { get; set; }
    }
}

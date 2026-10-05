public class Emprestimo
{
    public int IdEmprestimo {get; set;}
    public int IdUsuario {get; set;}
    public int IdLivro {get; set;}
    public DateTime DataEmprestimo {get; set;}
    public DateTime DataDevolucao {get; set;}
    public Usuario Usuario {get; set;}
    public Livro Livro {get; set;}

    public Emprestimo(Usuario Usuario, Livro livro){
        Usuario = usuario;
        this.IdUsuario = 
    }
}
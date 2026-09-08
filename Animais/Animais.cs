internal class Animais
{
    public string Nome {get; set;}

    public virtual void FazerSom(){
        System.Console.WriteLine("O animal faz um som");
    }

    public virtual void Mover(){
        System.Console.WriteLine("O animal se moveu");
    }
}
abstract class Forma
{
    public string Cor {get; set;}
    public void Pintar(){
        System.Console.WriteLine($"Pintando a forma de {Cor}");
    }

    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
    public abstract void Desenhar();
}

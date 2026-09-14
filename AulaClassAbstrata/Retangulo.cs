class Retangulo : Forma
{
    public double Largura {get; set;}
    public double Altura {get; set;}
    public override double CalcularArea()
    {
        return Largura * Altura;
    }
    public override double CalcularPerimetro()
    {
        return 2* (Largura + Altura);
    }

    public override void Desenhar()
    {
        System.Console.WriteLine($"Desenhando retângulo {Largura}x{Altura}");
    }
}
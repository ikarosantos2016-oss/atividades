class Circulo : Forma
{
    public double raio {get; set;}
    public override double CalcularArea()
    {
        return Math.PI*Math.Pow(raio,2);
    }
    public override double CalcularPerimetro()
    {
        return 2*Math.PI*raio;
    }
    public override void Desenhar()
    {
        System.Console.WriteLine($"Desenhando circulo de raio: {raio}");
    }
}
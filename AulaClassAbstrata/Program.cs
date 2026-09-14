void Main()
{
    Forma[] formas = {
        new Retangulo {Largura = 10, Altura = 5, Cor = "Azul"},
        new Circulo {raio= 5, Cor = "Preto"},
    };

    foreach (Forma forma in formas)
    {
        forma.Pintar();
        System.Console.WriteLine($"Área: {forma.CalcularArea()}");
        System.Console.WriteLine($"Perimetro: {forma.CalcularPerimetro()}");
        System.Console.WriteLine("---");
    }
}

Main();
using System;
namespace Carro;

public class Carro
{
    public string Modelo {get; set;}
    public string Cor {get; set;}
    public int Ano {get; set;}

    public Carro()
    { 
    }

    public Carro(string modelo, string cor, int ano)
    {
        this.Modelo = modelo;
        this.Cor = cor;
        this.Ano = ano;
    }

    public void EcibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Ano: {Ano}");

    }

}

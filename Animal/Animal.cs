using System;
using System.Globalization;
public class Animal
{
    private string Nome;
    private string Especie;
    private int Idade;
    private bool EstaDormindo = false;

    public Animal(string nome, string especie, int idade)
    {
        this.Nome = nome;
        this.Especie = especie;
        this.Idade = idade;
    }

    public void Dormir()
    {
        EstaDormindo = true;
        System.Console.WriteLine("O animal está dormindo");
    }

    public void Acordar()
    {
        EstaDormindo = false;
        System.Console.WriteLine("O animal acordou");
    }

    public void FazerSom()
    {
        System.Console.WriteLine("O animal fez um som");
    }

    public void ApresentarSer()
    {
        System.Console.WriteLine($"O animal se chama: {Nome}, é da especie: {Especie} e tem {Idade} anos.");
    }
}

using System;
using System.Globalization;

public class JogadorFutebol
{
    private string Nome;
    private int Energia = 100;
    private int Gols = 0;
    private bool EstadoJogando = false;

    public JogadorFutebol (string nome)
    {
        this.Nome = nome;
    }

    public void IniciarJogo()
    {
        EstadoJogando = true;
        System.Console.WriteLine("Jogador esta em campo");
    }

    public void TerminarJogo()
    {
        EstadoJogando = false;
        System.Console.WriteLine("Jogo terminado, jogador no vestiario");
    }

    public void Correr()
    {
        if(EstadoJogando = true && Energia > 0)
        {
            Energia -= 10;
            System.Console.WriteLine($"Quantidade de energia: {Energia}");
        }
        else
        {
            System.Console.WriteLine("Não da para ficar cansado no banco amigo!");
        }
    }

    public void FazerGol()
    {
        if(EstadoJogando = true && Energia > 0)
        {
            Gols++;
            Energia -= 5;
            System.Console.WriteLine($"Quantidade de gols: {Gols}, quantidade de enrgia: {Energia}");
        }
        else
        {
            System.Console.WriteLine("Jogador ruim!");
        }
    }

    public void Descansar()
    {
        if(EstadoJogando = false && Energia < 100)
        {
            Energia += 20;
            System.Console.WriteLine($"O jogador agora esta com {Energia} de energia");
        }
        else
        {
            System.Console.WriteLine($"Jogador continua com {Energia} de energia");
        }
    }

    public void MostrarStatus()
    {
        System.Console.WriteLine($"Nome: {Nome}, energia: {Energia}, gols: {Gols}");
    }
}

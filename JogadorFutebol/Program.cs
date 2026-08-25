using System;

public class Program
{
    public static void Main(string[] args)
    {
        JogadorFutebol ikaro = new JogadorFutebol("ikaro");

        ikaro.IniciarJogo();
        ikaro.Correr();
        ikaro.Correr();
        ikaro.Correr();
        ikaro.FazerGol();
        ikaro.FazerGol();
        ikaro.TerminarJogo();
        ikaro.Descansar();
        ikaro.MostrarStatus();
    }
}

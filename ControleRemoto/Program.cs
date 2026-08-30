using System;
using System.Globalization;

public class Program
{
    public static void Main(string [] args)
    {
        ControleRemoto controle = new ControleRemoto();

        controle.MostrarStatus();
        controle.LigarTV();
        controle.MostrarStatus();
        controle.MudarCanal(20);
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.CanalPosterior();
        controle.CanalPosterior();
        controle.CanalPosterior();
        controle.CanalAnterior();
    }
}

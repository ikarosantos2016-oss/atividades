using System;
using System.Globalization;
using System.Runtime.CompilerServices;

public class ControleRemoto
{
    private int CanalAtual = 1;
    private int VolumeAtual = 10;
    private bool EstaLigado = false;
    private int CanaisDisponiveis = 50;

    private int a=0, b=0, c=0, d=0, e=0;

    public ControleRemoto()
    {

    }

    public void LigarTV()
    {
        EstaLigado = true;
        System.Console.WriteLine("TV foi ligada!");
    }
    public void DesligarTV()
    {
        if (EstaLigado == true)
        {
            EstaLigado = false;
            System.Console.WriteLine("TV foi desligada");
        }

    }

    public void AumentarVolume()
    {
        if (VolumeAtual < 30)
        {
            VolumeAtual++;
            System.Console.WriteLine($"Volume: {VolumeAtual}");
        }
        else
        {
            System.Console.WriteLine("Volume no máximo!");
        }
    }

    public void DiminuirVolume()
    {
        if (VolumeAtual > 0 && EstaLigado == true)
        {
            VolumeAtual--;
            System.Console.WriteLine($"Volume: {VolumeAtual}");
        }
        else
        {
            System.Console.WriteLine("Volume no minimo!");
        }
    }

    public void MudarCanal(int novoCanal)
    {
        if (novoCanal <= 50 && novoCanal >= 1 && EstaLigado == true)
        {
            CanalAtual = novoCanal;
            System.Console.WriteLine($"Canal Atualizado: {CanalAtual}");

            AjustarSinal();
            Historico();
        }
        else
        {
            System.Console.WriteLine("Canal fora da faixa de canais!");
        }
    }

    public void CanalAnterior()
    {
        if (CanalAtual > 1 && EstaLigado == true)
        {
            CanalAtual--;
            System.Console.WriteLine($"Canal atual: {CanalAtual}");

            AjustarSinal();
            Historico();
        }
        else
        {
            System.Console.WriteLine("Limite minimo de canais atingindo!");
        }
    }

    public void CanalPosterior()
    {
        if (CanalAtual < 50 && EstaLigado == true)
        {
            CanalAtual++;
            System.Console.WriteLine($"Canal atual: {CanalAtual}");
            AjustarSinal();
            Historico();
        }
        else
        {
            System.Console.WriteLine("Máximo de canais atingindos!");
        }
    }

    public void MostrarStatus()
    {
        if (EstaLigado == true)
        {
            System.Console.WriteLine($"Volume: {VolumeAtual}\nCanal atual: {CanalAtual}");
        }
        else
        {
            System.Console.WriteLine("Primeiro ligue a TV");
        }
        
    }

    private void ValidarCanal(int canal)
    {
        if (canal <= 50 && canal >= 1 && EstaLigado == true)
        {
            System.Console.WriteLine("Canal validado!");
        }
        else
        {
            System.Console.WriteLine("Esse canal esta fora da faixa de canais!");
        }
    }

    private void AjustarSinal()
    { 
        if(EstaLigado == true)
        {
            System.Console.WriteLine("Sinal ajustado. CONFIA!");
        }
        
    }

    private void VerificarEnergia()
    {
        if (EstaLigado == true)
        {
            System.Console.WriteLine("Energia OK");
        }
        else
        {
            System.Console.WriteLine("Liga a TV primeiro @_@");
        }
    }

    private void Historico()
    {
         e=d;
         d=c;
         c=b;
         b=a;
         a=CanalAtual;

        System.Console.WriteLine("Historico atualizado");
        System.Console.WriteLine($"Ultimos Canais: {a}, {b}, {c}, {d}, {e}");
    }
}

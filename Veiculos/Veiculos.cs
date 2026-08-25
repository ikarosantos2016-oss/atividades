using System;

public class Veiculos
{
    protected string Nome;
    protected bool Partida = false;
    protected bool Desligar = false;
    protected int Velocidade;
    protected int Aceleracao;

    public Veiculos(string nome, int velocidade, int aceleracao){
        this.Nome = nome;
        this.Velocidade = velocidade;
        this.Aceleracao = aceleracao;
    }

    public void LigarVeiculo(){
        if(Velocidade == 0 && Aceleracao == 0 && Partida == False){
            Partida = true;
            Desligar = false;
            System.Console.WriteLine($"O(A) {Nome} foi ligado(a)!");
        }else{
            System.Console.WriteLine($"O(A) {Nome} já esta ligado(a)");
        }
    }

    public void DesligarVeiculo(){
        if(Velocidade == 0 && Aceleracao == 0 && Partida == True){
            Desligar = true;
            Partida = false;
            System.Console.WriteLine($"Seu(a) {Nome} foi desligado(a)");

        }else{
            System.Console.WriteLine($"Seu(a) {Nome} Não pode desligar no momento");
        }
    }
}
